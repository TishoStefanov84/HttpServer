namespace HttpServer.Server.Routing
{
    using HttpServer.Server.Http;
    using System;

    public interface IRoutingTable
    {
        IRoutingTable Map(HttpMethod method, string path, HttpResponse response);

        IRoutingTable Map(HttpMethod method, string path, Func<HttpRequest, HttpResponse> responseFunction);

        IRoutingTable MapGet(string path, HttpResponse response);

        IRoutingTable MapGet(string path, Func<HttpRequest, HttpResponse> responseFunction);

        IRoutingTable MapPost(string path, HttpResponse response);

        IRoutingTable MapPost(string path, Func<HttpRequest, HttpResponse> responseFunction);

        IRoutingTable MapPut(string path, HttpResponse response);

        IRoutingTable MapPut(string path, Func<HttpRequest, HttpResponse> responseFunction);

        IRoutingTable MapDelete(string path, HttpResponse response);

        IRoutingTable MapDelete(string path, Func<HttpRequest, HttpResponse> responseFunction);
    }
}
