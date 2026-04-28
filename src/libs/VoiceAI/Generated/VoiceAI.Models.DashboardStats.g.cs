
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DashboardStats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_of_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumberOfCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AverageDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_credits_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCreditsUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_credits_per_call")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgCreditsPerCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_stats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::VoiceAI.DailyStat> DailyStats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardStats" /> class.
        /// </summary>
        /// <param name="numberOfCalls"></param>
        /// <param name="averageDuration"></param>
        /// <param name="totalCreditsUsed"></param>
        /// <param name="avgCreditsPerCall"></param>
        /// <param name="dailyStats"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DashboardStats(
            int numberOfCalls,
            double averageDuration,
            double totalCreditsUsed,
            double avgCreditsPerCall,
            global::System.Collections.Generic.IList<global::VoiceAI.DailyStat> dailyStats)
        {
            this.NumberOfCalls = numberOfCalls;
            this.AverageDuration = averageDuration;
            this.TotalCreditsUsed = totalCreditsUsed;
            this.AvgCreditsPerCall = avgCreditsPerCall;
            this.DailyStats = dailyStats ?? throw new global::System.ArgumentNullException(nameof(dailyStats));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardStats" /> class.
        /// </summary>
        public DashboardStats()
        {
        }
    }
}