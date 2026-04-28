
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssignKnowledgeBaseRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kb_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int KbId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignKnowledgeBaseRequest" /> class.
        /// </summary>
        /// <param name="kbId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssignKnowledgeBaseRequest(
            int kbId)
        {
            this.KbId = kbId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignKnowledgeBaseRequest" /> class.
        /// </summary>
        public AssignKnowledgeBaseRequest()
        {
        }
    }
}