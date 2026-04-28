#nullable enable

namespace VoiceAI
{
    public partial interface ITextToSpeechVoicesClient
    {
        /// <summary>
        /// Delete Voice<br/>
        /// Delete an uploaded voice
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task VoiceV2ControllerDeleteAsync(

            global::VoiceAI.VoiceDeleteRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Voice<br/>
        /// Delete an uploaded voice
        /// </summary>
        /// <param name="id">
        /// The ID of the voice to be deleted
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task VoiceV2ControllerDeleteAsync(
            string id,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}