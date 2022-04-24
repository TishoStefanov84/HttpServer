namespace HttpServer.Controllers
{
    using HttpServer.Server.Controllers;
    using HttpServer.Server.Http;
    using System;

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

        public HttpResponse Error()
            => throw new InvalidOperationException("Invalid action!");
    }
}
