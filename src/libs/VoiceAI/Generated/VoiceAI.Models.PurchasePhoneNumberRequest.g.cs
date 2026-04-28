
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PurchasePhoneNumberRequest
    {
        /// <summary>
        /// Exact phone number to purchase (e.g., '+15551234567')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

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
        /// Initializes a new instance of the <see cref="PurchasePhoneNumberRequest" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// Exact phone number to purchase (e.g., '+15551234567')
        /// </param>
        /// <param name="provider">
        /// Provider: 'twilio' or 'telnyx'<br/>
        /// Default Value: twilio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PurchasePhoneNumberRequest(
            string phoneNumber,
            string? provider)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchasePhoneNumberRequest" /> class.
        /// </summary>
        public PurchasePhoneNumberRequest()
        {
        }
    }
}