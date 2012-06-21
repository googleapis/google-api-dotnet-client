using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.Apis.Json;
using Google.Apis.Util;
using Newtonsoft.Json;

namespace Google.Apis.Discovery
{
    public class MediaUpload
    {
        private const string AcceptsPath = "accept";
        private const string MaxPathPath = "maxPath";
        private const string ProtocolsPath = "protocols";
        private const string SimplePath = "simple";
        private const string ResumablePath = "resumable";

        private readonly JsonDictionary information;

        /// <summary>
        /// Initialize a new MediaUpload object from a JsonDictionary describing its configuration.
        /// </summary>
        /// <param name="dict"></param>
        public MediaUpload(JsonDictionary dict)
        {
            if (dict == null)
                throw new ArgumentNullException("dict");
            information = dict;

            accepts = new LazyResult<string[]>(() =>
            {
                var acceptList = information[AcceptsPath] as IEnumerable<object>;
                return acceptList == null ?
                    new string[] { } : acceptList.Select(x => x as string).ToArray();
            });

            var protocols = information[ProtocolsPath] as JsonDictionary;
        }

        LazyResult<string[]> accepts;

        /// <summary>
        /// MIME Media Ranges for acceptable media uploads to this method.
        /// </summary>
        public string[] Accepts { get { return accepts.GetResult(); } }

        /// <summary>
        /// Maximum size of a media upload, such as "1MB", "2GB" or "3TB".
        /// </summary>
        public string MaxSize { get { return information["maxSize"] as string; } }

        public MediaUploadProtocol Resumable
        {
            get
            {
                return new MediaUploadProtocol(this.Protocols.Get<JsonDictionary>(ResumablePath));
            }
        }

        private JsonDictionary Protocols
        {
            get
            {
                return information.Get<JsonDictionary>(ProtocolsPath);
            }
        }

        public MediaUploadProtocol Simple
        {
            get
            {
                return new MediaUploadProtocol(this.Protocols.Get<JsonDictionary>(SimplePath));
            }
        }

        public class MediaUploadProtocol
        {
            private const string PathPath = "path";
            private const string MultiPartPath = "multipart";

            private readonly JsonDictionary information;

            public MediaUploadProtocol(JsonDictionary dict)
            {
                if (dict == null)
                {
                    throw new ArgumentException("Invalid dictionary");
                }
                information = dict;
            }

            public string Path { get { return information[PathPath] as string; } }

            public bool MultiPart
            {
                get
                {
                    return information.ContainsKey(MultiPartPath) && Convert.ToBoolean(information[MultiPartPath]);
                }
            }
        }
    }
}
