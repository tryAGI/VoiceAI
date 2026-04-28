
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicAgentConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("greeting")]
        public string? Greeting { get; set; }

        /// <summary>
        /// Default Value: 0.7F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_temperature")]
        public double? LlmTemperature { get; set; }

        /// <summary>
        /// Default Value: gemini-2.5-flash-lite
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        public string? LlmModel { get; set; }

        /// <summary>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_min_sentence_len")]
        public int? TtsMinSentenceLen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_params")]
        public global::VoiceAI.TTSParams? TtsParams { get; set; }

        /// <summary>
        /// Default Value: 0.55F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_silence_duration")]
        public double? MinSilenceDuration { get; set; }

        /// <summary>
        /// Default Value: 0.1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_speech_duration")]
        public double? MinSpeechDuration { get; set; }

        /// <summary>
        /// Default Value: 10F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_silence_timeout")]
        public double? UserSilenceTimeout { get; set; }

        /// <summary>
        /// Default Value: 900
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_call_duration_seconds")]
        public double? MaxCallDurationSeconds { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_interruptions")]
        public bool? AllowInterruptions { get; set; }

        /// <summary>
        /// Minimum words required for interruption (0=any speech, 1+=word count)<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_interruption_words")]
        public int? MinInterruptionWords { get; set; }

        /// <summary>
        /// Enable automatic noise reduction based on environment<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_noise_reduction")]
        public bool? AutoNoiseReduction { get; set; }

        /// <summary>
        /// Whether agent can end calls via tool or timeout<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_agent_to_end_call")]
        public bool? AllowAgentToEndCall { get; set; }

        /// <summary>
        /// Whether agent can skip turns and yield conversation control<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_agent_to_skip_turn")]
        public bool? AllowAgentToSkipTurn { get; set; }

        /// <summary>
        /// Whether agent can make outbound calls to saved contacts<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_outbound_calling")]
        public bool? AllowOutboundCalling { get; set; }

        /// <summary>
        /// Saved contacts for outbound calling (name -&gt; phone number mapping). Required if allow_outbound_calling is true.<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outbound_contacts")]
        public global::System.Collections.Generic.Dictionary<string, string>? OutboundContacts { get; set; }

        /// <summary>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_endpointing_delay")]
        public double? MinEndpointingDelay { get; set; }

        /// <summary>
        /// Default Value: 3F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_endpointing_delay")]
        public double? MaxEndpointingDelay { get; set; }

        /// <summary>
        /// Default Value: 0.6F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vad_activation_threshold")]
        public double? VadActivationThreshold { get; set; }

        /// <summary>
        /// Phone number in E.164 format (supports multiple providers). Empty strings will be converted to None.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// MCP servers configuration. List of MCP server configs with name, description, authentication and connection settings. Transport type is automatically detected from URL path.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_servers")]
        public global::System.Collections.Generic.IList<object>? McpServers { get; set; }

        /// <summary>
        /// Voice switching configuration. Format: {'voice_name': {'speaker_id': str, 'sub_prompt': str, 'description': str}}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_voices")]
        public global::System.Collections.Generic.Dictionary<string, object>? AvailableVoices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentConfig" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="greeting"></param>
        /// <param name="llmTemperature">
        /// Default Value: 0.7F
        /// </param>
        /// <param name="llmModel">
        /// Default Value: gemini-2.5-flash-lite
        /// </param>
        /// <param name="ttsMinSentenceLen">
        /// Default Value: 20
        /// </param>
        /// <param name="ttsParams"></param>
        /// <param name="minSilenceDuration">
        /// Default Value: 0.55F
        /// </param>
        /// <param name="minSpeechDuration">
        /// Default Value: 0.1F
        /// </param>
        /// <param name="userSilenceTimeout">
        /// Default Value: 10F
        /// </param>
        /// <param name="maxCallDurationSeconds">
        /// Default Value: 900
        /// </param>
        /// <param name="allowInterruptions">
        /// Default Value: true
        /// </param>
        /// <param name="minInterruptionWords">
        /// Minimum words required for interruption (0=any speech, 1+=word count)<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="autoNoiseReduction">
        /// Enable automatic noise reduction based on environment<br/>
        /// Default Value: true
        /// </param>
        /// <param name="allowAgentToEndCall">
        /// Whether agent can end calls via tool or timeout<br/>
        /// Default Value: false
        /// </param>
        /// <param name="allowAgentToSkipTurn">
        /// Whether agent can skip turns and yield conversation control<br/>
        /// Default Value: false
        /// </param>
        /// <param name="allowOutboundCalling">
        /// Whether agent can make outbound calls to saved contacts<br/>
        /// Default Value: false
        /// </param>
        /// <param name="outboundContacts">
        /// Saved contacts for outbound calling (name -&gt; phone number mapping). Required if allow_outbound_calling is true.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="minEndpointingDelay">
        /// Default Value: 0.5F
        /// </param>
        /// <param name="maxEndpointingDelay">
        /// Default Value: 3F
        /// </param>
        /// <param name="vadActivationThreshold">
        /// Default Value: 0.6F
        /// </param>
        /// <param name="phoneNumber">
        /// Phone number in E.164 format (supports multiple providers). Empty strings will be converted to None.
        /// </param>
        /// <param name="mcpServers">
        /// MCP servers configuration. List of MCP server configs with name, description, authentication and connection settings. Transport type is automatically detected from URL path.
        /// </param>
        /// <param name="availableVoices">
        /// Voice switching configuration. Format: {'voice_name': {'speaker_id': str, 'sub_prompt': str, 'description': str}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAgentConfig(
            string? prompt,
            string? greeting,
            double? llmTemperature,
            string? llmModel,
            int? ttsMinSentenceLen,
            global::VoiceAI.TTSParams? ttsParams,
            double? minSilenceDuration,
            double? minSpeechDuration,
            double? userSilenceTimeout,
            double? maxCallDurationSeconds,
            bool? allowInterruptions,
            int? minInterruptionWords,
            bool? autoNoiseReduction,
            bool? allowAgentToEndCall,
            bool? allowAgentToSkipTurn,
            bool? allowOutboundCalling,
            global::System.Collections.Generic.Dictionary<string, string>? outboundContacts,
            double? minEndpointingDelay,
            double? maxEndpointingDelay,
            double? vadActivationThreshold,
            string? phoneNumber,
            global::System.Collections.Generic.IList<object>? mcpServers,
            global::System.Collections.Generic.Dictionary<string, object>? availableVoices)
        {
            this.Prompt = prompt;
            this.Greeting = greeting;
            this.LlmTemperature = llmTemperature;
            this.LlmModel = llmModel;
            this.TtsMinSentenceLen = ttsMinSentenceLen;
            this.TtsParams = ttsParams;
            this.MinSilenceDuration = minSilenceDuration;
            this.MinSpeechDuration = minSpeechDuration;
            this.UserSilenceTimeout = userSilenceTimeout;
            this.MaxCallDurationSeconds = maxCallDurationSeconds;
            this.AllowInterruptions = allowInterruptions;
            this.MinInterruptionWords = minInterruptionWords;
            this.AutoNoiseReduction = autoNoiseReduction;
            this.AllowAgentToEndCall = allowAgentToEndCall;
            this.AllowAgentToSkipTurn = allowAgentToSkipTurn;
            this.AllowOutboundCalling = allowOutboundCalling;
            this.OutboundContacts = outboundContacts;
            this.MinEndpointingDelay = minEndpointingDelay;
            this.MaxEndpointingDelay = maxEndpointingDelay;
            this.VadActivationThreshold = vadActivationThreshold;
            this.PhoneNumber = phoneNumber;
            this.McpServers = mcpServers;
            this.AvailableVoices = availableVoices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAgentConfig" /> class.
        /// </summary>
        public PublicAgentConfig()
        {
        }
    }
}