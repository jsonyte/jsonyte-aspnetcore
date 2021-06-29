using Microsoft.AspNetCore.Mvc.Formatters;

namespace Jsonyte.AspNetCore.Mvc.Formatters
{
    public static class MediaTypeExtensions
    {
        private static readonly MediaType JsonApiMedia = new(MediaTypeNames.Application.JsonApi);

        public static bool IsJsonApi(this MediaType mediaType)
        {
            var isJsonApi = mediaType.Type == JsonApiMedia.Type && mediaType.SubType == JsonApiMedia.SubType;
            var isAny = mediaType.Type == "*" && mediaType.SubType == "*";

            return isJsonApi || isAny;
        }
    }
}
