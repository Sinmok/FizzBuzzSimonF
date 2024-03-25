using FizzBuzzSimonF.Concrete.Rules;
using FizzBuzzSimonF.Concrete;
using FizzBuzzSimonF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class FizzBuzzGameTests
    {
        private IFizzBuzzGame game;
        private List<IFizzBuzzRule> _rules;


        [SetUp]
        public void Setup()

        {
            this.game = new FizzBuzzGame();

            this._rules = new List<IFizzBuzzRule>()
            {
                new FizzRule(),
                new BuzzRule(),
            };
        }


        [Test]
        public void TestFizz()
        {
            var range = new List<int>() { 3 };
            Assert.That(this.game.Run(range, this._rules).First(), Is.EqualTo("Fizz"));
        }


        [Test]
        public void TestBuzz()
        {
            var range = new List<int>() { 5 };
            Assert.That(this.game.Run(range, this._rules).First(), Is.EqualTo("Buzz"));
        }


        [Test]
        public void TestFizzBuzz()
        {
            var range = new List<int>() { 15 };
            Assert.That(this.game.Run(range, this._rules).First(), Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void TestNotFizz()
        {
            var range = new List<int>() { 1 };
            Assert.That(this.game.Run(range, this._rules).First(), Is.Not.EqualTo("Fizz"));
        }


        [Test]
        public void TestNotBuzz()
        {
            var range = new List<int>() { 1 };

            Assert.That(this.game.Run(range, this._rules).First(), Is.Not.EqualTo("Buzz"));

        }

        [Test]
        public void TestNumberOutput()
        {
            var range = new List<int>() { 14 };

            Assert.That(this.game.Run(range, this._rules).First(), Is.EqualTo("14"));

        }



    }
}
