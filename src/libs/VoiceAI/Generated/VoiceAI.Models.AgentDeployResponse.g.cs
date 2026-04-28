
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentDeployResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::VoiceAI.AgentOutput Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sip_status")]
        public string? SipStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sip_details")]
        public object? SipDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDeployResponse" /> class.
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="message"></param>
        /// <param name="sipStatus"></param>
        /// <param name="sipDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentDeployResponse(
            global::VoiceAI.AgentOutput agent,
            string message,
            string? sipStatus,
            object? sipDetails)
        {
            this.Agent = agent ?? throw new global::System.ArgumentNullException(nameof(agent));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.SipStatus = sipStatus;
            this.SipDetails = sipDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDeployResponse" /> class.
        /// </summary>
        public AgentDeployResponse()
        {
        }
    }
}