using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Jsonyte.AspNetCore.Mvc.Formatters
{
    public class JsonApiOutputFormatter : SystemTextJsonOutputFormatter
    {
        private static readonly List<string> ContentTypes = new()
        {
            MediaTypeNames.Application.JsonApi
        };

        private readonly SystemTextJsonOutputFormatter jsonFormatter;

        public JsonApiOutputFormatter(JsonSerializerOptions jsonSerializerOptions, JsonSerializerOptions applicationOptions)
            : base(jsonSerializerOptions)
        {
            jsonFormatter = new SystemTextJsonOutputFormatter(applicationOptions);

            SupportedMediaTypes.Add(MediaTypeNames.Application.JsonApi);
        }

        public override IReadOnlyList<string> GetSupportedContentTypes(string contentType, Type objectType)
        {
            return contentType == MediaTypeNames.Application.JsonApi
                ? ContentTypes
                : base.GetSupportedContentTypes(contentType, objectType);
        }

        public override bool CanWriteResult(OutputFormatterCanWriteContext context)
        {
            if (!context.ContentType.HasValue)
            {
                context.ContentType = MediaTypeNames.Application.JsonApi;

                return true;
            }

            return base.CanWriteResult(context);
        }

        public override void WriteResponseHeaders(OutputFormatterWriteContext context)
        {
            base.WriteResponseHeaders(context);

            var mediaType = new MediaType(context.ContentType);

            if (mediaType.IsJsonApi())
            {
                context.ContentType = MediaTypeNames.Application.JsonApi;
                context.HttpContext.Response.ContentType = MediaTypeNames.Application.JsonApi;
            }
        }

        public override Task WriteAsync(OutputFormatterWriteContext context)
        {
            var mediaType = new MediaType(context.ContentType);

            if (mediaType.IsJsonApi())
            {
                return base.WriteAsync(context);
            }

            return jsonFormatter.WriteAsync(context);
        }
    }
}
