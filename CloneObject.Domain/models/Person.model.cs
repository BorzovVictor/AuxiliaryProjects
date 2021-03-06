using System;
using CloneObject.Domain.interfaces;

namespace DeepCopyObject.models
{
    
    public class PersonCloneable : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public AddressCloneable Address { get; set; }

        public object Clone()
        {
            var person = (PersonCloneable)MemberwiseClone();
            person.Address = (AddressCloneable)Address.Clone();
            return person;
        }
    }
    
    public class PersonPrototype : IPrototype<PersonPrototype>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public AddressPrototype Address { get; set; }

        public PersonPrototype CreateDeepCopy()
        {
            var person = (PersonPrototype)MemberwiseClone();
            person.Address = Address.CreateDeepCopy();
            return person;
        }
    }
    
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