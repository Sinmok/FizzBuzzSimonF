using FizzBuzzSimonF.Attributes;
using FizzBuzzSimonF.Concrete;
using FizzBuzzSimonF.GameFinder;
using FizzBuzzSimonF.Interfaces;

namespace Tests
{
    public class ReflectionTests
    {
        private IFizzBuzzAttribute _attribute;


        [SetUp]
        public void Setup()
        {
            _attribute = new FizzBuzzAttribute();
        }


        [Test]
        public void DoesAttributeMatch()
        {

            Assert.That(_attribute.DoesImplementFizzBuzz(typeof(FizzBuzzGame)), Is.EqualTo(true));
        }

        [Test]
        public void DoesAttributeNotMatch()
        {

            Assert.That(_attribute.DoesImplementFizzBuzz(typeof(string)), Is.EqualTo(false));
        }

        [Test]
        public void TestGameFinder()
        {
            Assert.IsTrue(GameFinder.FindFizzBuzzGame() is IFizzBuzzGame);

        }
    }
}