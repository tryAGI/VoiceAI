
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAPIKeyResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::VoiceAI.APIKeyResponse KeyInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAPIKeyResponse" /> class.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="keyInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAPIKeyResponse(
            string apiKey,
            global::VoiceAI.APIKeyResponse keyInfo)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.KeyInfo = keyInfo ?? throw new global::System.ArgumentNullException(nameof(keyInfo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAPIKeyResponse" /> class.
        /// </summary>
        public CreateAPIKeyResponse()
        {
        }
    }
}