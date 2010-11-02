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
using System.Xml;
using System.Xml.Linq;

using System.IO;

namespace GoogleApis.Extensions
{
	public static class Extensions
	{
		
		/// <summary>
		/// Creates an XML Document from a given stream.
		/// 
		/// Performs no validataion.
		/// </summary>
		/// <param name="dataStream">
		/// A <see cref="Stream"/>
		/// </param>
		/// <returns>
		/// A <see cref="XmlDocument"/>
		/// </returns>
		public static XmlDocument ToXmlDocument(this Stream dataStream)
		{
			var document = new XmlDocument();
			document.Load(dataStream);
			return document;
		}
		
		
		/// <summary>
		/// Quickly converts a data stream in to an XDocument.
		/// 
		/// Performs no validation.
		/// </summary>
		/// <param name="dataStream">
		/// A <see cref="Stream"/>
		/// </param>
		/// <returns>
		/// A <see cref="XDocument"/>
		/// </returns>
		public static XDocument ToXDocument(this Stream dataStream) {
			return XDocument.Load(dataStream);
		}
	}
}

