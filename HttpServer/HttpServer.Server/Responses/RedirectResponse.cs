﻿
namespace HttpServer.Server.Responses
{
    using HttpServer.Server.Http;

    public class RedirectResponse : HttpResponse
    {
        public RedirectResponse(string locatin) 
            : base(HttpStatusCode.Found)
            => this.Headers.Add("Location", locatin);
    }
}