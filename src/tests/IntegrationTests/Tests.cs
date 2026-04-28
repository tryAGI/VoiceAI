namespace VoiceAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static VoiceAIClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("VOICEAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("VOICEAI_API_KEY environment variable is not found.");

        var client = new VoiceAIClient(apiKey);
        
        return client;
    }
}
