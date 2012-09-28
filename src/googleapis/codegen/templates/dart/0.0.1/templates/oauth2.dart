// Copyright 2012 Google Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#library('oauth2');

#import('dart:json');
#import('dart:html');
#import('dart:uri');
#import('utils.dart');
#import('http.dart');

/// An OAuth2 authentication context.
class OAuth2 implements Authenticator {
  String _clientId;
  List<String> _scopes;
  String _provider;
  Function _tokenLoaded;

  Future<_ProxyChannel> _channel;

  /// Future of the token we're waiting for.
  Future<Token> _tokenFuture;
  /// Destination for not-yet-validated tokens we're waiting to receive over
  /// the proxy channel.
  Completer<Token> _tokenCompleter;
  /// The last fetched token.
  Token __token; // Double-underscore because it has a private setter _token.

  /// Creates an OAuth2 context for the application identified by [clientId]
  /// and the permissions described by [scopes].
  /// If [tokenLoaded] is provided, it will be called with a [Token] when one
  /// is available. This can be used e.g. to set up a 'logged in' view.
  OAuth2(String clientId, List<String> scopes,
      [String provider = "https://accounts.google.com/o/oauth2/",
      tokenLoaded(Token token)])
      : _clientId = clientId,
      _scopes = scopes,
      _provider = provider,
      _tokenLoaded = tokenLoaded {
    _channel = _createFutureChannel();
    // Attempt an immediate login, we may already be authorized.
    login(immediate:true);
  }

  /// Set up the proxy iframe in the provider's origin that will receive
  /// postMessages and relay them to us.
  /// This completes asynchronously as the proxy iframe is not ready to use
  /// until we've received an 'oauth2relayReady' message from it.
  Future<_ProxyChannel> _createFutureChannel() {
    final completer = new Completer<_ProxyChannel>();
    var channel;
    channel = new _ProxyChannel(_provider, (subject, args) {
      switch (subject) {
        case "oauth2relayReady":
          completer.complete(channel);
          break;
        case "oauth2callback":
          try {
            Token token = Token._parse(args[0]);
            _tokenCompleter.complete(token);
          } catch (Exception exception) {
            _tokenCompleter.completeException(exception);
          }
          break;
      }
    });
    return completer.future;
  }

  /// Get the URI that prompts the user for pemission (if required).
  String _getAuthorizeUri(bool immediate) {
    Map<String, String> queryParams = {
      "response_type": "token",
      "client_id": _clientId,
      "origin": window.location.origin,
      "redirect_uri": "postmessage", // Response will post to the proxy iframe
      "scope": Strings.join(_scopes, " "),
      "immediate": immediate,
    };
    return new UrlPattern("${_provider}auth").generate({}, queryParams);
  }

  /// Attempt to authenticate.
  /// If you have an existing valid token, it will be immediately returned.
  /// If you have an expired token, it will be silently renewed (override
  ///   with immediate:false)
  /// If you have no token, a popup prompt will be displayed.
  /// If the user declines, closes the popup, or the service returns a token
  /// that cannot be validated, an exception will be delivered.
  Future<Token> login([immediate=null]) {
    if (token != null) {
      if (token.expired) {
        if (immediate == null) {
          immediate = true; // We should be able to simply renew
        }
      } else { // We already have a good token
        return new Future<Token>.immediate(token);
      }
    }
    if (immediate == null) {
      immediate = false;
    }

    // Login may already be in progress
    if (_tokenFuture != null) {
      // An in-progress request will satisfy an immediate request
      // (even if it's not immediate).
      if (!immediate) {
        Completer result = new Completer<Token>();
        _tokenFuture.onComplete((v) {
          if (v.hasValue) return result.complete(v.value);
          login(immediate:immediate).onComplete((f) {
            if (f.hasValue) return result.complete(f.value);
            result.completeException(f.exception);
          });
        });
        return result.future;
      }
    } else {
      Completer<Token> tokenCompleter = new Completer();
      tokenCompleter.future.onComplete((tok) {
        _tokenFuture = null;
        _token = tok.hasValue ? tok.value : null;
      });
      _tokenFuture = tokenCompleter.future;

      completeByPromptingUser() {
        _tokenCompleter = _wrapValidation(tokenCompleter);

        // Synchronous if the channel is already open -> avoids popup blocker
        _channel.onComplete((proxyChannel) {
          if (!proxyChannel.hasValue) {
            return _tokenCompleter.completeException(proxyChannel.exception);
          }
          String uri = _getAuthorizeUri(immediate);
          if (immediate) {
            IFrameElement iframe = _iframe(uri);
            _tokenCompleter.future.onComplete((f) => iframe.remove());
          } else {
            Window popup = _popup(uri);
            new _WindowPoller(_tokenCompleter, popup).poll();
          }
        });
      }

      final stored = _storedToken;
      if ((stored != null) && !stored.expired) {
        stored.validate(_clientId).onComplete((f) {
          if (f.hasValue) {
            tokenCompleter.complete(stored);
          } else {
            completeByPromptingUser();
          }
        });
      } else {
        completeByPromptingUser();
      }
    }
    return _tokenFuture;
  }

