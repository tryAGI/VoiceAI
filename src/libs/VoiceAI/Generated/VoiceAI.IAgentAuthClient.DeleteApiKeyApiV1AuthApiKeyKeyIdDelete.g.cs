#nullable enable

namespace VoiceAI
{
    public partial interface IAgentAuthClient
    {
        /// <summary>
        /// API Key<br/>
        /// Delete an existing API key.
        /// </summary>
        /// <param name="keyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteApiKeyApiV1AuthApiKeyKeyIdDeleteAsync(
            int keyId,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}