#nullable enable

namespace VoiceAI
{
    public partial interface IAgentManagementClient
    {
        /// <summary>
        /// Agent Details List<br/>
        /// Retrieve detailed agents information.
        /// </summary>
        /// <param name="page">
        /// Page number (1-based)
        /// </param>
        /// <param name="limit">
        /// Items per page
        /// </param>
        /// <param name="showStatuses">
        /// List of statuses to show. By default shows deployed and paused agents.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.PaginatedAgentResponseOutput> ListUserAgentsApiV1AgentGetAsync(
            int? page = default,
            int? limit = default,
            global::System.Collections.Generic.IList<string>? showStatuses = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Agent Details List<br/>
        /// Retrieve detailed agents information.
        /// </summary>
        /// <param name="page">
        /// Page number (1-based)
        /// </param>
        /// <param name="limit">
        /// Items per page
        /// </param>
        /// <param name="showStatuses">
        /// List of statuses to show. By default shows deployed and paused agents.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.AutoSDKHttpResponse<global::VoiceAI.PaginatedAgentResponseOutput>> ListUserAgentsApiV1AgentGetAsResponseAsync(
            int? page = default,
            int? limit = default,
            global::System.Collections.Generic.IList<string>? showStatuses = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}