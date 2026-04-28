
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchPhoneNumbersRequest
    {
        /// <summary>
        /// Country code (e.g., 'US', 'CA')<br/>
        /// Default Value: US
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// 3-digit area code (e.g., '415')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("area_code")]
        public string? AreaCode { get; set; }

        /// <summary>
        /// Provider: 'twilio' or 'telnyx'<br/>
        /// Default Value: twilio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPhoneNumbersRequest" /> class.
        /// </summary>
        /// <param name="countryCode">
        /// Country code (e.g., 'US', 'CA')<br/>
        /// Default Value: US
        /// </param>
        /// <param name="areaCode">
        /// 3-digit area code (e.g., '415')
        /// </param>
        /// <param name="provider">
        /// Provider: 'twilio' or 'telnyx'<br/>
        /// Default Value: twilio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchPhoneNumbersRequest(
            string? countryCode,
            string? areaCode,
            string? provider)
        {
            this.CountryCode = countryCode;
            this.AreaCode = areaCode;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPhoneNumbersRequest" /> class.
        /// </summary>
        public SearchPhoneNumbersRequest()
        {
        }
    }
}