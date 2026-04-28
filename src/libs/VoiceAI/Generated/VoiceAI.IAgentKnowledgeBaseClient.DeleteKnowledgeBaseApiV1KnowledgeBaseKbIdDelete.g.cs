#nullable enable

namespace VoiceAI
{
    public partial interface IAgentKnowledgeBaseClient
    {
        /// <summary>
        /// Agent Knowledge Base<br/>
        /// Delete an existing knowledge base.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteKnowledgeBaseApiV1KnowledgeBaseKbIdDeleteAsync(
            int kbId,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}