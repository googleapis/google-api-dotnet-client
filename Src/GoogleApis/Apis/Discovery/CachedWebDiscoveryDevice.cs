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

using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Google.Apis.Discovery {
	/// <summary>
	/// WebDiscoveryDevice allows clients to fetch discovery documents from a web based service.
	/// TODO(davidwaters): Add expirey time based on modified time in the filesystem
	/// </summary>
	public class CachedWebDiscoveryDevice : IDiscoveryDevice 
	{
		private const int BufferSize = 1024 * 1024; // 1MB
		private static readonly Regex InvalidFileChars = new Regex("[^A-Za-z0-9_-]", RegexOptions.Compiled);
		private static log4net.ILog logger = log4net.LogManager.GetLogger(typeof(CachedWebDiscoveryDevice));
		
		private FileStream fileStream; 
		private DirectoryInfo cacheDirectory;
			
		public Uri DiscoveryUri { get; set; }
		public DirectoryInfo CacheDirectory 
		{
			get{return cacheDirectory;}
			set
			{
				if(value == null){
					throw new ArgumentNullException("CachedDirectory", "Must not be null");
				}
				if(value.Exists == false){
					throw new ArgumentException("CachedDirectory", "Does not exsit ["+value.ToString()+"]");
				}
				
				this.cacheDirectory = value;
			}
		}
		
		public CachedWebDiscoveryDevice() :this(null)
		{
		}

		public CachedWebDiscoveryDevice(Uri discoveryUri):this(discoveryUri, GetDefaultCacheDirectory()) 
		{
		}

		public CachedWebDiscoveryDevice(Uri discoveryUri, DirectoryInfo cacheDirectory) 
		{
			this.DiscoveryUri = discoveryUri;
			this.CacheDirectory = cacheDirectory;
		}
		
		private static DirectoryInfo GetDefaultCacheDirectory()
		{
			return new DirectoryInfo(Path.GetTempPath());
		}
		
		private string CreateFileName() 
		{
			// Start with uri
			string fileName = DiscoveryUri.ToString();
			// add hash code for unqiueness, in case removing invalid chars cause collision
			fileName = fileName + "-" + fileName.GetHashCode().ToString();
			// replace all but known safe chars
			fileName = InvalidFileChars.Replace(fileName, "_");			
			return fileName;
		}

		private FileInfo GetCacheFile() 
		{
			string path = Path.Combine(CacheDirectory.ToString(), CreateFileName());
			return new FileInfo(path);
		}

		private void WriteToCache(WebDiscoveryDevice device) 
		{
			using(Stream webDocument = device.Fetch()){
				FileInfo fileInfo = GetCacheFile();
				using(FileStream cachedFileStream = fileInfo.OpenWrite()){
					byte[] buffer = new byte[BufferSize];
					int read;
					while((read = webDocument.Read(buffer,0,buffer.Length)) > 0){
						cachedFileStream.Write(buffer, 0, read);	
					}
					cachedFileStream.Close();
				}
			}
		}

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
			if (cachedFile.Exists == false) {
				logger.Debug("Document Not Found In Cache, fetching from web");
				using(WebDiscoveryDevice device = new WebDiscoveryDevice(this.DiscoveryUri)){
					WriteToCache(device);
				}
			} else {
				logger.Debug("Found Document In Cache");
			}
			fileStream = cachedFile.OpenRead();
			return fileStream;
		}

		public void Dispose() 
		{
			if (fileStream != null) {
				fileStream.Dispose();
			}
		}
		
	}
	
	
}

