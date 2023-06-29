using System;
using System.Net.Http;
using System.Reflection;

namespace TDAmeritrade
{
    /// <summary>
    /// The base interface for interacting with TD Ameritrade's API.
    /// </summary>
    public abstract class BaseClient : ITDAmeritradeClient
    {
        private const string ContentType = "Content-Type";
        private const string DefaultMediaType = "application/json";

        /// <summary>
        /// The client assembly version to send in request User-Agent header.
        /// </summary>
        private static readonly string ClientVersion = typeof(BaseClient).GetTypeInfo().Assembly.GetName().Version.ToString();

        /// <summary>
        /// The configuration to use with current client instance.
        /// </summary>
        private readonly BaseClientOptions options;

        /// <summary>
        /// The HttpClient instance to use for all calls from this client instance.
        /// </summary>
        private readonly HttpClient client;

        /// <summary>
        /// The path to the API resource.
        /// </summary>
        public string UrlPath
        {
            get => this.options.UrlPath;
            set => this.options.UrlPath = value;
        }

        /// <summary>
        /// The API version.
        /// </summary>
        public string Version
        {
            get => this.options.Version;
            set => this.options.Version = value;
        }
    }
}
