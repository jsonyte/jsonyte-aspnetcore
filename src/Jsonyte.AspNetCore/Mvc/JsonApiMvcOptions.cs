using System.Text.Json;
using Jsonyte.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Jsonyte.AspNetCore.Mvc
{
    public class JsonApiMvcOptions : IConfigureOptions<MvcOptions>
    {
        private readonly ILoggerFactory loggerFactory;

        private readonly IOptions<JsonOptions> jsonOptions;

        public JsonApiMvcOptions(ILoggerFactory loggerFactory, IOptions<JsonOptions> jsonOptions)
        {
            this.loggerFactory = loggerFactory;
            this.jsonOptions = jsonOptions;
        }

        public void Configure(MvcOptions options)
        {
            var applicationOptions = Clone(jsonOptions.Value.JsonSerializerOptions);

            ConfigureInputFormatter(options, applicationOptions);
            ConfigureOutputFormatter(options, applicationOptions);
        }

        private void ConfigureInputFormatter(MvcOptions options, JsonOptions applicationOptions)
        {
            var formatter = new JsonApiInputFormatter(
                jsonOptions.Value,
                applicationOptions,
                loggerFactory.CreateLogger<SystemTextJsonInputFormatter>());

            options.InputFormatters.RemoveType<SystemTextJsonInputFormatter>();
            options.InputFormatters.Add(formatter);
        }

        private void ConfigureOutputFormatter(MvcOptions options, JsonOptions applicationOptions)
        {
            var formatter = new JsonApiOutputFormatter(
                jsonOptions.Value.JsonSerializerOptions,
                applicationOptions.JsonSerializerOptions);

            options.OutputFormatters.RemoveType<SystemTextJsonOutputFormatter>();
            options.OutputFormatters.Add(formatter);
        }

        private JsonOptions Clone(JsonSerializerOptions options)
        {
            var cloned = new JsonOptions();
            var json = cloned.JsonSerializerOptions;

            json.AllowTrailingCommas = options.AllowTrailingCommas;
            json.DefaultBufferSize = options.DefaultBufferSize;
            json.DefaultIgnoreCondition = options.DefaultIgnoreCondition;
            json.DictionaryKeyPolicy = options.DictionaryKeyPolicy;
            json.Encoder = options.Encoder;
            json.IgnoreNullValues = options.IgnoreNullValues;
            json.IgnoreReadOnlyFields = options.IgnoreReadOnlyFields;
            json.IgnoreReadOnlyProperties = options.IgnoreReadOnlyProperties;
            json.IncludeFields = options.IncludeFields;
            json.MaxDepth = options.MaxDepth;
            json.NumberHandling = options.NumberHandling;
            json.PropertyNameCaseInsensitive = options.PropertyNameCaseInsensitive;
            json.PropertyNamingPolicy = options.PropertyNamingPolicy;
            json.ReadCommentHandling = options.ReadCommentHandling;
            json.ReferenceHandler = options.ReferenceHandler;
            json.WriteIndented = options.WriteIndented;

            foreach (var converter in options.Converters)
            {
                json.Converters.Add(converter);
            }

            return cloned;
        }
    }
}
