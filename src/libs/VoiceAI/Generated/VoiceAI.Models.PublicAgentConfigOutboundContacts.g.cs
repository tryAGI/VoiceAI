
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// Saved contacts for outbound calling (name -&gt; phone number mapping). Required if allow_outbound_calling is true.<br/>
    /// Default Value: {}
    /// </summary>
    public sealed partial class PublicAgentConfigOutboundContacts
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}