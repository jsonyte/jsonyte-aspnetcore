using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace Jsonyte.AspNetCore.Example.Models
{
    public class Tag : Identifiable
    {
        [Attr]
        public string Value { get; set; }
    }
}
