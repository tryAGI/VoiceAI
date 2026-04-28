
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// Voice switching configuration. Format: {'voice_name': {'speaker_id': str, 'sub_prompt': str, 'description': str}}
    /// </summary>
    public sealed partial class PublicAgentConfigAvailableVoices
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}