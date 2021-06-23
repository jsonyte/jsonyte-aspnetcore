using System.Collections.Generic;

namespace Jsonyte.AspNetCore.Example.Models
{
    public class Article
    {
        public string Title { get; set; }

        public Person Author { get; set; }

        public List<Tag> Tags { get; set; }
    }
}
