
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallHistoryItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CallTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_duration_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CallDurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreditsUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasTranscript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_type")]
        public string? CallType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_number")]
        public string? FromNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_number")]
        public string? ToNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription_summary")]
        public string? TranscriptionSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription_stats")]
        public object? TranscriptionStats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHistoryItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="callTimestamp"></param>
        /// <param name="callDurationSeconds"></param>
        /// <param name="creditsUsed"></param>
        /// <param name="hasTranscript"></param>
        /// <param name="agentId"></param>
        /// <param name="agentName"></param>
        /// <param name="callType"></param>
        /// <param name="fromNumber"></param>
        /// <param name="toNumber"></param>
        /// <param name="transcriptionSummary"></param>
        /// <param name="transcriptionStats"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHistoryItem(
            int id,
            global::System.DateTime callTimestamp,
            double callDurationSeconds,
            double creditsUsed,
            bool hasTranscript,
            string? agentId,
            string? agentName,
            string? callType,
            string? fromNumber,
            string? toNumber,
            string? transcriptionSummary,
            object? transcriptionStats)
        {
            this.Id = id;
            this.AgentId = agentId;
            this.AgentName = agentName;
            this.CallTimestamp = callTimestamp;
            this.CallDurationSeconds = callDurationSeconds;
            this.CreditsUsed = creditsUsed;
            this.HasTranscript = hasTranscript;
            this.CallType = callType;
            this.FromNumber = fromNumber;
            this.ToNumber = toNumber;
            this.TranscriptionSummary = transcriptionSummary;
            this.TranscriptionStats = transcriptionStats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHistoryItem" /> class.
        /// </summary>
        public CallHistoryItem()
        {
        }
    }
}