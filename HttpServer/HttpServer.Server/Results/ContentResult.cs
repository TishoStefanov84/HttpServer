namespace HttpServer.Server.Results
{
    using HttpServer.Server.Http;

    public class ContentResult : ActionResult
    {
        public ContentResult(
            HttpResponse response,
            string content, 
            string contentType)
            : base(response)
            => this.PrepareContent(content, contentType);
    }
}
