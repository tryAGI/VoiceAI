
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchPhoneNumbersResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::VoiceAI.AvailablePhoneNumber> Results { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_results")]
        public int? TotalResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPhoneNumbersResponse" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="totalResults">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchPhoneNumbersResponse(
            global::System.Collections.Generic.IList<global::VoiceAI.AvailablePhoneNumber> results,
            int? totalResults)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.TotalResults = totalResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPhoneNumbersResponse" /> class.
        /// </summary>
        public SearchPhoneNumbersResponse()
        {
        }
    }
}