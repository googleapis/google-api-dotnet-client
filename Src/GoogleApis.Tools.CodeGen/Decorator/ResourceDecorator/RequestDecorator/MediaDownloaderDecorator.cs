/*
Copyright 2013 Google Inc

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
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Discovery;
using Google.Apis.Download;

namespace Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator.RequestDecorator
{
    /// <summary>
    /// Media Downloader decorator which adds the following members in case the method supports media download:
    /// <list type="bullet">
    /// <item><description>MediaDownloader getter property</description></item> 
    /// <item><description>Download method which gets a stream</description></item>
    /// <item><description>DownloadAsync method which gets a stream</description></item>
    /// <item><description>DownloadAsync method which gets a stream and a cancellation token</description></item>
    /// </list> 
    /// </summary>
    public class MediaDownloaderDecorator : IRequestDecorator
    {
        public void DecorateClass(IResource resource, IMethod request, CodeTypeDeclaration requestClass,
            CodeTypeDeclaration resourceClass)
        {
            if (!request.SupportMediaDownload)
                return;

            GenerateMediaDownloaderProperty(requestClass);
            GenerateDownload(requestClass);
            GenerateDownloadAsync(requestClass, false);
            GenerateDownloadAsync(requestClass, true);
        }

        /// <summary>Generates an <seealso cref="Google.Apis.Download.IMediaDownloader"/> property.</summary>
        private static void GenerateMediaDownloaderProperty(CodeTypeDeclaration requestClass)
        {
            // Generates:
            // private IMediaDownloader _mediaDownloader;
            // public IMediaDownloader MediaDownloader { get { return _mediaDownloader; } }

            foreach (CodeTypeMember memeber in DecoratorUtil.CreateAutoProperty("mediaDownloader", null,
                new CodeTypeReference(typeof(IMediaDownloader)), new List<string>(), true))
            {
                requestClass.Members.Add(memeber);
            }
        }

        /// <summary>Generates a <c>Download</c> method which gets a stream.</summary>
        private static void GenerateDownload(CodeTypeDeclaration requestClass)
        {
            // Generates: 
            // private void Download(Stream stream)
            // {
            //    _mediaDownloader.Download(GenerateRequestUri(), stream);
            // }

            var methodName = "Download";
            var comment = "Synchronously download the media into the given stream.";
            var method = new CodeMemberMethod();

            method.Name = methodName;
            method.Comments.Add(new CodeCommentStatement("<summary>" + comment + "</summary>", true));
            method.ReturnType = new CodeTypeReference(typeof(void));
            method.Attributes = MemberAttributes.Public;
            method.Parameters.Add(new CodeParameterDeclarationExpression(typeof(Stream), "stream"));

            method.Statements.Add(
                new CodeMethodInvokeExpression(new CodeVariableReferenceExpression("_mediaDownloader"),
                    methodName, new CodeMethodInvokeExpression(
                        new CodeMethodReferenceExpression(new CodeThisReferenceExpression(), "GenerateRequestUri")),
                        new CodeVariableReferenceExpression("stream")));

            requestClass.Members.Add(method);
        }

        /// <summary>
        /// Generates a <c>DownloadAsync</c> method which gets the stream and if the given <c>useCancellationToken</c> 
        /// parameter is <c>true</c> a cancellation token as well.
        /// </summary>
        private static void GenerateDownloadAsync(CodeTypeDeclaration requestClass, bool useCancellationToken)
        {
            // Generates: 
            // If useCancelltionToken
            // private Task<IDownloadProgress> DownloadAsync(Stream stream, CancellationToken cancelleationToken)
            // {
            //    return _mediaDownloader.DownloadAsync(GenerateRequestUri(), stream, cancellationToken);
            // }

            // else
            // private Task<IDownloadProgress> DownloadAsync(Stream stream)
            // {
            //    return _mediaDownloader.DownloadAsync(GenerateRequestUri(), stream);
            // }

            var methodName = "DownloadAsync";
            var comment = "Asynchronously download the media into the given stream.";

            var method = new CodeMemberMethod();

            method.Name = methodName;
            method.Comments.Add(new CodeCommentStatement("<summary>" + comment + "</summary>", true));
            method.ReturnType = new CodeTypeReference(typeof(Task<IDownloadProgress>));
            method.Attributes = MemberAttributes.Public;
            method.Parameters.Add(new CodeParameterDeclarationExpression(typeof(Stream), "stream"));
            if (useCancellationToken)
            {
                method.Parameters.Add(new CodeParameterDeclarationExpression(typeof(CancellationToken),
                    "cancellationToken"));
            }

            IList<CodeExpression> parameters = new List<CodeExpression>();
            parameters.Add(new CodeMethodInvokeExpression(
                new CodeMethodReferenceExpression(new CodeThisReferenceExpression(), "GenerateRequestUri")));
            parameters.Add(new CodeVariableReferenceExpression("stream"));
            if (useCancellationToken)
            {
                parameters.Add(new CodeVariableReferenceExpression("cancellationToken"));
            }

            method.Statements.Add(
                new CodeMethodReturnStatement(
                new CodeMethodInvokeExpression(new CodeVariableReferenceExpression("_mediaDownloader"),
                    "DownloadAsync", parameters.ToArray())));

            requestClass.Members.Add(method);
        }
    }
}
