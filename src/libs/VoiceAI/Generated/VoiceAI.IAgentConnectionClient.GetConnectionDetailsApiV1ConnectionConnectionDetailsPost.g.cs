#nullable enable

namespace VoiceAI
{
    public partial interface IAgentConnectionClient
    {
        /// <summary>
        /// Connection Details<br/>
        /// Get connection details for use with the Voice.AI SDK.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.ConnectionDetailsResponse> GetConnectionDetailsApiV1ConnectionConnectionDetailsPostAsync(

            global::VoiceAI.ConnectionDetailsRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Connection Details<br/>
        /// Get connection details for use with the Voice.AI SDK.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.AutoSDKHttpResponse<global::VoiceAI.ConnectionDetailsResponse>> GetConnectionDetailsApiV1ConnectionConnectionDetailsPostAsResponseAsync(

            global::VoiceAI.ConnectionDetailsRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Connection Details<br/>
        /// Get connection details for use with the Voice.AI SDK.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="metadata"></param>
        /// <param name="environment"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.ConnectionDetailsResponse> GetConnectionDetailsApiV1ConnectionConnectionDetailsPostAsync(
            string? agentId = default,
            string? metadata = default,
            string? environment = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}