
#nullable enable

namespace VoiceAI
{
    public partial interface IAgentKnowledgeBaseClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}