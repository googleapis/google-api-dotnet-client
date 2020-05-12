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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Util;
using System;
using System.Threading.Tasks;
using static Google.Apis.Auth.SignedTokenVerification;

namespace Google.Apis.Auth.Tests
{
    internal sealed class FakeCertificateCache : CertificateCacheBase
    {
        // From https://www.googleapis.com/oauth2/v3/certs
        internal const string GoogleCertsJson = @"
{
 ""keys"": [
  {
   ""kty"": ""RSA"",
   ""alg"": ""RS256"",
   ""use"": ""sig"",
   ""kid"": ""3c066add5889b989e9c49803c21fa4b29d1f4ead"",
   ""n"": ""h3oJdAYVp3eUXPb2SGvCvEgm_KiRfFrL3cMEdT3I-uKBptz5LklVrOflDJurCXjIQF-891MF6JSJjYc9csiJbUNb-jFXkEI9toOa0ynF-Q9KHrUknfn-R2UrhqWMZw0Xe2WTWS12tjEGEa3Kzf7mcrHV_ARW9vv75PhOMa0dPjgerNJyfDrdTMxOjEzOALHJwjXwzsZxxBiox6ZIXKSGGgC99OOiKZvg6erHP7lEADm0Ws9H7lue3dkv50rpaJBPIUJlYKrx82MnxMAy2NAGqrghjQ5nRdB1mBn4F260lEOwcYNu8aGZ7NhD7yjS_xkECamTYwLGe-9PH8bR54aSxQ"",
   ""e"": ""AQAB""
  },
  {
   ""kty"": ""RSA"",
   ""alg"": ""RS256"",
   ""use"": ""sig"",
   ""kid"": ""c9b39c24ed54a2b1aef3e572d4e411fe5ccf697f"",
   ""n"": ""zQM50VGJeWRq_hLYKM8dZSVWNTVygDoACA7au37sA7tkNoYhGUopS9veabFpt5MB_h-zEAGhnNpjxRvqVvrvHi5KpfzSPUJxMR9K-YQlqObpb31eebxCiAa2ssewCWslZ2BZ2ID839_YBtbaSZymq5aBgjf07PuWUy55piuaTOuDCJOCPGXvBhMTTFcBNC3zDOZXpkbbG6h6mk5LTPyXzJ322cPjotCZXNF3FsWbFDcCtacr8ZSEMcCGFmrawmko7BQ62FDQtOVGNK94xaTTwtjnxZn1sFIeABIoo8N-x4zbSaZVX9PVQUjtVsX4V5hHiZqmIhcR62h8vj9tVDwxqQ"",
   ""e"": ""AQAB""
  },
  {
   ""kty"": ""RSA"",
   ""alg"": ""RS256"",
   ""use"": ""sig"",
   ""kid"": ""f9079a9ea417bb3c4f5be2805fd9d0aa774609d0"",
   ""n"": ""lYnlj0CJBnwz_7h5MPUCWpdwXfIxo09_ny2nVEhtZHnaIkpyrtVaUtofs62F8rJAgKN21NrGouIEbiV2i0upO9jffYhSKieZKleM8unuyret3o7Vp3Tme68GEh3ZuSqhyKsia28o5zYy3NzT9Ptt5nZjIk0uTShelHsEV_cGJRUBNmcjJxnKkrSXOABd_CW34GuAZewhfgFWibhulbb6zpNogKB6uv2IIIYF8KaIKyvIwttgyDBSTvgxFxrxWZonTTaB0Ktru2KAyvzoAzZdfnMndHcax6p5D3FnrhNtg4WBxsi8lRO6mz2KrvVYu4wMTD0e4gSPFAhqT8Z-fa7Hcw"",
   ""e"": ""AQAB""
  },
  {
   ""kty"": ""RSA"",
   ""alg"": ""RS256"",
   ""use"": ""sig"",
   ""kid"": ""bbd2c788a9aaa01b7b8ba763f8fae7f88ef57002"",
   ""n"": ""4f6HXWnlVHL58_VeBC4SjmWNelqVpmpGGIeYKKuee-rV1Y-tQXRHSXT-gDHovz6ZslE6f73CCrYvJ-7223o6ZLa1VTB_5sS5rtcqYK2I7VN7H1gvRAw6rWcwruVjQXzruArnjL00ousC8pKXqoXYtlTyYY0T7J_W2nn_imwk7fCRwe48CCMKi6iDJxaJzEc0Gu5tNPzQoFHez-1ohF8DRxFN6IVV6TEVUMpn9OG-BP7aWfSi5WxnND1IcVnLuLDatqltDzRHzZNYnRkLIVlDzz2pEledY281kE5eQZ0vLjGJ2OR-cEd9SBjbh9EMvig3k7-Co6EAuzpIDXBeJDJ21w"",
   ""e"": ""AQAB""
  }
 ]
}";
        // From https://www.gstatic.com/iap/verify/public_key-jwk
        internal const string Es256IapCertificates = @"{
   ""keys"" : [
      {
         ""alg"" : ""ES256"",
         ""crv"" : ""P-256"",
         ""kid"" : ""LYyP2g"",
         ""kty"" : ""EC"",
         ""use"" : ""sig"",
         ""x"" : ""SlXFFkJ3JxMsXyXNrqzE3ozl_0913PmNbccLLWfeQFU"",
         ""y"" : ""GLSahrZfBErmMUcHP0MGaeVnJdBwquhrhQ8eP05NfCI""
      },
      {
         ""alg"" : ""ES256"",
         ""crv"" : ""P-256"",
         ""kid"" : ""mpf0DA"",
         ""kty"" : ""EC"",
         ""use"" : ""sig"",
         ""x"" : ""fHEdeT3a6KaC1kbwov73ZwB_SiUHEyKQwUUtMCEn0aI"",
         ""y"" : ""QWOjwPhInNuPlqjxLQyhveXpWqOFcQPhZ3t-koMNbZI""
      },
      {
         ""alg"" : ""ES256"",
         ""crv"" : ""P-256"",
         ""kid"" : ""b9vTLA"",
         ""kty"" : ""EC"",
         ""use"" : ""sig"",
         ""x"" : ""qCByTAvci-jRAD7uQSEhTdOs8iA714IbcY2L--YzynI"",
         ""y"" : ""WQY0uCoQyPSozWKGQ0anmFeOH5JNXiZa9i6SNqOcm7w""
      },
      {
         ""alg"" : ""ES256"",
         ""crv"" : ""P-256"",
         ""kid"" : ""0oeLcQ"",
         ""kty"" : ""EC"",
         ""use"" : ""sig"",
         ""x"" : ""MdhRXGEoGJLtBjQEIjnYLPkeci9rXnca2TffkI0Kac0"",
         ""y"" : ""9BoREHfX7g5OK8ELpA_4RcOnFCGSjfR4SGZpBo7juEY""
      },
      {
         ""alg"" : ""ES256"",
         ""crv"" : ""P-256"",
         ""kid"" : ""g5X6ig"",
         ""kty"" : ""EC"",
         ""use"" : ""sig"",
         ""x"" : ""115LSuaFVzVROJiGfdPN1kT14Hv3P4RIjthfslZ010s"",
         ""y"" : ""-FAaRtO4yvrN4uJ89xwGWOEJcSwpLmFOtb0SDJxEAuc""
      }
   ]
}";

