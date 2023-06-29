using System;

namespace TDAmeritrade
{
    /// <summary>
    /// An HTTP client wrapper for interacting with TD Ameritrade's API.
    /// </summary>
    public interface ITDAmeritradeClient
    {
        /// <summary>
        /// Gets or sets the path to the API resource.
        /// </summary>
        string UrlPath { get; set; }

        /// <summary>
        /// Gets or sets the API version.
        /// </summary>
        string Version { get; set; }
    }
}
