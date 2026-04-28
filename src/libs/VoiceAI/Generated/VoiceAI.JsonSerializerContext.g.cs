
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace VoiceAI
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::VoiceAI.JsonConverters.AgentPlaygroundVisibilityJsonConverter),

            typeof(global::VoiceAI.JsonConverters.AgentPlaygroundVisibilityNullableJsonConverter),

            typeof(global::VoiceAI.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::VoiceAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.TextToSpeechGenerateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.VoiceUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.VoiceUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.VoiceUploadCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::VoiceAI.VoiceUploadListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.VoiceUploadListResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.VoiceDeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.APIKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.AgentInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.PublicAgentConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.AgentOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.AgentDeployResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.AgentDisableResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.AgentPauseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.AgentPlaygroundVisibility), TypeInfoPropertyName = "AgentPlaygroundVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.AgentStatsSummaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.AgentStatusSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.AgentStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.AllPhoneNumbersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::VoiceAI.PhoneNumberInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.PhoneNumberInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.AssignKnowledgeBaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.AvailablePhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.CallHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.ConnectionDetailsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.ConnectionDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.CreateAPIKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.CreateAPIKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.CreateAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.CreateKnowledgeBaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.DailyStat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.DashboardStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::VoiceAI.DailyStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.EndCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::VoiceAI.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.InitAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.InitAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.KnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.KnowledgeBaseWithDocuments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.ListAPIKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::VoiceAI.APIKeyResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.PaginatedAgentResponseInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::VoiceAI.AgentInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.PaginationMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.PaginatedAgentResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::VoiceAI.AgentOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.PaginatedAllPhoneNumbersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.PaginatedCallHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::VoiceAI.CallHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.PaginatedKnowledgeBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::VoiceAI.KnowledgeBaseResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.PaginatedPhoneNumberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::VoiceAI.AvailablePhoneNumber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.TTSParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.PurchasePhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.PurchasePhoneNumberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.SearchPhoneNumbersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.SearchPhoneNumbersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.TranscriptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.UpdateAPIKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.UpdateAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::VoiceAI.UpdateKnowledgeBaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::VoiceAI.VoiceUploadListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::VoiceAI.PhoneNumberInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::VoiceAI.DailyStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::VoiceAI.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::VoiceAI.APIKeyResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::VoiceAI.AgentInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::VoiceAI.AgentOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::VoiceAI.CallHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::VoiceAI.KnowledgeBaseResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::VoiceAI.AvailablePhoneNumber>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}