#nullable enable

namespace VoiceAI
{
    public partial interface ITextToSpeechVoicesClient
    {
        /// <summary>
        /// List Voices<br/>
        /// List your uploaded voices
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::VoiceAI.VoiceUploadListResponseItem>> VoiceV2ControllerListAsync(
            string filter,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Voices<br/>
        /// List your uploaded voices
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::VoiceAI.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::VoiceAI.VoiceUploadListResponseItem>>> VoiceV2ControllerListAsResponseAsync(
            string filter,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}