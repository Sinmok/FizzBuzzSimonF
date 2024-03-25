using FizzBuzzSimonF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSimonF.Concrete.Rules
{

    public abstract partial class AbstractFizzBuzzRule : IFizzBuzzRule
    {

        protected string _outputText = "";
        /**
         * Check if rule applies to given value
         * Should be overridden
         */
        public abstract bool DoesApplyTo(int value);

        //Get text that should be output, if rule applies
        public string GetRuleOutput()
        {
            return _outputText;
        }
    }
}
