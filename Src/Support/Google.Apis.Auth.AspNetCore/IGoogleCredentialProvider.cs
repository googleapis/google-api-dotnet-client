using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.AspNetCore
{
    public interface IGoogleCredentialProvider
    {
        Task<GoogleCredential> GetAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
