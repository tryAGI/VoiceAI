#nullable enable

namespace VoiceAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentPlaygroundVisibilityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::VoiceAI.AgentPlaygroundVisibility?>
    {
        /// <inheritdoc />
        public override global::VoiceAI.AgentPlaygroundVisibility? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::VoiceAI.AgentPlaygroundVisibilityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::VoiceAI.AgentPlaygroundVisibility)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::VoiceAI.AgentPlaygroundVisibility?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::VoiceAI.AgentPlaygroundVisibility? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::VoiceAI.AgentPlaygroundVisibilityExtensions.ToValueString(value.Value));
            }
        }
    }
}
