namespace HttpServer.Server.Controllers
{
    using System;
    using HttpServer.Server.Http;
    using HttpServer.Server.Routing;

    public static class RoutingTableExtensions
    {

        public static IRoutingTable MapGet<TController>(
            this IRoutingTable routingTable,
            string path,
            Func<TController, HttpResponse> controllerFunction)
            where TController : Controller
            => routingTable.MapGet(path, request
            => controllerFunction(CreateController<TController>(request)));

        public static IRoutingTable MapPost<TController>(
            this IRoutingTable routingTable,
            string path,
            Func<TController, HttpResponse> controllerFunction)
            where TController : Controller
            => routingTable.MapPost(path, request
            => controllerFunction(CreateController<TController>(request)));

        public static IRoutingTable MapPut<TController>(
            this IRoutingTable routingTable,
            string path,
            Func<TController, HttpResponse> controllerFunction)
            where TController : Controller
            => routingTable.MapPut(path, request
            => controllerFunction(CreateController<TController>(request)));

        public static IRoutingTable MapDelete<TController>(
            this IRoutingTable routingTable,
            string path,
            Func<TController, HttpResponse> controllerFunction)
            where TController : Controller
            => routingTable.MapDelete(path, request
            => controllerFunction(CreateController<TController>(request)));

        private static TController CreateController<TController>(HttpRequest request)
            => (TController)Activator
                .CreateInstance(typeof(TController), new[] { request });
    }
}