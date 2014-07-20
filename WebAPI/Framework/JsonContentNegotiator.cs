using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web;

namespace WebAPI.Framework
{
    /// <summary>
    /// Json content negotiator.
    /// </summary>
    public class JsonContentNegotiator : IContentNegotiator
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly JsonMediaTypeFormatter _jsonFormatter;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formatter"></param>
        public JsonContentNegotiator(JsonMediaTypeFormatter formatter)
        {
            _jsonFormatter = formatter;
        }

        /// <summary>
        /// Always return json.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="request"></param>
        /// <param name="formatters"></param>
        /// <returns></returns>
        public ContentNegotiationResult Negotiate(Type type, HttpRequestMessage request, IEnumerable<MediaTypeFormatter> formatters)
        {
            var result = new ContentNegotiationResult(_jsonFormatter, new MediaTypeHeaderValue("application/json"));
            return result;
        }
    }
}