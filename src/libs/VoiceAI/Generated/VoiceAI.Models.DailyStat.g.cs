
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DailyStat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCredits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyStat" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="totalCalls"></param>
        /// <param name="totalCredits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DailyStat(
            string date,
            int totalCalls,
            double totalCredits)
        {
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
            this.TotalCalls = totalCalls;
            this.TotalCredits = totalCredits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyStat" /> class.
        /// </summary>
        public DailyStat()
        {
        }
    }
}