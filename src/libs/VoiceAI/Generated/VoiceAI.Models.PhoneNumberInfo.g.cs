
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_to_agent_id")]
        public string? AssignedToAgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_to_agent_name")]
        public string? AssignedToAgentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberInfo" /> class.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="status"></param>
        /// <param name="assignedToAgentId"></param>
        /// <param name="assignedToAgentName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberInfo(
            string phoneNumber,
            string status,
            string? assignedToAgentId,
            string? assignedToAgentName)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.AssignedToAgentId = assignedToAgentId;
            this.AssignedToAgentName = assignedToAgentName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberInfo" /> class.
        /// </summary>
        public PhoneNumberInfo()
        {
        }
    }
}