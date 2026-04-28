
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentStatsSummaryResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalAgents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::VoiceAI.AgentStatusSummary StatusSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStatsSummaryResponse" /> class.
        /// </summary>
        /// <param name="totalAgents"></param>
        /// <param name="statusSummary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentStatsSummaryResponse(
            int totalAgents,
            global::VoiceAI.AgentStatusSummary statusSummary)
        {
            this.TotalAgents = totalAgents;
            this.StatusSummary = statusSummary ?? throw new global::System.ArgumentNullException(nameof(statusSummary));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStatsSummaryResponse" /> class.
        /// </summary>
        public AgentStatsSummaryResponse()
        {
        }
    }
}