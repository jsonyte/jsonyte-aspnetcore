using Jsonyte.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Jsonyte.AspNetCore.Http
{
    public static class HttpContextExtensions
    {
        public static bool IsJsonApiRequest(this HttpContext context)
        {
            var headers = context.Request.GetTypedHeaders();

            if (headers.ContentType == null)
            {
                return true;
            }

            var mediaType = new MediaType(headers.ContentType.MediaType);

            return mediaType.IsJsonApi();
        }
    }
}
