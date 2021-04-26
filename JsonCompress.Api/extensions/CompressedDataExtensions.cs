using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace JsonCompress.Api.extensions
{
    public static class CompressedDataExtensions
    {
        public static string Decompress(this CompressedData compressedData)
        {
            byte[] bytes = Convert.FromBase64String(compressedData.Data);
            using MemoryStream msi = new MemoryStream(bytes);
            using MemoryStream mso = new MemoryStream();
            using GZipStream gs = new GZipStream(msi, CompressionMode.Decompress);
            gs.CopyTo(mso);

            return Encoding.UTF8.GetString(mso.ToArray());
        }
    }
}