        // From procedure outlined in https://developers.google.com/identity/protocols/OpenIDConnect
        // This JWT is valid only from 2017-05-31 10:23 until 2017-05-31 11:23 (UTC), so is not usable.
        internal const string JwtGoogleSigned =
            "eyJhbGciOiJSUzI1NiIsImtpZCI6ImJiZDJjNzg4YTlhYWEwMWI3YjhiYTc2M2Y4ZmFlN2Y4OGVmNTcwMDIifQ.eyJhenAiOiIy" +
            "MzM3NzIyODE0MjUtYWIybWNiaXFtdjhraDBtZG5xc3Jrcm9kOTdxazM3aDAuYXBwcy5nb29nbGV1c2VyY29udGVudC5jb20iLCJ" +
            "hdWQiOiIyMzM3NzIyODE0MjUtYWIybWNiaXFtdjhraDBtZG5xc3Jrcm9kOTdxazM3aDAuYXBwcy5nb29nbGV1c2VyY29udGVudC" +
            "5jb20iLCJzdWIiOiIxMDkwODEwMjMzMDk1NTcxOTcyMTIiLCJoZCI6Imdvb2dsZS5jb20iLCJlbWFpbCI6ImNocmlzYmFjb25AZ" +
            "29vZ2xlLmNvbSIsImVtYWlsX3ZlcmlmaWVkIjp0cnVlLCJhdF9oYXNoIjoiNFJHRTFzVko4WXhqRUtUaGhFZDZpdyIsImlzcyI6" +
            "Imh0dHBzOi8vYWNjb3VudHMuZ29vZ2xlLmNvbSIsImlhdCI6MTQ5NjIyNjIzMCwiZXhwIjoxNDk2MjI5ODMwfQ.Opw9C1ma5eww" +
            "HmLrmT6to41U0Tpt0fN2A3Vw9jqgS72iRFq0SDQ4r182uwIvhSUo5MnifY4JheeHBuRtDpiQYFtnh_JLzxiAkkIGCMkMf_7Pr6Q" +
            "MWuNsx1ugSFygppvlC_fSEK3LS5P2nUtRFqtR7kR9T1MJN11G5dGjLZnmerot8jdqUo7w_zxaiG-5KK-5z3xGRtcPGvl-04RUU7" +
            "qsktkVV3AgLuC_TYQGuVH59sfInCEuMZzJJ219MA1c03F0tbDXCMPSWwXgNj4OXaV7QdP7X6sE0AVBK9WVByApI-4CTL7U4G40z" +
            "yXSOZ4DQWYiYkNf7Hqw9foa87U0sZS6eQ";
        internal static readonly DateTime ValidJwtGoogleSigned = new DateTime(2017, 5, 31, 10, 24, 0, DateTimeKind.Utc);
        internal static readonly DateTime BeforeValidJwtGoogleSigned = new DateTime(2017, 5, 31, 10, 22, 0, DateTimeKind.Utc);
        internal static readonly DateTime AfterValidJwtGoogleSigned = new DateTime(2017, 5, 31, 11, 24, 0, DateTimeKind.Utc);

