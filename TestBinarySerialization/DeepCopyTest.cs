using ComplexFaker;
using DeepCopyObject.extensions;
using DeepCopyObject.models;
using Xunit;

namespace TestBinarySerialization
{
    public class DeepCopyTest
    {
        IFakeDataService faker = new FakeDataService();

        [Fact]
        public void ShouldCreateDeepCopyOfObject()
        {
            PersonModel person = faker.GenerateComplex<PersonModel>();
            PersonModel samePerson = person;
            PersonModel personCopy = person.DeepCopy();

            Assert.Equal(person, samePerson);
            Assert.NotEqual(person, personCopy);
        }
    }
}