
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAPIKeysResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::VoiceAI.APIKeyResponse> ApiKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAPIKeysResponse" /> class.
        /// </summary>
        /// <param name="apiKeys"></param>
        /// <param name="totalKeys"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAPIKeysResponse(
            global::System.Collections.Generic.IList<global::VoiceAI.APIKeyResponse> apiKeys,
            int totalKeys)
        {
            this.ApiKeys = apiKeys ?? throw new global::System.ArgumentNullException(nameof(apiKeys));
            this.TotalKeys = totalKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAPIKeysResponse" /> class.
        /// </summary>
        public ListAPIKeysResponse()
        {
        }
    }
}