  Future<HttpRequest> authenticate(HttpRequest request) => login().transform((token) {
    request.headers["Authorization"] = "${token.type} ${token.data}";
    return request;
  });

  /// Returns the OAuth2 token, if one is currently available.
  Token get token() => __token;

  set _token(Token value) {
    final invokeCallbacks = (__token == null) && (value != null);
    try {
      _storedToken = value;
    } catch (final e) {
      print("Failed to cache OAuth2 token: $e");
    }
    __token = value;
    if (invokeCallbacks && (_tokenLoaded != null)) window.setTimeout(() {
      try {
        _tokenLoaded(value);
      } catch (final e) {
        print("Failed to invoke tokenLoaded callback: $e");
      }
    }, 0);
  }

  Token get _storedToken() => window.localStorage.containsKey(_storageKey)
      ? new Token.fromJson(window.localStorage[_storageKey])
      : null;

  set _storedToken(Token value) => (value == null)
      ? window.localStorage.remove(_storageKey)
      : window.localStorage[_storageKey] = value.toJson();

  /// Returns a unique identifier for this context for use in localStorage.
  String get _storageKey() => JSON.stringify({
    "clientId": _clientId,
    "scopes": _scopes,
    "provider": _provider,
  });
  
  /// Takes a completer that accepts validated tokens, and returns a completer
  /// that accepts unvalidated tokens.
  Completer<Token> _wrapValidation(Completer<Token> validTokenCompleter) {
    Completer<Token> result = new Completer();
    result.future.onComplete((future) {
      if (!future.hasValue) {
        return validTokenCompleter.completeException(future.exception);
      }
      future.value.validate(_clientId).onComplete((validation) {
        if (!validation.hasValue) {
          return validTokenCompleter.completeException(validation.exception);
        }
        if (validation.value) {
          validTokenCompleter.complete(future.value);
        } else {
          validTokenCompleter.completeException(
              new Exception("Server returned token is invalid"));
        }
      });
    });
    return result;
  }
}

/// Polls until either the future is completed or the window is closed.
/// If the window was closed without the future being completed, completes
/// the future with an exception.
class _WindowPoller {
  Completer<Token> _completer;
  Window _window;
  _WindowPoller(Completer<Token> this._completer, Window this._window);

  void poll() {
    if (_completer.future.isComplete) {
      return;
    }
    if (_window.closed) {
      _completer.completeException(new Exception("User closed the window"));
    } else {
      window.setTimeout(poll, 500);
    }
  }
}

typedef void _ProxyCallback(String subject, List<String> args);

/// Sets up a channel for listening to the token information posted by the
/// authorization url using the postMessage flow.
///
/// We create a hidden iframe hosting the provider's 'postmessageRelay' page,
/// which receives token information from the authorization popup and posts
/// it to this document. We also add a message listener to this document. 
/// It detects such messages and invokes the provided callback.
class _ProxyChannel {
  String _nonce;
  String _provider;
  String _expectedOrigin;
  IFrameElement _element;
  _ProxyCallback _callback;

  _ProxyChannel(String this._provider, _ProxyCallback this._callback) {
    _nonce = (0x7FFFFFFF & random()).toString();
    _expectedOrigin = _origin(_provider);
    _element = _iframe(_getProxyUrl());
    window.on.message.add(_onMessage);
  }

  void close() {
    _element.remove();
    window.on.message.remove(_onMessage);
  }

  void _onMessage(MessageEvent event) {
    if (event.origin != _expectedOrigin) return;
    var data;
    try {
      data = JSON.parse(event.data);
    } catch (final e) {
      print("Invalid JSON received via postMessage: ${event.data}");
      return;
    }
    if (!(data is Map) || (data['t'] != _nonce)) {
      return;
    }
    String subject = data['s'];
    if (subject.endsWith(':$_nonce')) {
      subject = subject.substring(0, subject.length - _nonce.length - 1);
    }
    _callback(subject, data['a']);
  }

  /// Computes the javascript origin of an absolute URI.
  String _origin(String uriString) {
    final uri = new Uri.fromString(uriString);
    final portPart = (uri.port != 0) ? ":${uri.port}" : "";
    return "${uri.scheme}://${uri.domain}$portPart";
  }

