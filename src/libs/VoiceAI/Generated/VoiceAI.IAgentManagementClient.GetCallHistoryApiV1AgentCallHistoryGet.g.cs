#nullable enable

namespace VoiceAI
{
    public partial interface IAgentManagementClient
    {
        /// <summary>
        /// Call History<br/>
        /// Retrieve detailed call logs.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="startDate">
        /// Filter calls after this date (ISO format UTC, e.g., 2024-01-01T00:00:00+00:00)
        /// </param>
        /// <param name="endDate">
        /// Filter calls before this date (ISO format UTC, e.g., 2024-12-31T23:59:59+00:00)
        /// </param>
        /// <param name="agentId">
        /// Filter calls by specific agent ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.PaginatedCallHistoryResponse> GetCallHistoryApiV1AgentCallHistoryGetAsync(
            int? page = default,
            int? limit = default,
            string? startDate = default,
            string? endDate = default,
            string? agentId = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Call History<br/>
        /// Retrieve detailed call logs.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="startDate">
        /// Filter calls after this date (ISO format UTC, e.g., 2024-01-01T00:00:00+00:00)
        /// </param>
        /// <param name="endDate">
        /// Filter calls before this date (ISO format UTC, e.g., 2024-12-31T23:59:59+00:00)
        /// </param>
        /// <param name="agentId">
        /// Filter calls by specific agent ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.AutoSDKHttpResponse<global::VoiceAI.PaginatedCallHistoryResponse>> GetCallHistoryApiV1AgentCallHistoryGetAsResponseAsync(
            int? page = default,
            int? limit = default,
            string? startDate = default,
            string? endDate = default,
            string? agentId = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}