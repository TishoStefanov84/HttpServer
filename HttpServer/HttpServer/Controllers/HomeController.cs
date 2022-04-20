namespace HttpServer.Controllers
{
    using HttpServer.Server.Controllers;
    using HttpServer.Server.Http;

    public class HomeController : Controller
    {
        public HomeController(HttpRequest request) 
            : base(request)
        {
        }

        public HttpResponse Index()
            => Text("Hello from me!");

        public HttpResponse LocalRedirect()
            => Redirect("/Cats");

        public HttpResponse ToSoftUni()
            => Redirect("https://softuni.bg");
    }
}
