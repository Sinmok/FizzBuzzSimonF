using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSimonF.Concrete.Rules
{
    public class CustomFizzBuzzRule : AbstractFizzBuzzRule
    {
        private int _rule;

        public CustomFizzBuzzRule(int rule, string outputText)
        {
            _rule = rule;
            this._outputText = outputText;
        }

        public override bool DoesApplyTo(int value)
        {
            return value % _rule == 0;
        }
    }
}
