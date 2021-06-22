using System.Collections.Generic;
using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace Jsonyte.AspNetCore.Example.Models
{
    public class Article : Identifiable
    {
        [Attr]
        public string Title { get; set; }

        [HasOne]
        public Person Author { get; set; }

        [HasMany]
        public List<Tag> Tags { get; set; }
    }
}
