#nullable enable

namespace VoiceAI
{
    public partial interface IAgentManagementClient
    {
        /// <summary>
        /// Search Phone Numbers<br/>
        /// Search available phone numbers for purchase.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.SearchPhoneNumbersResponse> SearchPhoneNumbersApiV1AgentSearchPhoneNumbersPostAsync(

            global::VoiceAI.SearchPhoneNumbersRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Phone Numbers<br/>
        /// Search available phone numbers for purchase.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.AutoSDKHttpResponse<global::VoiceAI.SearchPhoneNumbersResponse>> SearchPhoneNumbersApiV1AgentSearchPhoneNumbersPostAsResponseAsync(

            global::VoiceAI.SearchPhoneNumbersRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Phone Numbers<br/>
        /// Search available phone numbers for purchase.
        /// </summary>
        /// <param name="countryCode">
        /// Country code (e.g., 'US', 'CA')<br/>
        /// Default Value: US
        /// </param>
        /// <param name="areaCode">
        /// 3-digit area code (e.g., '415')
        /// </param>
        /// <param name="provider">
        /// Provider: 'twilio' or 'telnyx'<br/>
        /// Default Value: twilio
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.SearchPhoneNumbersResponse> SearchPhoneNumbersApiV1AgentSearchPhoneNumbersPostAsync(
            string? countryCode = default,
            string? areaCode = default,
            string? provider = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}