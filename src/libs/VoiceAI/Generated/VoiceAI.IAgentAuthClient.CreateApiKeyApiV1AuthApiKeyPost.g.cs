#nullable enable

namespace VoiceAI
{
    public partial interface IAgentAuthClient
    {
        /// <summary>
        /// API Key<br/>
        /// Create a new API key.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.CreateAPIKeyResponse> CreateApiKeyApiV1AuthApiKeyPostAsync(

            global::VoiceAI.CreateAPIKeyRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// API Key<br/>
        /// Create a new API key.
        /// </summary>
        /// <param name="name">
        /// Human-readable name for the API key
        /// </param>
        /// <param name="description">
        /// Optional description of the key's purpose
        /// </param>
        /// <param name="expiresAt">
        /// Optional expiration date for the key
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.CreateAPIKeyResponse> CreateApiKeyApiV1AuthApiKeyPostAsync(
            string name,
            string? description = default,
            global::System.DateTime? expiresAt = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}