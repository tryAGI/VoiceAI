#nullable enable

namespace VoiceAI
{
    public partial interface IAgentKnowledgeBaseClient
    {
        /// <summary>
        /// Unassign Knowledge Base<br/>
        /// Remove a knowledge base from an agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task RemoveKnowledgeBaseFromAgentApiV1AgentAgentIdKnowledgeBaseDeleteAsync(
            string agentId,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unassign Knowledge Base<br/>
        /// Remove a knowledge base from an agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.AutoSDKHttpResponse> RemoveKnowledgeBaseFromAgentApiV1AgentAgentIdKnowledgeBaseDeleteAsResponseAsync(
            string agentId,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}