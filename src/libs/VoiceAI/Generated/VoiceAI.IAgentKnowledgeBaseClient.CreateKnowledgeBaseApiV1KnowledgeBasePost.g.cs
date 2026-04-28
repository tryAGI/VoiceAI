#nullable enable

namespace VoiceAI
{
    public partial interface IAgentKnowledgeBaseClient
    {
        /// <summary>
        /// Agent Knowledge Base<br/>
        /// Create a knowledge base that your agent can use for retrieval augmented generation (RAG).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.KnowledgeBaseResponse> CreateKnowledgeBaseApiV1KnowledgeBasePostAsync(

            global::VoiceAI.CreateKnowledgeBaseRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Agent Knowledge Base<br/>
        /// Create a knowledge base that your agent can use for retrieval augmented generation (RAG).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="documents"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.KnowledgeBaseResponse> CreateKnowledgeBaseApiV1KnowledgeBasePostAsync(
            global::System.Collections.Generic.IList<object> documents,
            string? name = default,
            string? description = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}