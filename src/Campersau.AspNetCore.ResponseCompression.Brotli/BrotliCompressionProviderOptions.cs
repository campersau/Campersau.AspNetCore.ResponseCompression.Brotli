using Microsoft.Extensions.Options;
using System.IO.Compression;

namespace Campersau.AspNetCore.ResponseCompression.Brotli
{
    public class BrotliCompressionProviderOptions : IOptions<BrotliCompressionProviderOptions>
    {
        public CompressionLevel Level { get; set; }

        BrotliCompressionProviderOptions IOptions<BrotliCompressionProviderOptions>.Value => this;
    }
}
