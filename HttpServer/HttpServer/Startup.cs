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
                .MapGet("/Cats", request =>
                {
                    const string nameKey = "Name";

                    var query = request.Query;

                    var catName = query.ContainsKey(nameKey)
                        ? query[nameKey]
                        : "the cats";

                    var result = $"<h1>Hello from {catName}!</h1>";

                    return new HtmlResponse(result);
                })
                .MapGet("/Dogs", new HtmlResponse("<h1>Hello from the Dogs!</h1>")))
                .Start();
    }
}