  String _getProxyUrl() {
    Map<String, String> proxyParams = {"parent": window.location.origin};
    String proxyUrl = new UrlPattern("${_provider}postmessageRelay")
        .generate({}, proxyParams);
    return new Uri.fromString(proxyUrl)
        .resolve("#rpctoken=$_nonce&forcesecure=1").toString();
  }
}

/// An OAuth2 authentication token. 
class Token {
  /// The token type, usually "Bearer"
  final String type;
  /// The raw token data used for authentication
  final String data;
  /// Time at which the token will be expired
  final Date expiry;
  /// The email address of the user, only set if the scopes include
  /// https://www.googleapis.com/auth/userinfo.email
  String get email() => _email;
  /// A unique identifier of the user, only set if the scopes include
  /// https://www.googleapis.com/auth/userinfo.profile
  String get userId() => _userId;
  String _email;
  String _userId;

  Token(String this.type, String this.data, Date this.expiry);

  factory Token.fromJson(String json) {
    final map = JSON.parse(json);
    final token = new Token(map['type'], map['data'],
        new Date.fromMillisecondsSinceEpoch(map['expiry']));
    token._email = map['email'];
    token._userId = map['userId'];
    return token;
  }

  bool get expired() => new Date.now().compareTo(expiry) > 0;

  String toString() => "[Token type=$type, data=$data, expired=$expired, "
      "expiry=$expiry, email=$email, userId=$userId]";

  /// Query whether this token is still valid.
  Future<bool> validate(String clientId,
      [String service="https://www.googleapis.com/oauth2/v1/tokeninfo"]) {
    String url = new UrlPattern(service).generate({}, {"access_token": data});
    return new HttpRequest(url, 'GET').request().transform((json) {
      final data = JSON.parse(json);
      final valid = clientId == data['audience'];
      if (valid) {
        _email = data['email'];
        _userId = data['user_id'];
      }
      return valid;
    });
  }

  String toJson() {
    return JSON.stringify({
      "type": type,
      "data": data,
      "expiry": expiry.millisecondsSinceEpoch,
      "email": email,
      "userId": userId,
    });
  }

  static Token _parse(String data) {
    if (data == null) {
      throw new Exception("No auth token data");
    }

    Map<String, String> params = {};
    for (String kv in _tokenizeRelativeUrl(data)) {
      if (kv.isEmpty()) {
        continue;
      }
      int eqIndex = kv.indexOf('=');
      if (eqIndex < 0) {
        params[kv] = "";
      } else {
        params[kv.substring(0, eqIndex)] = kv.substring(eqIndex + 1);
      }
    }

    if (params.containsKey('error')) {
      throw new AuthException(params['error'], params);
    }
    for (String param in ['access_token', 'token_type', 'expires_in']) {
      if (!params.containsKey(param)) {
        throw new Exception("Missing parameter $param");
      }
    }

    // Mark tokens as 'expired' 20 seconds early so it's still valid when used.
    Duration duration =
        new Duration(seconds: Math.parseInt(params['expires_in']) - 20);
    return new Token(params['token_type'], params['access_token'],
        new Date.now().add(duration));
  }
  
  /// Extracts &-separated tokens from the path, query, and fragment of [uri].
  static List<String> _tokenizeRelativeUrl(String uri) {
    final u = new Uri.fromString(uri);
    final result = [];
    [u.path, u.query, u.fragment].forEach((x) {
      if (x != null) result.addAll(_tokenize(x));
    });
    return result;
  }
  
  static List<String> _tokenize(String data) {
    return data.isEmpty() ? [] : data.split('&');
  }
}

class AuthException implements Exception {
  final String message;
  final Map<String, String> data;
  AuthException(this.message, this.data);
  toString() => "AuthException: $message";
}

/// Opens a popup centered on the screen displaying the provided URL.
Window _popup(String url) {
  // Popup is desigend for 650x600, but don't make one bigger than the screen!
  int width = Math.min(650, window.screen.width - 20);
  int height = Math.min(600, window.screen.height - 30);
  int left = (window.screen.width - width) ~/ 2;
  int top = (window.screen.height - height) ~/ 2;
  return window.open(url, "_blank", "toolbar=no,location=no,directories=no,"
    "status=no,menubar=no,scrollbars=yes,resizable=yes,copyhistory=no,"
    "width=$width,height=$height,top=$top,left=$left");
}

/// Creates a hidden iframe displaying the provided URL.
IFrameElement _iframe(String url) {
  IFrameElement iframe = new Element.tag("iframe");
  iframe.src = url;
  iframe.style.position = "absolute";
  iframe.width = iframe.height = "1";
  iframe.style.top = iframe.style.left = "-100px";
  document.body.elements.add(iframe);
  return iframe;
}
