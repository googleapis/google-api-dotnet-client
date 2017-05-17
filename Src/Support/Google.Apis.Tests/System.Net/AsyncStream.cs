/*
Copyright 2017 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

#if NETCOREAPP1_0 || NETCOREAPP1_1

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
    // Make a stream availabel through various async methods.
    class AsyncStream
    {
        public AsyncStream(Stream stream)
        {
            _stream = stream;
        }

        private readonly Stream _stream;

        private byte[] _buffer = new byte[1024];
        private int _bufferCount = 0;
        private int _bufferOffset = 0;

        // Read bytes until the predicate returns false.
        // The returned IEnumerable will contain the final byte that caused the predicate to fail.
        // If the end of stream is reached, the bytes read so far are returned.
        public async Task<IEnumerable<byte>> ReadWhile(Func<List<byte>, bool> predicate, CancellationToken ct = default(CancellationToken))
        {
            List<byte> result = new List<byte>();
            while (true)
            {
                byte b;
                if (_bufferOffset >= _bufferCount)
                {
                    _bufferCount = await _stream.ReadAsync(_buffer, 0, _buffer.Length, ct).ConfigureAwait(false);
                    if (_bufferCount == 0)
                    {
                        // End of stream, return what's been read.
                        break;
                    }
                    _bufferOffset = 0;
                }
                b = _buffer[_bufferOffset];
                _bufferOffset += 1;
                result.Add(b);
                if (!predicate(result))
                {
                    break;
                }
            }
            return result;
        }

        // Read the requested number of bytes from the stream;
        // or fewer bytes if the stream ends before count bytes have been read.
        public async Task<IEnumerable<byte>> ReadCount(int count)
        {
            if (count == 0)
            {
                return Enumerable.Empty<byte>();
            }
            return await ReadWhile(bytes => bytes.Count < count).ConfigureAwait(false);
        }

        // Read a line from the stream, up to and including the endOfLine string.
        // If the line is longer than maxBytes then an InvalidOperationException will be thrown.
        // The default Encoding is UTF8.
        public async Task<string> ReadLine(string endOfLine = "\r\n", Encoding encoding = null, int maxBytes = 2048)
        {
            encoding = encoding ?? Encoding.UTF8;
            byte[] endOfLineBytes = encoding.GetBytes(endOfLine);
            var linebytes = await ReadWhile(bytes => {
                if (bytes.Count > maxBytes)
                {
                    throw new InvalidOperationException("Line too long");
                }
                return !bytes.EndsWith(endOfLineBytes);
            }).ConfigureAwait(false);
            return encoding.GetString(linebytes.ToArray());
        }
    }
}

#elif NET452 || NET46
// Nothing required
#else
#error Unsupported platform
#endif
