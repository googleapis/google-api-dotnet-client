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

#library('utils');
#import('dart:uri');
#import('dart:html');

/// A Transform<T> is a function from T to T.
typedef T Transform<T>(T value);

/** Returns a Transform<List> that applies [:transform:] to every element. */
Transform<List> map(Transform<Object> transform) {
  return (List input) {
    if (input == null) return null;
    final result = new List();
    input.forEach((value) => result.add(transform(value)));
    return result;
  };
}

/** Returns a Transform<List> that applies [:transform:] to every value, and preserves keys. */
Transform<Map> mapValues(Transform<Object> transform) {
  return (Map input) {
    if (input == null) return null;
    final result = new Map();
    input.forEach((key, value) => result[key] = transform(value));
    return result;
  };
}

/** The identity transform. */
identity(t) => t;

/** Base class that implements Hashable with identity semantics. */
class IdentityHash implements Hashable {
  static int _cnt = 0;
  int _id;
  IdentityHash() : _id = _cnt++;
  int hashCode() => _id;
}

/** Produces part of a URL, when the template parameters are provided. */
typedef String _UrlPatternToken(Map<String, Object> params);
/** URL template with placeholders that can be filled in to produce a URL. */
class UrlPattern {
  List<_UrlPatternToken> _tokens;
  /**
   * Creates a UrlPattern from the specification [:pattern:].
   * See http://tools.ietf.org/html/draft-gregorio-uritemplate-07
   * We only implement a very simple subset for now.
   */
  UrlPattern(String pattern) : _tokens = [] {
    var cursor = 0;
    while (cursor < pattern.length) {
      final open = pattern.indexOf("{", cursor);
      if (open < 0) {
        final rest = pattern.substring(cursor);
        _tokens.add((params) => rest);
        cursor = pattern.length;
      } else {
        if (open > cursor) {
          final intermediate = pattern.substring(cursor, open);
          _tokens.add((params) => intermediate);
        }
        final close = pattern.indexOf("}", open);
        if (close < 0) throw new IllegalArgumentException("Token meets end of text: $pattern");
        String variable = pattern.substring(open + 1, close);
        _tokens.add((params) => (params[variable] == null) 
            ? 'null'
            : encodeUriComponent(params[variable].toString()));
        cursor = close + 1;
      }
    }
  }
  /** Generate a URL with the specified list of URL and query parameters. */
  String generate(Map<String, Object> urlParams, Map<String, Object> queryParams) {
    final buffer = new StringBuffer();
    _tokens.forEach((token) => buffer.add(token(urlParams)));
    var first = true;
    queryParams.forEach((key, value) {
      if (value == null) return;
      buffer.add(first ? '?' : '&');
      if (first) first = false;
      buffer.add(encodeUriComponent(key.toString()));
      buffer.add('=');
      buffer.add(encodeUriComponent(value.toString()));
    });
    return buffer.toString();
  }
}

class _Unspecified {
  const _Unspecified._internal();
}
/** A sentinel to be used as a default parameter value. */
final UNSPECIFIED = const _Unspecified._internal();

/// Returns a random unsigned 32-bit integer. 
int random() {
  final ary = new Uint32Array(1);
  window.crypto.getRandomValues(ary);
  return ary[0];
}