        // A valid JWT, with a valid signature, but not signed by Google.
        // This JWT is valid only from 2017-05-29 19:02 until 2017-05-29 20:02 (UTC), so is not usable.
        internal const string JwtNonGoogleSigned =
            "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJmb3J0ZXN0aW5nQGNocmlzYmFjb24tdGVzdGluZy5pYW0uZ3Nlcn" +
            "ZpY2VhY2NvdW50LmNvbSIsInN1YiI6ImZvcnRlc3RpbmdAY2hyaXNiYWNvbi10ZXN0aW5nLmlhbS5nc2VydmljZWFjY291bnQuY" +
            "29tIiwiYXVkIjoiaHR0cHM6Ly93d3cuZXhhbXBsZS5jb20vIiwiZXhwIjoxNDk2MDg4MTYwLCJpYXQiOjE0OTYwODQ1NjB9.UE0" +
            "oO1QC90rQSmjrWouxUcLV-jay9lnzDraPFbqpcoLcZRyXzG7vUSUVqoipzHweyRyR9bazn_bWCuLuTm9sD-UmokDQGBxqpkGwHJ" +
            "vjZ9R6B25vlB5Dqk5QJsPz8Cy_N1wsmeFi41Mn0UsVH1OoQmZHmFgwq61QP1nfzVLlz92sRcEgArJEEM3jwxfFEZVJVckeTqpvA" +
            "IMAj-lTi0ysjiKnd7OJwG_HnNqF-nWTU7z0JbZm_l6_Zfyp_wra78YIbDY-VmxBjiz32RDugLqilfhH4o--GThjhdlyHZENMtk-" +
            "pO3CE8RfNI5fGnmfUgtf6tcdhk2MiA1Quy8BgB_F5Q";
        internal static readonly DateTime ValidJwtNonGoogleSigned = new DateTime(2017, 5, 29, 19, 3, 20, DateTimeKind.Utc);
        internal static readonly DateTime BeforeValidJwtNonGoogleSigned = new DateTime(2017, 5, 29, 19, 1, 20, DateTimeKind.Utc);
        internal static readonly DateTime AfterValidJwtNonGoogleSigned = new DateTime(2017, 5, 29, 20, 3, 20, DateTimeKind.Utc);

