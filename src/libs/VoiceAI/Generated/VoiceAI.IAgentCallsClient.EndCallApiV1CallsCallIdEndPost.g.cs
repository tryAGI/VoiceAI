#nullable enable

namespace VoiceAI
{
    public partial interface IAgentCallsClient
    {
        /// <summary>
        /// End Call<br/>
        /// Marks a call as ended, this should be called as best-effort from front end clients at the end of a call.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="actualDurationSeconds">
        /// Actual duration of the call in seconds
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.EndCallResponse> EndCallApiV1CallsCallIdEndPostAsync(
            string callId,
            double? actualDurationSeconds = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// End Call<br/>
        /// Marks a call as ended, this should be called as best-effort from front end clients at the end of a call.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="actualDurationSeconds">
        /// Actual duration of the call in seconds
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.AutoSDKHttpResponse<global::VoiceAI.EndCallResponse>> EndCallApiV1CallsCallIdEndPostAsResponseAsync(
            string callId,
            double? actualDurationSeconds = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}