#nullable enable

namespace VoiceAI
{
    public partial interface ITextToSpeechVoicesClient
    {
        /// <summary>
        /// Update Voice<br/>
        /// Update one of your uploaded voices
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.VoiceUploadCreateResponse> VoiceV2ControllerUpdateAsync(

            global::VoiceAI.VoiceUpdateRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Voice<br/>
        /// Update one of your uploaded voices
        /// </summary>
        /// <param name="name">
        /// The name of the voice
        /// </param>
        /// <param name="description">
        /// A description of the voice
        /// </param>
        /// <param name="type">
        /// Whether the voice is public or private
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.VoiceUploadCreateResponse> VoiceV2ControllerUpdateAsync(
            string name,
            string? description = default,
            string? type = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}