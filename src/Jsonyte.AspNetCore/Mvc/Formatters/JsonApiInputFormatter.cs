using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Jsonyte.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Logging;

namespace Jsonyte.AspNetCore.Mvc.Formatters
{
    public class JsonApiInputFormatter : SystemTextJsonInputFormatter
    {
        private static readonly List<string> ContentTypes = new()
        {
            MediaTypeNames.Application.JsonApi
        };

        private readonly SystemTextJsonInputFormatter jsonFormatter;

        public JsonApiInputFormatter(JsonOptions options, JsonOptions applicationOptions, ILogger<SystemTextJsonInputFormatter> logger)
            : base(options, logger)
        {
            jsonFormatter = new SystemTextJsonInputFormatter(applicationOptions, logger);

            SupportedMediaTypes.Add(MediaTypeNames.Application.JsonApi);
        }

        public override IReadOnlyList<string> GetSupportedContentTypes(string contentType, Type objectType)
        {
            return contentType == MediaTypeNames.Application.JsonApi
                ? ContentTypes
                : base.GetSupportedContentTypes(contentType, objectType);
        }

        public override Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context)
        {
            return context.HttpContext.IsJsonApiRequest()
                ? base.ReadRequestBodyAsync(context)
                : jsonFormatter.ReadRequestBodyAsync(context);
        }
    }
}
