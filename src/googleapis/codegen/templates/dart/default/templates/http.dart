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

#library('http');

#import('dart:html');

/** An Authenticator adds credentials to an HttpRequest. */
interface Authenticator {
  /**
   * Adds credentials to an [HttpRequest].
   * This method may mutate [request] and return it, or return a new HttpRequest.
   */
  Future<HttpRequest> authenticate(HttpRequest request);
}

/** A simple HTTP client request, wrapping XMLHttpRequest. */
class HttpRequest {
  final String url;
  final String method;
  final Map<String, String> headers;

  HttpRequest(String this.url, String this.method, [headers = const {}]) : this.headers = new Map.from(headers);

  /**
   * Issues this request.
   * Returns a future that provides the HTTP response body.
   * The future throws a NetworkException or HttpException in case of error.
   */
  Future<String> request([String body]) {
    final completer = new Completer<String>();
    final req = new XMLHttpRequest();
    req.open(method, url, true, null, null);
    headers.forEach(req.setRequestHeader);
    req.on.error.add((Event event) {
      completer.completeException(new NetworkException());
    });
    req.on.load.add((Event event) {
      if (req.status >= 400) {
        completer.completeException(new HttpException(req.status));
      } else {
        completer.complete(req.responseText);
      }
    });
    req.send(body);

    return completer.future;
  }
}

/** Indicates that a request could not be completed. */
class NetworkException implements Exception {
  NetworkException();
}

/** Indicates that a request completed and returned an HTTP error code. */
class HttpException implements Exception {
  int code;
  HttpException(int this.code);
}
