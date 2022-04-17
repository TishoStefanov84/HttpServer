namespace HttpServer
{
    using System.Threading.Tasks;
    using HttpServer.Server;
    using HttpServer.Server.Responses;

    public class Startup
    {
        static async Task Main()
            => await new MyServer(routes => routes
                .MapGet("/", new TextResponse("Hello from me!"))
                .MapGet("/Cats", new TextResponse("<h1>Hello from the Cats!</h1>", "text-html"))
                .MapGet("/Dogs", new TextResponse("<h1>Hello from the Dogs!</h1>", "text-html")))
                .Start();
    }
}
