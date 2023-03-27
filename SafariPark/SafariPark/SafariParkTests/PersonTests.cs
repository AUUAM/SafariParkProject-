using System.Xml.Linq;

namespace SafariParkTests
{
    public class PersonTests
    {


        [TestCase("Alex", "Blunt", "Alex Blunt")]
        [TestCase("", "", " ")]
        public void GetFullName(string fName, string lName, string expected)
        {
            Person subject = new Person(fName, lName);
            string actual = subject.GetFullName();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AgeTest()
        {
            Person subject = new Person("A", "B");
            subject.Age = 35;
            Assert.That(subject.Age, Is.EqualTo(35));
        }

        [Test]
        public void AgeLessThanZero_ThrowException()
        {
            Person subject = new Person("A", "B");
            
            Assert.That(() => subject.Age = -1, Throws.TypeOf<ArgumentException>().With.Message.Contain("Age cannot be less than 0"));
        }
    }
}