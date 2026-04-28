
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AllPhoneNumbersResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_numbers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::VoiceAI.PhoneNumberInfo> PhoneNumbers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_numbers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalNumbers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalAvailable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_assigned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalAssigned { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AllPhoneNumbersResponse" /> class.
        /// </summary>
        /// <param name="phoneNumbers"></param>
        /// <param name="totalNumbers"></param>
        /// <param name="totalAvailable"></param>
        /// <param name="totalAssigned"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AllPhoneNumbersResponse(
            global::System.Collections.Generic.IList<global::VoiceAI.PhoneNumberInfo> phoneNumbers,
            int totalNumbers,
            int totalAvailable,
            int totalAssigned)
        {
            this.PhoneNumbers = phoneNumbers ?? throw new global::System.ArgumentNullException(nameof(phoneNumbers));
            this.TotalNumbers = totalNumbers;
            this.TotalAvailable = totalAvailable;
            this.TotalAssigned = totalAssigned;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllPhoneNumbersResponse" /> class.
        /// </summary>
        public AllPhoneNumbersResponse()
        {
        }
    }
}