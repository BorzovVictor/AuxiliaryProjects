using System;
using System.Text.Json.Serialization;

namespace DeepCopyObject.models
{
    [Serializable]
    public class PersonModel
    {
        public PersonModel()
        {
            Address = new AddressModel();
        }
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("address")]
        public AddressModel Address { get; set; }
    }
}