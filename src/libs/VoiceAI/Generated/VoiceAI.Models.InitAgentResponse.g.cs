
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InitAgentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object AgentTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AvailableTypes { get; set; }

        /// <summary>
        /// Default Value: Pre-configured agent template based on selected type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitAgentResponse" /> class.
        /// </summary>
        /// <param name="agentTemplate"></param>
        /// <param name="availableTypes"></param>
        /// <param name="description">
        /// Default Value: Pre-configured agent template based on selected type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InitAgentResponse(
            object agentTemplate,
            global::System.Collections.Generic.IList<string> availableTypes,
            string? description)
        {
            this.AgentTemplate = agentTemplate ?? throw new global::System.ArgumentNullException(nameof(agentTemplate));
            this.AvailableTypes = availableTypes ?? throw new global::System.ArgumentNullException(nameof(availableTypes));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitAgentResponse" /> class.
        /// </summary>
        public InitAgentResponse()
        {
        }
    }
}