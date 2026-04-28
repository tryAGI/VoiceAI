
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceUploadRequest
    {
        /// <summary>
        /// The name of the voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the voice is public or private
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Relevant tags for the voice e.g. Male, Female, Calm, Funny
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceTags")]
        public global::System.Collections.Generic.IList<string>? VoiceTags { get; set; }

        /// <summary>
        /// A base64 encoded audio sample
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceUploadRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the voice
        /// </param>
        /// <param name="type">
        /// Whether the voice is public or private
        /// </param>
        /// <param name="audio">
        /// A base64 encoded audio sample
        /// </param>
        /// <param name="description">
        /// A description of the voice
        /// </param>
        /// <param name="voiceTags">
        /// Relevant tags for the voice e.g. Male, Female, Calm, Funny
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceUploadRequest(
            string name,
            string type,
            string audio,
            string? description,
            global::System.Collections.Generic.IList<string>? voiceTags)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.VoiceTags = voiceTags;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceUploadRequest" /> class.
        /// </summary>
        public VoiceUploadRequest()
        {
        }
    }
}