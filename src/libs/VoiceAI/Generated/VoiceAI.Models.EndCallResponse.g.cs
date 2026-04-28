
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndCallResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actual_duration_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ActualDurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreditsUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndCallResponse" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="status"></param>
        /// <param name="endedAt"></param>
        /// <param name="actualDurationSeconds"></param>
        /// <param name="creditsUsed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndCallResponse(
            string callId,
            string status,
            global::System.DateTime endedAt,
            double actualDurationSeconds,
            double creditsUsed)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.EndedAt = endedAt;
            this.ActualDurationSeconds = actualDurationSeconds;
            this.CreditsUsed = creditsUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndCallResponse" /> class.
        /// </summary>
        public EndCallResponse()
        {
        }
    }
}