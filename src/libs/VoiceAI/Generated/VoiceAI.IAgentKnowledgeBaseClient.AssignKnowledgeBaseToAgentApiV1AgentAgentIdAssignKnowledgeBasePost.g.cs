#nullable enable

namespace VoiceAI
{
    public partial interface IAgentKnowledgeBaseClient
    {
        /// <summary>
        /// Assign Knowledge Base<br/>
        /// Assign an existing knowledge base to an agent for retrieval augmented generation (RAG).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AssignKnowledgeBaseToAgentApiV1AgentAgentIdAssignKnowledgeBasePostAsync(
            string agentId,

            global::VoiceAI.AssignKnowledgeBaseRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign Knowledge Base<br/>
        /// Assign an existing knowledge base to an agent for retrieval augmented generation (RAG).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="kbId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AssignKnowledgeBaseToAgentApiV1AgentAgentIdAssignKnowledgeBasePostAsync(
            string agentId,
            int kbId,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}