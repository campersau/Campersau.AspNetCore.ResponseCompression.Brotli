using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace BrotliExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseWebRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseKestrel()
                .Build();

            using (host)
            {
                host.Run();
            }
        }
    }
}
