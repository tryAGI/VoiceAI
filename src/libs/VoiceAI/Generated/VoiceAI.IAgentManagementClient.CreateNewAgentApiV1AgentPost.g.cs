#nullable enable

namespace VoiceAI
{
    public partial interface IAgentManagementClient
    {
        /// <summary>
        /// Agent<br/>
        /// Create a new agent.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.AgentOutput> CreateNewAgentApiV1AgentPostAsync(

            global::VoiceAI.CreateAgentRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Agent<br/>
        /// Create a new agent.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.AutoSDKHttpResponse<global::VoiceAI.AgentOutput>> CreateNewAgentApiV1AgentPostAsResponseAsync(

            global::VoiceAI.CreateAgentRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Agent<br/>
        /// Create a new agent.
        /// </summary>
        /// <param name="name">
        /// Agent name cannot be empty
        /// </param>
        /// <param name="config"></param>
        /// <param name="kbId"></param>
        /// <param name="documents"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.AgentOutput> CreateNewAgentApiV1AgentPostAsync(
            string name,
            global::VoiceAI.PublicAgentConfig config,
            int? kbId = default,
            global::System.Collections.Generic.IList<object>? documents = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}