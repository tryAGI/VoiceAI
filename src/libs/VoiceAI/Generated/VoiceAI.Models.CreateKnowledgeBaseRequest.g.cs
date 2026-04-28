
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateKnowledgeBaseRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Documents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKnowledgeBaseRequest" /> class.
        /// </summary>
        /// <param name="documents"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKnowledgeBaseRequest(
            global::System.Collections.Generic.IList<object> documents,
            string? name,
            string? description)
        {
            this.Name = name;
            this.Description = description;
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKnowledgeBaseRequest" /> class.
        /// </summary>
        public CreateKnowledgeBaseRequest()
        {
        }
    }
}