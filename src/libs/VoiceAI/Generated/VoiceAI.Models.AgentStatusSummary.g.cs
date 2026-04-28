
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentStatusSummary
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployed")]
        public int? Deployed { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paused")]
        public int? Paused { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public int? Disabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStatusSummary" /> class.
        /// </summary>
        /// <param name="deployed">
        /// Default Value: 0
        /// </param>
        /// <param name="paused">
        /// Default Value: 0
        /// </param>
        /// <param name="disabled">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentStatusSummary(
            int? deployed,
            int? paused,
            int? disabled)
        {
            this.Deployed = deployed;
            this.Paused = paused;
            this.Disabled = disabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStatusSummary" /> class.
        /// </summary>
        public AgentStatusSummary()
        {
        }
    }
}