        // A valid Es256 JWT.
        // Valind on March 12, 2020 9:03:37 PM UTC and for 10 minutes.
        internal const string Es256ForIap =
            "eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCIsImtpZCI6Im1wZjBEQSJ9.eyJhdWQiOiIvcHJvamVjdHMvNjUyNTYyNzc2Nzk4L2" +
            "FwcHMvY2xvdWQtc2FtcGxlcy10ZXN0cy1waHAtaWFwIiwiZW1haWwiOiJjaGluZ29yQGdvb2dsZS5jb20iLCJleHAiOjE1ODQwN" +
            "Dc2MTcsImdvb2dsZSI6eyJhY2Nlc3NfbGV2ZWxzIjpbImFjY2Vzc1BvbGljaWVzLzUxODU1MTI4MDkyNC9hY2Nlc3NMZXZlbHMv" +
            "cmVjZW50U2VjdXJlQ29ubmVjdERhdGEiLCJhY2Nlc3NQb2xpY2llcy81MTg1NTEyODA5MjQvYWNjZXNzTGV2ZWxzL3Rlc3ROb09" +
            "wIiwiYWNjZXNzUG9saWNpZXMvNTE4NTUxMjgwOTI0L2FjY2Vzc0xldmVscy9ldmFwb3JhdGlvblFhRGF0YUZ1bGx5VHJ1c3RlZC" +
            "JdfSwiaGQiOiJnb29nbGUuY29tIiwiaWF0IjoxNTg0MDQ3MDE3LCJpc3MiOiJodHRwczovL2Nsb3VkLmdvb2dsZS5jb20vaWFwI" +
            "iwic3ViIjoiYWNjb3VudHMuZ29vZ2xlLmNvbToxMTIxODE3MTI3NzEyMDE5NzI4OTEifQ.yKNtdFY5EKkRboYNexBdfugzLhC3V" +
            "uGyFcuFYA8kgpxMqfyxa41zkML68hYKrWu2kOBTUW95UnbGpsIi_u1fiA";
        internal static readonly DateTime ValidEs256ForIap = new DateTime(2020, 3, 12, 21, 4, 20, DateTimeKind.Utc);
        internal static readonly DateTime BeforeValidEs256ForIap = new DateTime(2020, 3, 12, 21, 2, 20, DateTimeKind.Utc);
        internal static readonly DateTime AfterValidEs256ForIap = new DateTime(2020, 3, 12, 21, 14, 20, DateTimeKind.Utc);

        public FakeCertificateCache(IClock clock = null)
            : base(clock)
        { }

        protected async override Task<string> FetchCertificatesAsync(string certificatesLocation)
        {
            await Task.Delay(100);
            return certificatesLocation switch
            {
                GoogleAuthConsts.JsonWebKeySetUrl => GoogleCertsJson,
                GoogleAuthConsts.IapKeySetUrl => Es256IapCertificates,
                _ => throw new ArgumentOutOfRangeException(nameof(certificatesLocation))
            };
        }
    }
}
