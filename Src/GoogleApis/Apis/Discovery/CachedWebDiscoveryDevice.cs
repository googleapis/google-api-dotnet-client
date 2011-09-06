/*
Copyright 2010 Google Inc

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

// Don't include the CachedWebDiscoveryDevice on Silverlight as the File-operations are not available,
// and because this discovery implementation should not be used at runtime.
#if !SILVERLIGHT

using System;
using System.IO;
using System.Net;
using Google.Apis.Logging;
using Google.Apis.Util;

namespace Google.Apis.Discovery
{
    /// <summary>
    /// WebDiscoveryDevice allows clients to fetch discovery documents from a web based service.
    /// Caches discovery files locally to prevent unnecessary requests to the discovery server
    /// </summary>
    public class CachedWebDiscoveryDevice : IDiscoveryDevice
    {
        private const int BufferSize = 32 * 1024; // 32kb
        private static readonly ILogger logger = ApplicationContext.Logger.ForType<CachedWebDiscoveryDevice>();

        private DirectoryInfo cacheDirectory;
        private FileStream fileStream;

        public CachedWebDiscoveryDevice() : this(null) {}

        /// <summary>
        /// Creates a new cached web discovery device with the default cache folder
        /// </summary>
        /// <param name="discoveryUri"></param>
        public CachedWebDiscoveryDevice(Uri discoveryUri) : this(discoveryUri, GetDefaultCacheDirectory())
        {
            // Set the default cache duration to 3 days
            CacheDuration = (uint) (new TimeSpan(3, 0, 0, 0).TotalSeconds);
        }

        /// <summary>
        /// Creates a new cached web discovery device
        /// </summary>
        /// <param name="discoveryUri"></param>
        /// <param name="cacheDirectory"></param>
        public CachedWebDiscoveryDevice(Uri discoveryUri, DirectoryInfo cacheDirectory)
        {
            DiscoveryUri = discoveryUri;
            CacheDirectory = cacheDirectory;
        }

        /// <summary>
        /// The URI from which the data is fetched
        /// </summary>
        public Uri DiscoveryUri { get; set; }

        /// <summary>
        /// Defines the cache duration in seconds
        /// </summary>
        public uint CacheDuration { get; set; }

        /// <summary>
        /// DirectoryInfo of the cache directory
        /// Must be a valid directory
        /// </summary>
        public DirectoryInfo CacheDirectory
        {
            get { return cacheDirectory; }
            set
            {
                value.ThrowIfNull("value");

                if (value.Exists == false)
                {
                    throw new ArgumentException("CachedDirectory", "Does not exist [" + value + "]");
                }

                cacheDirectory = value;
            }
        }

        #region IDiscoveryDevice Members

        /// <summary>
        /// Fetches the discovery document from either a local cache if it exsits otherwise using
        /// a WebDiscoveryDecivce 
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/>
        /// </returns>
        public Stream Fetch()
        {
            FileInfo cachedFile = GetCacheFile();
            bool fetchFile = false;

            // Check if we need to (re)download the document
            if (cachedFile.Exists == false)
            {
                logger.Debug("Document Not Found In Cache, fetching from web");
                fetchFile = true;
            }
            else if ((DateTime.UtcNow - cachedFile.LastWriteTimeUtc).TotalSeconds > CacheDuration)
            {
                logger.Debug("Document is outdated, refetching from web");
                fetchFile = true;
            }
            else
            {
                logger.Debug("Found Document In Cache");
            }

            // (re-)Fetch the document
            if (fetchFile)
            {
                try
                {
                    using (var device = new WebDiscoveryDevice(DiscoveryUri))
                    {
                        WriteToCache(device);
                    }
                }
                catch (WebException ex)
                {
                    // If we have a working cached file, we can still return it
                    if (cachedFile.Exists)
                    {
                        logger.Warning(
                            string.Format(
                                "Failed to refetch an outdated cache document [{0}]" +
                                " - Using cached document. Exception: {1}", DiscoveryUri, ex.Message), ex);

                        return cachedFile.OpenRead();
                    }

                    // Otherwise: Throw the exception
                    throw;
                }
            }

            fileStream = cachedFile.OpenRead();
            return fileStream;
        }

        public void Dispose()
        {
            if (fileStream != null)
            {
                fileStream.Dispose();
            }
        }

        #endregion

        private static DirectoryInfo GetDefaultCacheDirectory()
        {
            return new DirectoryInfo(Path.GetTempPath());
        }

        private string CreateFileName()
        {
            // Start with the URI as a file name
            string fileName = DiscoveryUri.ToString();

            // Add hash code for uniqueness, in case removing invalid chars cause collision
            fileName = fileName + "-" + fileName.GetHashCode();
            fileName += ".tmp";

            // Replace all invalid characters
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                fileName = fileName.Replace(c, '_');
            }

            return fileName;
        }

        /// <summary>
        /// Retrieves a file info of the cache file used for this device
        /// </summary>
        /// <returns></returns>
        public FileInfo GetCacheFile()
        {
            string path = Path.Combine(CacheDirectory.ToString(), CreateFileName());
            return new FileInfo(path);
        }

        private void WriteToCache(WebDiscoveryDevice device)
        {
            using (Stream webDocument = device.Fetch())
            {
                FileInfo fileInfo = GetCacheFile();
                using (FileStream cachedFileStream = fileInfo.OpenWrite())
                {
                    var buffer = new byte[BufferSize];
                    int read;
                    while ((read = webDocument.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        cachedFileStream.Write(buffer, 0, read);
                    }
                    cachedFileStream.Close();
                }
            }
        }
    }
}

#endif