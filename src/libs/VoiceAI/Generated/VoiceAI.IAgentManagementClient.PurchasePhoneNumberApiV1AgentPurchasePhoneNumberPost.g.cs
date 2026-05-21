#nullable enable

namespace VoiceAI
{
    public partial interface IAgentManagementClient
    {
        /// <summary>
        /// Purchase Phone Number<br/>
        /// Attempt to purchase a phone number.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.PurchasePhoneNumberResponse> PurchasePhoneNumberApiV1AgentPurchasePhoneNumberPostAsync(

            global::VoiceAI.PurchasePhoneNumberRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Purchase Phone Number<br/>
        /// Attempt to purchase a phone number.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.AutoSDKHttpResponse<global::VoiceAI.PurchasePhoneNumberResponse>> PurchasePhoneNumberApiV1AgentPurchasePhoneNumberPostAsResponseAsync(

            global::VoiceAI.PurchasePhoneNumberRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Purchase Phone Number<br/>
        /// Attempt to purchase a phone number.
        /// </summary>
        /// <param name="phoneNumber">
        /// Exact phone number to purchase (e.g., '+15551234567')
        /// </param>
        /// <param name="provider">
        /// Provider: 'twilio' or 'telnyx'<br/>
        /// Default Value: twilio
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.PurchasePhoneNumberResponse> PurchasePhoneNumberApiV1AgentPurchasePhoneNumberPostAsync(
            string phoneNumber,
            string? provider = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}