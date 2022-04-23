﻿namespace HttpServer.Server.Results
{
    using HttpServer.Server.Http;

    public class NotFoundResult : ActionResult
    {
        public NotFoundResult(HttpResponse response) 
            : base(response)
            => this.StatusCode = HttpStatusCode.NotFound;
       
    }
}
