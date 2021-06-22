using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Jsonyte.AspNetCore.Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(x => x.UseStartup<Startup>())
                .Build()
                .Start();
        }
    }
}
