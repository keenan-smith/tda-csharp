using System;

namespace TDAmeritrade
{
    /// <summary>
    /// Defines the options to use with the client.
    /// </summary>
    public class BaseClientOptions
    {
        /// <summary>
        /// The base URL.
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// The API version (defaults to "TD").
        /// </summary>
        public string Version { get; set; } = "TD";

        /// <summary>
        /// The path to the API endpoint.
        /// </summary>
        public string UrlPath { get; set; }
    }
}
