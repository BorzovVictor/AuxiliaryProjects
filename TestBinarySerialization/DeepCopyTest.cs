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
        public void BinarySerialization_ShouldCreateDeepCopyOfObject()
        {
            PersonForBinary person = faker.GenerateComplex<PersonForBinary>();
            PersonForBinary samePerson = person;
            PersonForBinary personCopy = person.BinaryDeepCopy();
            
            person.Should().NotBeSameAs(personCopy);
            person.Should().BeSameAs(samePerson);
        }
        
        [Fact]
        public void XMLSerialization_ShouldCreateDeepCopyOfObject()
        {
            PersonForXml person = faker.GenerateComplex<PersonForXml>();
            PersonForXml samePerson = person;
            PersonForXml personCopy = person.XMLDeepCopy();
            
            person.Should().NotBeSameAs(personCopy);
            person.Should().BeSameAs(samePerson);
        }
    }
}