
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToSpeechGenerateRequest
    {
        /// <summary>
        /// The text you would like to generate speech for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The voice ID to use for generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Voice { get; set; }

        /// <summary>
        /// The desired audio format: mp3, wav, or pcm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioFormat { get; set; }

        /// <summary>
        /// Whether or not to return streaming audio or a complete file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Streaming { get; set; }

        /// <summary>
        /// Model temperature, supported ranges are between 0.8 and 1.2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Model top_p, supported ranges are between 0.4 and 0.9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechGenerateRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToSpeechGenerateRequest(
            string text,
            string voice,
            string audioFormat,
            bool streaming,
            double? temperature,
            double? topP)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.AudioFormat = audioFormat ?? throw new global::System.ArgumentNullException(nameof(audioFormat));
            this.Streaming = streaming;
            this.Temperature = temperature;
            this.TopP = topP;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechGenerateRequest" /> class.
        /// </summary>
        public TextToSpeechGenerateRequest()
        {
        }
    }
}