
namespace HttpServer.Server.Responses
{
    using HttpServer.Server.Http;

    public class NotFoundResponse : HttpResponse
    {
        public NotFoundResponse() 
            : base(HttpStatusCode.NotFound)
        {
        }
    }
}
