
namespace HttpServer.Server.Responses
{
    using HttpServer.Server.Common;
    using HttpServer.Server.Http;
    using System.Text;

    public class ContentResponse : HttpResponse
    {
        public ContentResponse(string content, string contentType)
            : base(HttpStatusCode.OK)
            => this.PrepareContent(content, contentType);
    }
}
