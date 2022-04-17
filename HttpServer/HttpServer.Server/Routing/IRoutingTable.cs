namespace HttpServer.Server.Routing
{
    using HttpServer.Server.Http;

    public interface IRoutingTable
    {
        IRoutingTable Map(string url, HttpMethod method, HttpResponse response);

        IRoutingTable MapGet(string url, HttpResponse response);
    }
}
