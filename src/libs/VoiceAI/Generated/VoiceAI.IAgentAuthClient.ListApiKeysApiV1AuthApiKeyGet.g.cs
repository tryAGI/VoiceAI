#nullable enable

namespace VoiceAI
{
    public partial interface IAgentAuthClient
    {
        /// <summary>
        /// API Keys List<br/>
        /// List all API keys.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.ListAPIKeysResponse> ListApiKeysApiV1AuthApiKeyGetAsync(
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// API Keys List<br/>
        /// List all API keys.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.AutoSDKHttpResponse<global::VoiceAI.ListAPIKeysResponse>> ListApiKeysApiV1AuthApiKeyGetAsResponseAsync(
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}