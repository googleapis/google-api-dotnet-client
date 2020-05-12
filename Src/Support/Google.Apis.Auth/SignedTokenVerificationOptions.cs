/*
Copyright 2020 Google Inc

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

using Google.Apis.Util;
using System;
using System.Collections.Generic;
using static Google.Apis.Auth.SignedTokenVerification;

namespace Google.Apis.Auth
{
    /// <summary>
    /// Options to use when verifying signed JWTs.
    /// </summary>
    public sealed class SignedTokenVerificationOptions
    {

        /// <summary>
        /// Creates a new instance of <see cref="SignedTokenVerificationOptions"/>
        /// with default values for all options (or null for those whose default is unset).
        /// </summary>
        public SignedTokenVerificationOptions() { }

        /// <summary>
        /// Creates a new instance of <see cref="SignedTokenVerificationOptions"/>
        /// by copying over all the values from <paramref name="other"/>.
        /// </summary>
        /// <param name="other">The option set to build this instance from.</param>
        public SignedTokenVerificationOptions(SignedTokenVerificationOptions other)
        {
            other.ThrowIfNull(nameof(other));
            foreach (var audience in other.TrustedAudiences)
            {
                TrustedAudiences.Add(audience);
            }
            foreach (var issuer in other.TrustedIssuers)
            {
                TrustedIssuers.Add(issuer);
            }
            CertificatesUrl = other.CertificatesUrl;
            ForceCertificateRefresh = other.ForceCertificateRefresh;
            IssuedAtClockTolerance = other.IssuedAtClockTolerance;
            ExpiryClockTolerance = other.ExpiryClockTolerance;
            CertificateCache = other.CertificateCache;
            Clock = other.Clock;
        }

        /// <summary>
        /// Trusted audiences for the token.
        /// All the audiences the token is intended for should be in the
        /// trusted audiences list.
        /// If the list is empty, the token audience won't be verified.
        /// </summary>
        public IList<string> TrustedAudiences { get; } = new List<string>();

        /// <summary>
        /// The URL from where to obtain certificates from.
        /// May be null, in which case, default certificate locations will be used:
        /// <list type="bullet">
        /// <item>For RS256 signed certificates, https://www.googleapis.com/oauth2/v3/certs will be used.</item>
        /// <item>For ES256 signed certificates, https://www.gstatic.com/iap/verify/public_key-jwk will be used.</item>
        /// </list>
        /// </summary>
        public string CertificatesUrl { get; set; }

        /// <summary>
        /// List of trusted issuers to verify the token issuer against.
        /// The token issuer must be contained in this list.
        /// May be null, in which case the token issuer won't be verified.
        /// </summary>
        public IList<string> TrustedIssuers { get; } = new List<string>();

        /// <summary>
        /// Forces certificate refresh.
        /// Internal to be used only for backward compatibility.
        /// </summary>
        internal bool ForceCertificateRefresh { get; set; }

        /// <summary>
        /// Clock tolerance for the issued-at check.
        /// Causes a JWT to pass validation up to this duration before it is really valid;
        /// this is to allow for possible local-client clock skew.
        /// Defaults to zero.
        /// Internal to be used only for backward compatibility.
        /// </summary>
        public TimeSpan IssuedAtClockTolerance { get; set; } = TimeSpan.Zero;

        /// <summary>
        /// Clock tolerance for the expiration check.
        /// Causes a JWT to pass validation up to this duration after it really expired;
        /// this is to allow for possible local-client clock skew.
        /// Defaults to zero.
        /// Internal to be used only for backward compatibility.
        /// </summary>
        public TimeSpan ExpiryClockTolerance { get; set; } = TimeSpan.Zero;

        private IClock _clock = SystemClock.Default;
        /// <summary>
        /// Clock for testing purposes. Defaults to <see cref="SystemClock.Default"/>.
        /// Must not be null.
        /// </summary>
        internal IClock Clock
        {
            get => _clock;
            set => _clock = value ?? throw new ArgumentNullException(nameof(Clock));
        }

        /// <summary>
        /// CertificateCache for testing purposes.
        /// If null, the true CertificateCache will be used.
        /// </summary>
        internal CertificateCacheBase CertificateCache { get; set; }
    }
}
