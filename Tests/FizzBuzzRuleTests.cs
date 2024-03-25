using FizzBuzzSimonF.Concrete.Rules;
using FizzBuzzSimonF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class FizzBuzzRuleTests
    {

        private IFizzBuzzRule _fizzRule;
        private IFizzBuzzRule _buzzRule;

        [SetUp]
        public void Setup()
        {
            this._fizzRule = new FizzRule();
            this._buzzRule = new BuzzRule();
        }

        [Test]
        public void TestFizzRuleApplies()
        {
            Assert.That(this._fizzRule.AppliesTo(3), Is.EqualTo(true));
        }

        [Test]
        public void TestFizzRuleApplies2()
        {
            Assert.That(this._fizzRule.AppliesTo(6), Is.EqualTo(true));
        }


        [Test]
        public void TestFizzRuleNotApplies()
        {
            Assert.That(this._fizzRule.AppliesTo(5), Is.EqualTo(false));
        }

        [Test]
        public void TestFizzRuleNotApplies2()
        {
            Assert.That(this._fizzRule.AppliesTo(7), Is.EqualTo(false));
        }


        [Test]
        public void TestFizzRuleOutput()
        {
            Assert.That(this._fizzRule.GetRuleOutput(), Is.EqualTo("Fizz"));
        }

        /*
         * Buzz rules
         * */

        [Test]
        public void TestBuzzRuleApplies()
        {
            Assert.That(this._buzzRule.AppliesTo(5), Is.EqualTo(true));
        }

        [Test]
        public void TestBuzzRuleApplies2()
        {
            Assert.That(this._buzzRule.AppliesTo(10), Is.EqualTo(true));
        }


        [Test]
        public void TestBuzzRuleNotApplies()
        {
            Assert.That(this._buzzRule.AppliesTo(7), Is.EqualTo(false));
        }
        [Test]
        public void TestBuzzRuleNotApplies2()
        {
            Assert.That(this._buzzRule.AppliesTo(9), Is.EqualTo(false));
        }


        [Test]
        public void TestBuzzRuleOutput()
        {
            Assert.That(this._buzzRule.GetRuleOutput(), Is.EqualTo("Buzz"));
        }
    }
}
