using MediaBrowser.Common.Json;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;

namespace Jellyfin.Server.Formatters
{
    /// <summary>
    /// Pascal Case Json Profile Formatter.
    /// </summary>
    public class PascalCaseJsonProfileFormatter : SystemTextJsonOutputFormatter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PascalCaseJsonProfileFormatter"/> class.
        /// </summary>
        public PascalCaseJsonProfileFormatter() : base(JsonDefaults.GetPascalCaseOptions())
        {
            SupportedMediaTypes.Clear();
            // Add application/json for default formatter
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("application/json"));
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("application/json;profile=\"PascalCase\""));
        }
    }
}
