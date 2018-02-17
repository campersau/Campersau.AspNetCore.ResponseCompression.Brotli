using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.IO.Compression;

namespace Campersau.AspNetCore.ResponseCompression.Brotli
{
    public class BrotliCompressionProvider : ICompressionProvider
    {
        public BrotliCompressionProvider(IOptions<BrotliCompressionProviderOptions> options)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            Options = options.Value;
        }

        private BrotliCompressionProviderOptions Options { get; }

        public string EncodingName => "br";

        public bool SupportsFlush => true;

        public Stream CreateStream(Stream outputStream)
        {
            return new BrotliStream(outputStream, CompressionMode.Compress, leaveOpen: true, bufferSize: 65520, quality: Options.Level);
        }
    }
}
