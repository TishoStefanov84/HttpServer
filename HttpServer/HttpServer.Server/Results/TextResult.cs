namespace HttpServer.Server.Results
{
    using HttpServer.Server.Http;

    public class TextResult : ContentResult
    {
        public TextResult(HttpResponse response,string text)
            : base(response, text, HttpContentType.PlainText)
        {
        }
    }
}
