using System;
using System.Text.Json.Serialization;

namespace DeepCopyObject.models
{
    [Serializable]
    public class AddressModel
    {
        [JsonPropertyName("city")]
        public string Town { get; set; }
        [JsonPropertyName("street")]
        public string Street { get; set; }
    }
}