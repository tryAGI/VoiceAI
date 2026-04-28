#nullable enable

namespace VoiceAI
{
    public partial interface ITextToSpeechAudioClient
    {
        /// <summary>
        /// Generate Speech<br/>
        /// Generate speech using an existing voice
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        global::System.Threading.Tasks.Task AudioV2ControllerCreateSpeechAsync(

            global::VoiceAI.TextToSpeechGenerateRequest request,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Speech<br/>
        /// Generate speech using an existing voice
        /// </summary>
        /// <param name="text">
        /// The text you would like to generate speech for
        /// </param>
        /// <param name="voice">
        /// The voice ID to use for generation
        /// </param>
        /// <param name="audioFormat">
        /// The desired audio format: mp3, wav, or pcm
        /// </param>
        /// <param name="streaming">
        /// Whether or not to return streaming audio or a complete file
        /// </param>
        /// <param name="temperature">
        /// Model temperature, supported ranges are between 0.8 and 1.2
        /// </param>
        /// <param name="topP">
        /// Model top_p, supported ranges are between 0.4 and 0.9
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AudioV2ControllerCreateSpeechAsync(
            string text,
            string voice,
            string audioFormat,
            bool streaming,
            double? temperature = default,
            double? topP = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}