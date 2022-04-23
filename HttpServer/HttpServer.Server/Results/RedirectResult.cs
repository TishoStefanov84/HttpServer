namespace HttpServer.Server.Results
{
    using HttpServer.Server.Http;

    public class RedirectResult : ActionResult
    {
        public RedirectResult(HttpResponse response, string locatin) 
            : base(response)
        {
            this.StatusCode = HttpStatusCode.Found;

            this.AddHeader (HttpHeader.Location, locatin);
        }
    }
}
