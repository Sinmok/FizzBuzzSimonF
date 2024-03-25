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

        //Not strictly speaking needed, but demos clean design by being able to swap out one implementation for another
        private IFizzBuzzRule _customRuleFizz;
        private IFizzBuzzRule _customRuleBuzz;

        //Just to test other rules if we wanted them!
        private IFizzBuzzRule _bazzRule;


        [SetUp]
        public void Setup()
        {
            this._fizzRule = new FizzRule();
            this._buzzRule = new BuzzRule();            
            
            this._customRuleFizz = new CustomFizzBuzzRule(3,"Fizz");
            this._customRuleBuzz = new CustomFizzBuzzRule(5,"Buzz");

            this._bazzRule = new CustomFizzBuzzRule(2, "Bazz");
        }

        [Test]
        public void TestFizzRuleApplies()
        {
            Assert.That(this._fizzRule.DoesApplyTo(3), Is.EqualTo(true));
        }

        [Test]
        public void TestFizzRuleApplies2()
        {
            Assert.That(this._fizzRule.DoesApplyTo(6), Is.EqualTo(true));
        }


        [Test]
        public void TestFizzRuleNotApplies()
        {
            Assert.That(this._fizzRule.DoesApplyTo(5), Is.EqualTo(false));
        }

        [Test]
        public void TestFizzRuleNotApplies2()
        {
            Assert.That(this._fizzRule.DoesApplyTo(7), Is.EqualTo(false));
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
            Assert.That(this._buzzRule.DoesApplyTo(5), Is.EqualTo(true));
        }

        [Test]
        public void TestBuzzRuleApplies2()
        {
            Assert.That(this._buzzRule.DoesApplyTo(10), Is.EqualTo(true));
        }


        [Test]
        public void TestBuzzRuleNotApplies()
        {
            Assert.That(this._buzzRule.DoesApplyTo(7), Is.EqualTo(false));
        }
        [Test]
        public void TestBuzzRuleNotApplies2()
        {
            Assert.That(this._buzzRule.DoesApplyTo(9), Is.EqualTo(false));
        }


        [Test]
        public void TestBuzzRuleOutput()
        {
            Assert.That(this._buzzRule.GetRuleOutput(), Is.EqualTo("Buzz"));
        }



        //region test custom rules against IFizzBuzzRule
        [Test]
        public void TestCustomFizzRuleApplies()
        {
            Assert.That(this._customRuleFizz.DoesApplyTo(3), Is.EqualTo(true));
        }

        [Test]
        public void TestCustomFizzRuleNotApplies()
        {
            Assert.That(this._customRuleFizz.DoesApplyTo(7), Is.EqualTo(false));
        }

        [Test]
        public void TestCustomFizzRuleOutput()
        {
            Assert.That(this._customRuleFizz.GetRuleOutput(), Is.EqualTo("Fizz"));
        }

        [Test]
        public void TestCustomBuzzRuleApplies()
        {
            Assert.That(this._customRuleBuzz.DoesApplyTo(5), Is.EqualTo(true));
        }

        [Test]
        public void TestCustomBuzzRuleNotApplies()
        {
            Assert.That(this._customRuleBuzz.DoesApplyTo(3), Is.EqualTo(false));
        }

        [Test]
        public void TestCustomBuzzRuleOutput()
        {
            Assert.That(this._customRuleBuzz.GetRuleOutput(), Is.EqualTo("Buzz"));
        }


        //Test different rules
        [Test]
        public void TestCustomBazzRuleApplies()
        {
            Assert.That(this._bazzRule.DoesApplyTo(2), Is.EqualTo(true));
        }


        [Test]
        public void TestCustomBazzRuleNotApplies()
        {
            Assert.That(this._bazzRule.DoesApplyTo(7), Is.EqualTo(false));
        }

        [Test]
        public void TestCustomBazzRule()
        {
            Assert.That(this._bazzRule.GetRuleOutput(), Is.EqualTo("Bazz"));
        }
    }
}
