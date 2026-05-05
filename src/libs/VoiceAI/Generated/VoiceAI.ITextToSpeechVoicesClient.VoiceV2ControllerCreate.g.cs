#nullable enable

namespace VoiceAI
{
    public partial interface ITextToSpeechVoicesClient
    {
        /// <summary>
        /// Upload Voice<br/>
        /// Upload a new voice
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.VoiceUploadCreateResponse> VoiceV2ControllerCreateAsync(

            global::VoiceAI.VoiceUploadRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Voice<br/>
        /// Upload a new voice
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.AutoSDKHttpResponse<global::VoiceAI.VoiceUploadCreateResponse>> VoiceV2ControllerCreateAsResponseAsync(

            global::VoiceAI.VoiceUploadRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Voice<br/>
        /// Upload a new voice
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
        /// <param name="voiceTags">
        /// Relevant tags for the voice e.g. Male, Female, Calm, Funny
        /// </param>
        /// <param name="audio">
        /// A base64 encoded audio sample
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.VoiceUploadCreateResponse> VoiceV2ControllerCreateAsync(
            string name,
            string type,
            string audio,
            string? description = default,
            global::System.Collections.Generic.IList<string>? voiceTags = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}