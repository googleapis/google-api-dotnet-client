namespace Google.Apis.Samples.TranslateApiWin.Services
{
    /// <summary>
    /// A request for a developer key
    /// </summary>
    public interface IDeveloperKeyRequest
    {
        /// <summary>
        /// Causes a developer key request to be sent
        /// </summary>
        /// <param name="applicationName">The application requesting the API key</param>
        /// <returns>Developer Key, or null for anonymous sign in</returns>
        string RequestDeveloperKey(string applicationName);
    }
}