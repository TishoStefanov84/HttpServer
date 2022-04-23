namespace HttpServer.Server.Results
{
    using HttpServer.Server.Http;

    public class BadRequestResult : HttpResponse
    {
        public BadRequestResult() 
            : base(HttpStatusCode.BadRequest)
        {
        }
    }
}
