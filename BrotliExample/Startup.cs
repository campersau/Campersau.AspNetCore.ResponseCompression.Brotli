using Campersau.AspNetCore.ResponseCompression.Brotli;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO.Compression;

namespace BrotliExample
{
    public class Startup
    {
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddResponseCompression(o =>
            {
                o.Providers.Add(typeof(BrotliCompressionProvider));
            });

            services.Configure<BrotliCompressionProviderOptions>(o =>
            {
                o.Level = CompressionLevel.Optimal;
            });

            return services.BuildServiceProvider();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseResponseCompression();

            app.UseStaticFiles();
        }
    }
}
