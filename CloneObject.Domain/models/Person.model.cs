using System;

namespace DeepCopyObject.models
{
    
    [Serializable]
    public class PersonForBinary
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AddressForBinary Address { get; set; }
    }
    
    public class PersonForXml
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AddressForXML Address { get; set; }
    }
}