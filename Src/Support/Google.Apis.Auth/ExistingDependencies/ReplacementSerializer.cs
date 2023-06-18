using Google.Apis.Auth.OAuth2;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.ExistingDependencies;

// The replacement for NewtonsoftJsonSerializer
internal class ReplacementSerializer
{
    internal static string Serialize<T>(T value) => default;

    internal static T Deserialize<T>(string json) => default;

    public static Task<T> DeserializeAsync<T>(Stream stream, CancellationToken cancellationToken) => default;

    public static T Deserialize<T>(Stream stream) => default;
}
