using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace Jsonyte.AspNetCore.Example.Models
{
    public class Person : Identifiable
    {
        [Attr]
        public string Name { get; set; }
    }
}
