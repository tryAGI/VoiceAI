#nullable enable

namespace VoiceAI
{
    public partial interface IAgentManagementClient
    {
        /// <summary>
        /// Phone Number Details<br/>
        /// Get detailed information on owned phone numbers.
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
        global::System.Threading.Tasks.Task<global::VoiceAI.PaginatedAllPhoneNumbersResponse> GetAllPhoneNumbersApiV1AgentPhoneNumbersGetAsync(
            int? page = default,
            int? limit = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}