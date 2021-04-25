using ComplexFaker;
using DeepCopyObject.extensions;
using DeepCopyObject.models;
using FluentAssertions;
using Xunit;

namespace TestBinarySerialization
{
    public class DeepCopyTest
    {
        readonly IFakeDataService faker = new FakeDataService();

        [Fact]
        public void ShouldCreateDeepCopyOfObject()
        {
            PersonModel person = faker.GenerateComplex<PersonModel>();
            PersonModel samePerson = person;
            PersonModel personCopy = person.DeepCopy();

            person.Should().NotBeEquivalentTo(personCopy);
            person.Should().BeEquivalentTo(samePerson);
        }
    }
}