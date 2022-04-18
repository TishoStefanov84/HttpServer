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
                .MapGet("/Cats", new HtmlResponse("<h1>Hello from the Cats!</h1>"))
                .MapGet("/Dogs", new HtmlResponse("<h1>Hello from the Dogs!</h1>")))
                .Start();
    }
}
