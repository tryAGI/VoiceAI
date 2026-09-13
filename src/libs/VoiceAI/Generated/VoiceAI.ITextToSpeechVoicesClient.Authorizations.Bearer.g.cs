
#nullable enable

namespace VoiceAI
{
    public partial interface ITextToSpeechVoicesClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}