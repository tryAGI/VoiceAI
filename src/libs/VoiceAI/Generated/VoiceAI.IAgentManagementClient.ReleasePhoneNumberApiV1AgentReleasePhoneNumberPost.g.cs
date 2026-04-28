#nullable enable

namespace VoiceAI
{
    public partial interface IAgentManagementClient
    {
        /// <summary>
        /// Release Phone Number<br/>
        /// Release an owned phone number. Phone numbers attached to deployed agents cannot be released. You must first pause your agent.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.PurchasePhoneNumberResponse> ReleasePhoneNumberApiV1AgentReleasePhoneNumberPostAsync(

            global::VoiceAI.PurchasePhoneNumberRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Release Phone Number<br/>
        /// Release an owned phone number. Phone numbers attached to deployed agents cannot be released. You must first pause your agent.
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
        global::System.Threading.Tasks.Task<global::VoiceAI.PurchasePhoneNumberResponse> ReleasePhoneNumberApiV1AgentReleasePhoneNumberPostAsync(
            string phoneNumber,
            string? provider = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}