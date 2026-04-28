#nullable enable

namespace VoiceAI
{
    public partial interface IAgentManagementClient
    {
        /// <summary>
        /// Owned Phone Numbers<br/>
        /// Retrieve owned phone numbers that aren't currently assigned to an agent.
        /// </summary>
        /// <param name="page">
        /// Page number (1-based)
        /// </param>
        /// <param name="limit">
        /// Items per page
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.PaginatedPhoneNumberResponse> GetAvailablePhoneNumbersApiV1AgentAvailablePhoneNumbersGetAsync(
            int? page = default,
            int? limit = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}