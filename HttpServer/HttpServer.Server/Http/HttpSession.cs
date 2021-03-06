namespace HttpServer.Server.Http
{
    using HttpServer.Server.Common;
    using System.Collections.Generic;

    public class HttpSession
    {
        public const string SessionCookieName = "MyWebServerSID";

        private Dictionary<string, string> data;

        public HttpSession(string id)
        {
            Guard.AgainstNull(id, nameof(id));

            this.Id = id;
            this.data = new Dictionary<string, string>();
        }

        public string Id { get; init; }


        public string this[string key]
        {
            get => this.data[key];
            set => this.data[key] = value;
        }

        public int Count() => this.data.Count;

        public bool ContainsKey(string key)
            => this.data.ContainsKey(key);


    }
}
