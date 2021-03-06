namespace HttpServer.Server.Results
{
    using HttpServer.Server.Http;
    using System.IO;
    using System.Linq;

    public class ViewResult : ActionResult
    {
        private const char PathSeparator = '/';

        public ViewResult(
            HttpResponse response,
            string viewPath, 
            string controllerName, 
            object model) 
            : base(response)
            => this.GetHtml(viewPath, controllerName, model);    

        private void GetHtml(string viewName, string controllerName, object model)
        {

            if (!viewName.Contains(PathSeparator))
            {
                viewName = controllerName + PathSeparator + viewName;
            }

            var viewPath = Path.GetFullPath("./Views/" + viewName.TrimStart(PathSeparator) + ".cshtml");

            if (!File.Exists(viewPath))
            {
                this.PrepareMissingViewError(viewPath);
                return;
            }

            var viewContent = File.ReadAllText(viewPath);

            if (model != null)
            {
                viewContent = this.PopulateModel(viewContent, model);
            }

            this.PrepareContent(viewContent, HttpContentType.Html);
        }

        private void PrepareMissingViewError(string viewPath)
        {
            this.StatusCode = HttpStatusCode.NotFound;

            var errorMessage = $"View '{viewPath}' was not found.";

            this.PrepareContent(errorMessage, HttpContentType.PlainText);
        }

        private string PopulateModel(string viewContent, object model)
        {
            var data = model
                .GetType()
                .GetProperties()
                .Select(pr => new 
                {
                    Name = pr.Name,
                    Value = pr.GetValue(model)
                });

            foreach (var entry in data)
            {
                const string openingBracets = "{{";
                const string closingBracets = "}}";

                viewContent = viewContent.Replace($"{openingBracets}{entry.Name }{closingBracets}", entry.Value.ToString());
            }

            return viewContent;
        }
    }
}
