
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceUploadListResponseItem
    {
        /// <summary>
        /// The ID of the voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The voice description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The current status of the voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Whether your voice can be used for Agents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isAgentSearchable")]
        public bool? IsAgentSearchable { get; set; }

        /// <summary>
        /// Tags applied to this voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceUploadListResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the voice
        /// </param>
        /// <param name="name">
        /// The name of the voice
        /// </param>
        /// <param name="description">
        /// The voice description
        /// </param>
        /// <param name="status">
        /// The current status of the voice
        /// </param>
        /// <param name="isAgentSearchable">
        /// Whether your voice can be used for Agents
        /// </param>
        /// <param name="tags">
        /// Tags applied to this voice
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceUploadListResponseItem(
            string? id,
            string? name,
            string? description,
            string? status,
            bool? isAgentSearchable,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Status = status;
            this.IsAgentSearchable = isAgentSearchable;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceUploadListResponseItem" /> class.
        /// </summary>
        public VoiceUploadListResponseItem()
        {
        }
    }
}