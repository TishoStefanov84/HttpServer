namespace HttpServer
{
    using System.Threading.Tasks;
    using HttpServer.Controllers;
    using HttpServer.Server;
    using HttpServer.Server.Controllers;

    public class Startup
    {
        static async Task Main()
            => await new MyServer(routes => routes
                .MapGet<HomeController>("/", c => c.Index())
                .MapGet<AnimalsController>("/Cats", c => c.Cats())
                .MapGet<AnimalsController>("/Dogs", c => c.Dogs()))
                .Start();
    }
}
