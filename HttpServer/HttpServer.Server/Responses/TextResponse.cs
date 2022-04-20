namespace HttpServer.Server.Responses
{
    using HttpServer.Server.Http;

    public class TextResponse : ContentResponse
    {
        public TextResponse(string text)
            : base(text, HttpContentType.PlainText)
        {
        }
    }
}
