using System;
using System.ComponentModel.DataAnnotations;

namespace DeepCopyObject.models
{
    
    [Serializable]
    public class AddressForBinary
    {
        public string Town { get; set; }
        public string Street { get; set; }
    }
    
    public class AddressForXML
    {
        public string Town { get; set; }
        public string Street { get; set; }
    }
}