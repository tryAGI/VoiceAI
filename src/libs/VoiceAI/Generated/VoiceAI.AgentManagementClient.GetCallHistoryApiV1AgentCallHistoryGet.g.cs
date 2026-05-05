
#nullable enable

namespace VoiceAI
{
    public partial class AgentManagementClient
    {


        private static readonly global::VoiceAI.EndPointSecurityRequirement s_GetCallHistoryApiV1AgentCallHistoryGetSecurityRequirement0 =
            new global::VoiceAI.EndPointSecurityRequirement
            {
                Authorizations = new global::VoiceAI.EndPointAuthorizationRequirement[]
                {                    new global::VoiceAI.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::VoiceAI.EndPointSecurityRequirement[] s_GetCallHistoryApiV1AgentCallHistoryGetSecurityRequirements =
            new global::VoiceAI.EndPointSecurityRequirement[]
            {                s_GetCallHistoryApiV1AgentCallHistoryGetSecurityRequirement0,
            };
        partial void PrepareGetCallHistoryApiV1AgentCallHistoryGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? page,
            ref int? limit,
            ref string? startDate,
            ref string? endDate,
            ref string? agentId);
        partial void PrepareGetCallHistoryApiV1AgentCallHistoryGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? page,
            int? limit,
            string? startDate,
            string? endDate,
            string? agentId);
        partial void ProcessGetCallHistoryApiV1AgentCallHistoryGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetCallHistoryApiV1AgentCallHistoryGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Call History<br/>
        /// Retrieve detailed call logs.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="startDate">
        /// Filter calls after this date (ISO format UTC, e.g., 2024-01-01T00:00:00+00:00)
        /// </param>
        /// <param name="endDate">
        /// Filter calls before this date (ISO format UTC, e.g., 2024-12-31T23:59:59+00:00)
        /// </param>
        /// <param name="agentId">
        /// Filter calls by specific agent ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::VoiceAI.PaginatedCallHistoryResponse> GetCallHistoryApiV1AgentCallHistoryGetAsync(
            int? page = default,
            int? limit = default,
            string? startDate = default,
            string? endDate = default,
            string? agentId = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetCallHistoryApiV1AgentCallHistoryGetAsResponseAsync(
                page: page,
                limit: limit,
                startDate: startDate,
                endDate: endDate,
                agentId: agentId,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Call History<br/>
        /// Retrieve detailed call logs.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="startDate">
        /// Filter calls after this date (ISO format UTC, e.g., 2024-01-01T00:00:00+00:00)
        /// </param>
        /// <param name="endDate">
        /// Filter calls before this date (ISO format UTC, e.g., 2024-12-31T23:59:59+00:00)
        /// </param>
        /// <param name="agentId">
        /// Filter calls by specific agent ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::VoiceAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::VoiceAI.AutoSDKHttpResponse<global::VoiceAI.PaginatedCallHistoryResponse>> GetCallHistoryApiV1AgentCallHistoryGetAsResponseAsync(
            int? page = default,
            int? limit = default,
            string? startDate = default,
            string? endDate = default,
            string? agentId = default,
            global::VoiceAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetCallHistoryApiV1AgentCallHistoryGetArguments(
                httpClient: HttpClient,
                page: ref page,
                limit: ref limit,
                startDate: ref startDate,
                endDate: ref endDate,
                agentId: ref agentId);


            var __authorizations = global::VoiceAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetCallHistoryApiV1AgentCallHistoryGetSecurityRequirements,
                operationName: "GetCallHistoryApiV1AgentCallHistoryGetAsync");

            using var __timeoutCancellationTokenSource = global::VoiceAI.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::VoiceAI.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::VoiceAI.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::VoiceAI.PathBuilder(
                                path: "/agent/v1/agent/call-history",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("page", page?.ToString())
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("start_date", startDate)
                                .AddOptionalParameter("end_date", endDate)
                                .AddOptionalParameter("agent_id", agentId)
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::VoiceAI.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                global::VoiceAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetCallHistoryApiV1AgentCallHistoryGetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    page: page,
                    limit: limit,
                    startDate: startDate,
                    endDate: endDate,
                    agentId: agentId);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::VoiceAI.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::VoiceAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetCallHistoryApiV1AgentCallHistoryGet",
                                methodName: "GetCallHistoryApiV1AgentCallHistoryGetAsync",
                                pathTemplate: "\"/agent/v1/agent/call-history\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::VoiceAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::VoiceAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::VoiceAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetCallHistoryApiV1AgentCallHistoryGet",
                                methodName: "GetCallHistoryApiV1AgentCallHistoryGetAsync",
                                pathTemplate: "\"/agent/v1/agent/call-history\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::VoiceAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::VoiceAI.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::VoiceAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::VoiceAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::VoiceAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetCallHistoryApiV1AgentCallHistoryGet",
                                methodName: "GetCallHistoryApiV1AgentCallHistoryGetAsync",
                                pathTemplate: "\"/agent/v1/agent/call-history\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::VoiceAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessGetCallHistoryApiV1AgentCallHistoryGetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::VoiceAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::VoiceAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetCallHistoryApiV1AgentCallHistoryGet",
                                methodName: "GetCallHistoryApiV1AgentCallHistoryGetAsync",
                                pathTemplate: "\"/agent/v1/agent/call-history\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::VoiceAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::VoiceAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetCallHistoryApiV1AgentCallHistoryGet",
                                methodName: "GetCallHistoryApiV1AgentCallHistoryGetAsync",
                                pathTemplate: "\"/agent/v1/agent/call-history\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Validation Error
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::VoiceAI.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::VoiceAI.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::VoiceAI.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }

                                throw new global::VoiceAI.ApiException<global::VoiceAI.HTTPValidationError>(
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_422,
                                    ResponseObject = __value_422,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessGetCallHistoryApiV1AgentCallHistoryGetResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::VoiceAI.PaginatedCallHistoryResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::VoiceAI.AutoSDKHttpResponse<global::VoiceAI.PaginatedCallHistoryResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::VoiceAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::VoiceAI.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::VoiceAI.PaginatedCallHistoryResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::VoiceAI.AutoSDKHttpResponse<global::VoiceAI.PaginatedCallHistoryResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::VoiceAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::VoiceAI.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}