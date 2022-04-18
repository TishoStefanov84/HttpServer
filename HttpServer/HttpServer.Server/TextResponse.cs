using HttpServer.Server.Http;

namespace HttpServer.Server
{
    internal class TextResponse : HttpResponse
    {
        private string text;

        public TextResponse(string text)
        {
            this.text = text;
        }
    }
}