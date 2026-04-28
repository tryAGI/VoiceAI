#nullable enable

namespace VoiceAI
{
    public partial interface IAgentKnowledgeBaseClient
    {
        /// <summary>
        /// Agent Knowledge Base<br/>
        /// Update an existing knowledge base.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.KnowledgeBaseWithDocuments> UpdateKnowledgeBaseApiV1KnowledgeBaseKbIdPutAsync(
            int kbId,

            global::VoiceAI.UpdateKnowledgeBaseRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Agent Knowledge Base<br/>
        /// Update an existing knowledge base.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="documents"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.KnowledgeBaseWithDocuments> UpdateKnowledgeBaseApiV1KnowledgeBaseKbIdPutAsync(
            int kbId,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<object>? documents = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}