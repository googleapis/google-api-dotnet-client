using Google.Apis.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Google.Apis.Auth.ExistingDependencies;

/// <summary>
/// TODO: Document this.
/// </summary>
public interface ICredentialedRequest
{
    /// <summary>
    /// Credential to use for this request.
    /// </summary>
    public IHttpExecuteInterceptor Credential { get; set; }
}
