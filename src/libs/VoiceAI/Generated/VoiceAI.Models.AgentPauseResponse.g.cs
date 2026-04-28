
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentPauseResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::VoiceAI.AgentOutput Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPauseResponse" /> class.
        /// </summary>
        /// <param name="agent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentPauseResponse(
            global::VoiceAI.AgentOutput agent)
        {
            this.Agent = agent ?? throw new global::System.ArgumentNullException(nameof(agent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPauseResponse" /> class.
        /// </summary>
        public AgentPauseResponse()
        {
        }
    }
}