#nullable enable

namespace VoiceAI
{
    public partial interface IAgentAuthClient
    {
        /// <summary>
        /// API Key<br/>
        /// Update an API key.
        /// </summary>
        /// <param name="keyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.APIKeyResponse> UpdateApiKeyApiV1AuthApiKeyKeyIdPutAsync(
            int keyId,

            global::VoiceAI.UpdateAPIKeyRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// API Key<br/>
        /// Update an API key.
        /// </summary>
        /// <param name="keyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.AutoSDKHttpResponse<global::VoiceAI.APIKeyResponse>> UpdateApiKeyApiV1AuthApiKeyKeyIdPutAsResponseAsync(
            int keyId,

            global::VoiceAI.UpdateAPIKeyRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// API Key<br/>
        /// Update an API key.
        /// </summary>
        /// <param name="keyId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="isActive"></param>
        /// <param name="expiresAt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.APIKeyResponse> UpdateApiKeyApiV1AuthApiKeyKeyIdPutAsync(
            int keyId,
            string? name = default,
            string? description = default,
            bool? isActive = default,
            global::System.DateTime? expiresAt = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}