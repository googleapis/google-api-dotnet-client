using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Google.Apis.Requests
{
    class JsonStreamContent : HttpContent
    {
        readonly object data;
        readonly ISerializer serializer;

        public JsonStreamContent(object data, ISerializer serializer)
        {
            this.data = data;
            this.serializer = serializer;
        }

        protected override async Task SerializeToStreamAsync(Stream stream, TransportContext context)
        {
            // Leave the stream open as its lifetime should be controlled by the HttpClient.
            serializer.Serialize(data, stream, true);
            await stream.FlushAsync().ConfigureAwait(false);
        }

        protected override bool TryComputeLength(out long length)
        {
            // We do not know the length
            length = -1;
            return false;
        }
    }
}