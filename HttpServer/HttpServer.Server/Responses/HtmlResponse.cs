namespace HttpServer.Server.Responses
{
    using HttpServer.Server.Http;

    public class HtmlResponse : ContentResponse
    {
        public HtmlResponse(string html) 
            : base(html, HttpContentType.Html)
        {
        }
    }
}
