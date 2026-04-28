
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TTSParams
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::VoiceAI.JsonConverters.AnyOfJsonConverter<string, int?>))]
        public global::VoiceAI.AnyOf<string, int?>? Speaker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Default Value: mp3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public string? ResponseFormat { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Default Value: 0.8F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSParams" /> class.
        /// </summary>
        /// <param name="speaker">
        /// Default Value: 0
        /// </param>
        /// <param name="voiceId"></param>
        /// <param name="temperature">
        /// Default Value: 1F
        /// </param>
        /// <param name="responseFormat">
        /// Default Value: mp3
        /// </param>
        /// <param name="stream">
        /// Default Value: true
        /// </param>
        /// <param name="topP">
        /// Default Value: 0.8F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSParams(
            global::VoiceAI.AnyOf<string, int?>? speaker,
            string? voiceId,
            double? temperature,
            string? responseFormat,
            bool? stream,
            double? topP)
        {
            this.Speaker = speaker;
            this.VoiceId = voiceId;
            this.Temperature = temperature;
            this.ResponseFormat = responseFormat;
            this.Stream = stream;
            this.TopP = topP;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSParams" /> class.
        /// </summary>
        public TTSParams()
        {
        }
    }
}