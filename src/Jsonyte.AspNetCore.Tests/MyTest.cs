using System.Collections.Generic;
using System.Text.Json;
using Xunit;

namespace Jsonyte.AspNetCore.Tests
{
    public class MyModel
    {
        public string Name { get; set; }

        public IDictionary<string, Other> Values { get; set; }
    }

    public class Other
    {
        public string O { get; set; } = "a";
    }

    public class MyTest
    {
        [Fact]
        public void Do()
        {
            var model = new MyModel();
            model.Name = "name";
            model.Values = new Dictionary<string, Other>
            {
                {"key1", new Other()}
            };

            var options = new JsonSerializerOptions().AddJsonApi();
        }
    }
}
