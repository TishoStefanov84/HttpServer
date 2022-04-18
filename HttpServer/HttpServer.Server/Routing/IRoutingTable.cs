namespace HttpServer.Server.Routing
{
    using HttpServer.Server.Http;

    public interface IRoutingTable
    {
        IRoutingTable Map(HttpMethod method, string path, HttpResponse response);

        IRoutingTable MapGet(string path, HttpResponse response);
    }
}
