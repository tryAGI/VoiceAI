
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentDisableResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::VoiceAI.AgentOutput Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDisableResponse" /> class.
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentDisableResponse(
            global::VoiceAI.AgentOutput agent,
            string? message)
        {
            this.Agent = agent ?? throw new global::System.ArgumentNullException(nameof(agent));
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDisableResponse" /> class.
        /// </summary>
        public AgentDisableResponse()
        {
        }
    }
}