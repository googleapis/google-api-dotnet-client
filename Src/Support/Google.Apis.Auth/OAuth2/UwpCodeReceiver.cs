#if UAP10_0

using System;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Windows.Security.Authentication.Web;
using System.Net.Http;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// OAuth 2.0 verification code receiver for UWP.
    /// </summary>
    public class UwpCodeReceiver : ICodeReceiver
    {
        /// <summary>
        /// Exeception thrown on authention problems.
        /// </summary>
        public sealed class AuthenticateException : Exception
        {
            /// <summary>
            /// Instantiate an <see cref="AuthenticateException"/>.
            /// </summary>
            /// <param name="msg"></param>
            public AuthenticateException(string msg) : base(msg) { }
        }

        /// <inheritdoc />
        public string RedirectUri => GoogleAuthConsts.InstalledAppRedirectUri;

        /// <inheritdoc />
        public async Task<AuthorizationCodeResponseUrl> ReceiveCodeAsync(AuthorizationCodeRequestUrl url, CancellationToken taskCancellationToken)
        {
            if (taskCancellationToken.CanBeCanceled)
            {
                throw new NotSupportedException("Cancellation is not supported in UwpCodeReceiver.ReceiveCodeAsync()");
            }
            var endUri = new Uri(GoogleAuthConsts.ApprovalUrl);
            var result = await WebAuthenticationBroker.AuthenticateAsync(WebAuthenticationOptions.UseTitle, url.Build(), endUri);
            switch (result.ResponseStatus)
            {
                case WebAuthenticationStatus.Success:
                    var response = result.ResponseData.ToLowerInvariant().StartsWith("success ") ? result.ResponseData.Substring(8) : result.ResponseData;
                    return new AuthorizationCodeResponseUrl(response);
                case WebAuthenticationStatus.ErrorHttp:
                    throw new AuthenticateException($"WebAuthenticationBroker.AuthenticateAsync() returned HTTP error: {result.ResponseErrorDetail}");
                default:
                    throw new AuthenticateException($"WebAuthenticationBroker.AuthenticateAsync() error: {result.ResponseStatus}");
            }
        }
    }
}

#endif
