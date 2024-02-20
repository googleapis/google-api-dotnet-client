/*
Copyright 2017 Google Inc

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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Google.Apis.Auth.SignedTokenVerification;

namespace Google.Apis.Auth
{
    /// <summary>
    /// Google JSON Web Signature as specified in https://developers.google.com/accounts/docs/OAuth2ServiceAccount.
    /// </summary>
    public class GoogleJsonWebSignature
    {
        internal const int MaxJwtLength = 10000;
        private const string SupportedJwtAlgorithm = "RS256";

        internal static readonly IEnumerable<string> ValidJwtIssuers = new[]
        {
            "https://accounts.google.com",
            "accounts.google.com"
        };

        /// <summary>
        /// Validates a Google-issued Json Web Token (JWT).
        /// Will throw a <see cref="InvalidJwtException"/> if the passed value is not valid JWT signed by Google.
        /// </summary>
        /// <remarks>
        /// <para>Follows the procedure to
        /// <see href="https://developers.google.com/identity/protocols/OpenIDConnect#validatinganidtoken">validate a JWT ID token</see>.
        /// </para>
        /// <para>Google certificates are cached, and refreshed once per hour. This can be overridden by setting
        /// <paramref name="forceGoogleCertRefresh"/> to true.</para>
        /// </remarks>
        /// <param name="jwt">The JWT to validate.</param>
        /// <param name="clock">Optional. The <see cref="IClock"/> to use for JWT expiration verification. Defaults to the system clock.</param>
        /// <param name="forceGoogleCertRefresh">Optional. If true forces new certificates to be downloaded from Google. Defaults to false.</param>
        /// <returns>The JWT payload, if the JWT is valid. Throws an <see cref="InvalidJwtException"/> otherwise.</returns>
        /// <exception cref="InvalidJwtException">Thrown when passed a JWT that is not a valid JWT signed by Google.</exception>
        public static Task<Payload> ValidateAsync(string jwt, IClock clock = null, bool forceGoogleCertRefresh = false) =>
            ValidateAsync(jwt, new ValidationSettings { Clock = clock, ForceGoogleCertRefresh = forceGoogleCertRefresh });

        /// <summary>
        /// Settings used when validating a JSON Web Signature.
        /// </summary>
        public sealed class ValidationSettings
        {
            /// <summary>
            /// Create a new instance.
            /// </summary>
            public ValidationSettings() { }

            private ValidationSettings(ValidationSettings other)
            {
                Audience = other.Audience?.ToArray();
                HostedDomain = other.HostedDomain;
                Clock = other.Clock;
                ForceGoogleCertRefresh = other.ForceGoogleCertRefresh;
                IssuedAtClockTolerance = other.IssuedAtClockTolerance;
                ExpirationTimeClockTolerance = other.ExpirationTimeClockTolerance;
                CertificateCache = other.CertificateCache;
            }

            /// <summary>
            /// The trusted audience client IDs; or <c>null</c> to suppress audience validation.
            /// </summary>
            public IEnumerable<string> Audience { get; set; }

            /// <summary>
            /// The required GSuite domain of the user; or <c>null</c> to suppress hosted domain validation.
            /// </summary>
            public string HostedDomain { get; set; }

            /// <summary>
            /// Optional. The <see cref="IClock"/> to use for JWT expiration verification. Defaults to the system clock.
            /// </summary>
            public IClock Clock { get; set; }

            /// <summary>
            /// Optional. If true forces new certificates to be downloaded from Google. Defaults to false.
            /// </summary>
            public bool ForceGoogleCertRefresh { get; set; }

            /// <summary>
            /// Clock tolerance for the issued-at check.
            /// Causes a JWT to pass validation up to this duration before it is really valid;
            /// this is to allow for possible local-client clock skew. Defaults to 30 seconds.
            /// </summary>
            public TimeSpan IssuedAtClockTolerance { get; set; } = TimeSpan.FromSeconds(30);

            /// <summary>
            /// Clock tolerance for the expiration check.
            /// Causes a JWT to pass validation up to this duration after it really expired;
            /// this is to allow for possible local-client clock skew. Defaults to zero seconds.
            /// </summary>
            public TimeSpan ExpirationTimeClockTolerance { get; set; } = TimeSpan.FromSeconds(0);

            /// <summary>
            /// CertificateCache for testing purposes.
            /// If null, the default CertificateCache
            /// <see cref="SignedTokenVerification.s_certificateCache"/> will
            /// be used.
            /// </summary>
            internal CertificateCacheBase CertificateCache { get; set; }

            internal ValidationSettings Clone() => new ValidationSettings(this);

            internal SignedTokenVerificationOptions ToVerificationOptions()
            {
                var options = new SignedTokenVerificationOptions
                {
                    // Google signed tokens must be signed with these certificates.
                    CertificatesUrl = GoogleAuthConsts.JsonWebKeySetUrl,
                    ForceCertificateRefresh = ForceGoogleCertRefresh,
                    IssuedAtClockTolerance = IssuedAtClockTolerance,
                    ExpiryClockTolerance = ExpirationTimeClockTolerance,
                    CertificateCache = CertificateCache,
                };
                options.Clock = Clock ?? options.Clock;

                foreach (string audience in Audience ?? Enumerable.Empty<string>())
                {
                    options.TrustedAudiences.Add(audience);
                }
                // These are the trusted issuers for Google signed tokens.
                foreach (string issuer in ValidJwtIssuers)
                {
                    options.TrustedIssuers.Add(issuer);
                }

                return options;
            }
        }

        /// <summary>
        /// Validates a Google-issued Json Web Token (JWT).
        /// Will throw a <see cref="InvalidJwtException"/> if the specified JWT fails any validation check.
        /// </summary>
        /// <remarks>
        /// <para>Follows the procedure to
        /// <see href="https://developers.google.com/identity/protocols/OpenIDConnect#validatinganidtoken">validate a JWT ID token</see>.
        /// </para>
        /// <para>
        /// Issued-at validation and expiry validation is performed using the clock on this local client,
        /// so local clock inaccuracies can lead to incorrect validation results.
        /// Use <see cref="ValidationSettings.IssuedAtClockTolerance"/> and <see cref="ValidationSettings.ExpirationTimeClockTolerance"/>
        /// to allow for local clock inaccuracy
        /// <c>IssuedAtClockTolerance</c> defaults to 30 seconds; it is very unlikely a JWT will be issued that isn't already valid.
        /// <c>ExpirationTimeClockTolerance</c> defaults to zero seconds; in some use-cases it may be useful to set this to a negative
        /// value to help ensure that passing local validation means it will pass server validation.
        /// Regardless of whether local validation passed, code must always correctly handle an invalid JWT error
        /// from the server.
        /// </para>
        /// <para>Google certificates are cached, and refreshed once per hour. This can be overridden by setting
        /// <see cref="ValidationSettings.ForceGoogleCertRefresh"/> to true.</para>
        /// </remarks>
        /// <param name="jwt">The JWT to validate.</param>
        /// <param name="validationSettings">Specifies how to carry out the validation.</param>
        /// <returns>The payload of the verified token.</returns>
        /// <exception cref="InvalidJwtException">If the token does not pass verification.</exception>
        public static Task<Payload> ValidateAsync(string jwt, ValidationSettings validationSettings) =>
            ValidateInternalAsync(jwt, validationSettings);

        // internal for testing
        internal static async Task<Payload> ValidateInternalAsync(string jwt, ValidationSettings validationSettings)
        {
            var settings = validationSettings.ThrowIfNull(nameof(validationSettings)).Clone();
            var verificationOptions = validationSettings.ToVerificationOptions();
            var signedToken = SignedToken<Header, Payload>.FromSignedToken(jwt);

            // Start general validation task ...
            var generalValidationTask = SignedTokenVerification.VerifySignedTokenAsync(signedToken, verificationOptions, default);

            // ... and do Google specific validation in the meantime.

            // Google signed tokens must not exceed this length.
            // It's not clear if there's an absolute size limit for all possible tokens,
            // that's why this check is only here and not on SignedTokenVerification.
            if (jwt.Length > MaxJwtLength)
            {
                throw new InvalidJwtException($"JWT exceeds maximum allowed length of {MaxJwtLength}");
            }
            // Google signed tokens are signed with RS256.
            if (signedToken.Header.Algorithm != SupportedJwtAlgorithm)
            {
                throw new InvalidJwtException($"JWT algorithm must be '{SupportedJwtAlgorithm}'");
            }
            // Google signed tokens can contain a G Suite hosted domain claim.
            if (settings.HostedDomain != null && signedToken.Payload.HostedDomain != settings.HostedDomain)
            {
                throw new InvalidJwtException("JWT contains invalid 'hd' claim.");
            }

            // ... finally wait for the general verifications to be done.
            await generalValidationTask.ConfigureAwait(false);

            // All verification passed, return payload.
            return signedToken.Payload;
        }

        /// <summary>
        /// The header as specified in https://developers.google.com/accounts/docs/OAuth2ServiceAccount#formingheader.
        /// </summary>
        public class Header : JsonWebSignature.Header
        {
        }

        /// <summary>
        /// The payload as specified in 
        /// https://developers.google.com/accounts/docs/OAuth2ServiceAccount#formingclaimset,
        /// https://developers.google.com/identity/protocols/OpenIDConnect, and
        /// https://openid.net/specs/openid-connect-core-1_0.html#StandardClaims
        /// </summary>
        public class Payload : JsonWebSignature.Payload
        {
            /// <summary>
            /// A space-delimited list of the permissions the application requests or <c>null</c>.
            /// </summary>
            [Newtonsoft.Json.JsonProperty("scope")]
            public string Scope { get; set; }

            /// <summary>
            /// The email address of the user for which the application is requesting delegated access.
            /// </summary>
            [Newtonsoft.Json.JsonProperty("prn")]
            public string Prn { get; set; }

            /// <summary>
            /// The hosted GSuite domain of the user. Provided only if the user belongs to a hosted domain.
            /// </summary>
            [Newtonsoft.Json.JsonProperty("hd")]
            public string HostedDomain { get; set; }

            /// <summary>
            /// The user's email address. This may not be unique and is not suitable for use as a primary key.
            /// Provided only if your scope included the string "email".
            /// </summary>
            [Newtonsoft.Json.JsonProperty("email")]
            public string Email { get; set; }

            /// <summary>
            /// True if the user's e-mail address has been verified; otherwise false.
            /// </summary>
            [Newtonsoft.Json.JsonProperty("email_verified")]
            public bool EmailVerified { get; set; }

            /// <summary>
            /// The user's full name, in a displayable form. Might be provided when:
            /// (1) The request scope included the string "profile"; or
            /// (2) The ID token is returned from a token refresh.
            /// When name claims are present, you can use them to update your app's user records.
            /// Note that this claim is never guaranteed to be present.
            /// </summary>
            [Newtonsoft.Json.JsonProperty("name")]
            public string Name { get; set; }

            /// <summary>
            /// Given name(s) or first name(s) of the End-User. Note that in some cultures, people can have multiple given names;
            /// all can be present, with the names being separated by space characters.
            /// </summary>
            [Newtonsoft.Json.JsonProperty("given_name")]
            public string GivenName { get; set; }

            /// <summary>
            /// Surname(s) or last name(s) of the End-User. Note that in some cultures,
            /// people can have multiple family names or no family name;
            /// all can be present, with the names being separated by space characters.
            /// </summary>
            [Newtonsoft.Json.JsonProperty("family_name")]
            public string FamilyName { get; set; }

            /// <summary>
            /// The URL of the user's profile picture. Might be provided when:
            /// (1) The request scope included the string "profile"; or
            /// (2) The ID token is returned from a token refresh.
            /// When picture claims are present, you can use them to update your app's user records.
            /// Note that this claim is never guaranteed to be present.
            /// </summary>
            [Newtonsoft.Json.JsonProperty("picture")]
            public string Picture { get; set; }

            /// <summary>
            /// End-User's locale, represented as a BCP47 [RFC5646] language tag.
            /// This is typically an ISO 639-1 Alpha-2 [ISO639‑1] language code in lowercase and an
            /// ISO 3166-1 Alpha-2 [ISO3166‑1] country code in uppercase, separated by a dash.
            /// For example, en-US or fr-CA.
            /// </summary>
            [Newtonsoft.Json.JsonProperty("locale")]
            public string Locale { get; set; }
        }
    }
}
