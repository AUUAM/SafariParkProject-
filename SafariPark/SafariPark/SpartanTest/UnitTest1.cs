
namespace SpartanTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AgeLessThanZero_ThrowException()
        {
            Spartan subject = new Spartan();
            subject.FullName = "Cormac Smith";

            Assert.That(() => subject.Age = -1, Throws.TypeOf<ArgumentException>().With.Message.Contains("Age cannot be less than 0"));
        }

        [TestCase(-1)]
        [TestCase(101)]
        public void SpartanScoreLessThanZero_GreaterThan100_ThrowException(int score)
        {
            Spartan subject = new Spartan();
            subject.FullName = "Cormac Smith";
            subject.SpartanScore = 100;

            Assert.That(() => subject.SpartanScore = score, Throws.TypeOf<ArgumentException>().With.Message.Contains("Score cannot be less than 0 or greater than 100"));
        }
    }
}
