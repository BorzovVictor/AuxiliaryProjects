using System.Text.Json;
using System.Threading.Tasks;
using AuxiliaryProjects.Core.models;
using JsonCompress.Api.extensions;
using Microsoft.AspNetCore.Mvc;

namespace JsonCompress.Api.Controllers
{
    public class JsonDecompressController: ControllerBase
    {
        [HttpPost]
        public async Task<Person> DecompressData(CompressedData compressedData)
        {
            var request = JsonSerializer.Deserialize<Person>(compressedData.Decompress());
            request.Name = "modified Name";

            return request;
        }
    }
}