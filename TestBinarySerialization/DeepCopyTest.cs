using System.Collections.Generic;
using ComplexFaker;
using DeepCopyObject.extensions;
using DeepCopyObject.models;
using FluentAssertions;
using XMLSerialization;
using Xunit;

namespace TestBinarySerialization
{
    public class DeepCopyTest
    {
        readonly IFakeDataService faker = new FakeDataService();

        [Fact]
        public void BinaryClone_ShouldCreateDeepCopyOfObject()
        {
            PersonForBinary person = faker.GenerateComplex<PersonForBinary>();
            PersonForBinary samePerson = person;
            PersonForBinary personCopy = person.BinaryDeepClone();
            
            person.Should().NotBeSameAs(personCopy);
            person.Should().BeSameAs(samePerson);
        }
        
        [Fact]
        public void BinaryClone_ShouldCreateDeepCopyOfObjectList()
        {
            List<PersonForBinary> persons = faker.GenerateComplex<List<PersonForBinary>>();
            List<PersonForBinary> samePersons = persons;
            List<PersonForBinary> personsCopy = persons.BinaryDeepClone();
            
            persons.Should().NotBeSameAs(personsCopy);
            persons.Should().BeSameAs(samePersons);
        }
        
        [Fact]
        public void XMLClone_ShouldCreateDeepCopyOfObject()
        {
            PersonForXml person = faker.GenerateComplex<PersonForXml>();
            PersonForXml samePerson = person;
            PersonForXml personCopy = person.XMLDeepClone();
            
            person.Should().NotBeSameAs(personCopy);
            person.Should().BeSameAs(samePerson);
        }
        
        [Fact]
        public void XMLClone_ShouldCreateDeepCopyOfObjectList()
        {
            List<PersonForXml> person = faker.GenerateComplex<List<PersonForXml>>();
            List<PersonForXml> samePerson = person;
            List<PersonForXml> personCopy = person.XMLDeepClone();
            
            person.Should().NotBeSameAs(personCopy);
            person.Should().BeSameAs(samePerson);
        }
        
        [Fact]
        public void ICloneable_ShouldCreateDeepCopyOfObject_WithCast()
        {
            PersonCloneable person = faker.GenerateComplex<PersonCloneable>();
            PersonCloneable samePerson = person;
            PersonCloneable personCopy = person.Clone() as PersonCloneable;
            
            person.Should().NotBeSameAs(personCopy);
            person.Should().BeSameAs(samePerson);
        }
        
        [Fact]
        public void IPrototype_ShouldCreateDeepCopyOfObject_WithoutCast()
        {
            PersonPrototype person = faker.GenerateComplex<PersonPrototype>();
            PersonPrototype samePerson = person;
            PersonPrototype personCopy = person.CreateDeepCopy();
            
            person.Should().NotBeSameAs(personCopy);
            person.Should().BeSameAs(samePerson);
        }
    }
}