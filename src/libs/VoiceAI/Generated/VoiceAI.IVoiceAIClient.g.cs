
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// Generate realistic speech and clone voices. AI voice agents with retrieval augmented generation (RAG) and model context protocol (MCP) included.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IVoiceAIClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::VoiceAI.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::VoiceAI.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AgentAuthClient AgentAuth { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgentCallsClient AgentCalls { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgentConnectionClient AgentConnection { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgentKnowledgeBaseClient AgentKnowledgeBase { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgentManagementClient AgentManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechAudioClient TextToSpeechAudio { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechVoicesClient TextToSpeechVoices { get; }

    }
}