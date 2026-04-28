
#nullable enable

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentPlaygroundVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Unlisted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentPlaygroundVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPlaygroundVisibility value)
        {
            return value switch
            {
                AgentPlaygroundVisibility.Public => "public",
                AgentPlaygroundVisibility.Unlisted => "unlisted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPlaygroundVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => AgentPlaygroundVisibility.Public,
                "unlisted" => AgentPlaygroundVisibility.Unlisted,
                _ => null,
            };
        }
    }
}