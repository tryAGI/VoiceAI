#nullable enable

namespace VoiceAI
{
    public partial interface IAgentManagementClient
    {
        /// <summary>
        /// Agent From Template<br/>
        /// Create an agent from a saved template.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.InitAgentResponse> InitializeAgentApiV1AgentInitAgentPostAsync(

            global::VoiceAI.InitAgentRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Agent From Template<br/>
        /// Create an agent from a saved template.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.AutoSDKHttpResponse<global::VoiceAI.InitAgentResponse>> InitializeAgentApiV1AgentInitAgentPostAsResponseAsync(

            global::VoiceAI.InitAgentRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Agent From Template<br/>
        /// Create an agent from a saved template.
        /// </summary>
        /// <param name="agentTemplate"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.InitAgentResponse> InitializeAgentApiV1AgentInitAgentPostAsync(
            string? agentTemplate = default,
            string? name = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}