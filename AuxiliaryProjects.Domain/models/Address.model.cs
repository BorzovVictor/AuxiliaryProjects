using System;
using AuxiliaryProjects.Domain.interfaces;

namespace AuxiliaryProjects.Domain.models
{
    public class AddressCloneable : ICloneable
    {
        public string City { get; set; }
        public string Street { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
    
    public class AddressPrototype : IPrototype<AddressPrototype>
    {
        public string City { get; set; }
        public string Street { get; set; }

        public AddressPrototype CreateDeepCopy()
        {
            return (AddressPrototype)MemberwiseClone();
        }
    }
    
    [Serializable]
    public class AddressForBinary
    {
        public string City { get; set; }
        public string Street { get; set; }
    }
    
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
    }
}