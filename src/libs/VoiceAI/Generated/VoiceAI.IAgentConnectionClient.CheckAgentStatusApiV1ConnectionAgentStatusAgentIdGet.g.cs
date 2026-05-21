#nullable enable

namespace VoiceAI
{
    public partial interface IAgentConnectionClient
    {
        /// <summary>
        /// Agent Connection Status<br/>
        /// Check if an agent is currently available to be connected to.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.AgentStatusResponse> CheckAgentStatusApiV1ConnectionAgentStatusAgentIdGetAsync(
            string agentId,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Agent Connection Status<br/>
        /// Check if an agent is currently available to be connected to.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.AutoSDKHttpResponse<global::VoiceAI.AgentStatusResponse>> CheckAgentStatusApiV1ConnectionAgentStatusAgentIdGetAsResponseAsync(
            string agentId,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}