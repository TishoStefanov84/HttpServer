namespace HttpServer
{
    using System.Threading.Tasks;
    using HttpServer.Server;

    public class Startup
    {
        static async Task Main()
        {
            var server = new MyServer("127.0.0.1", 8080);

            await server.Start();
        }
    }
}
