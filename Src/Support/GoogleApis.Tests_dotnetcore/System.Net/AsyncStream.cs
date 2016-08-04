using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
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
        // If the end of stream is reached, the bytes read so far are returned.
        public async Task<IEnumerable<byte>> ReadWhile(Func<List<byte>, bool> predicate, CancellationToken ct = default(CancellationToken))
        {
            List<byte> result = new List<byte>();
            while (true)
            {
                byte b;
                if (_bufferOffset >= _bufferCount)
                {
                    _bufferCount = await _stream.ReadAsync(_buffer, 0, _buffer.Length, ct);
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

        public async Task<IEnumerable<byte>> ReadCount(int count)
        {
            if (count == 0)
            {
                return new byte[0];
            }
            return await ReadWhile(bytes => bytes.Count < count);
        }

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
            });
            return encoding.GetString(linebytes.ToArray());
        }
    }
}
