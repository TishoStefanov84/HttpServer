namespace HttpServer.Server.Responses
{
    using HttpServer.Server.Http;

    public class BadRequestResponse : HttpResponse
    {
        public BadRequestResponse() 
            : base(HttpStatusCode.BadRequest)
        {
        }
    }
}
