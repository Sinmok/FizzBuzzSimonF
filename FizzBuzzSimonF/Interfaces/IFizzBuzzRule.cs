using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSimonF.Interfaces
{
    public interface IFizzBuzzRule
    {
        /**
         * Returns the string that should be output, should doesApply() return true
         */
        public string GetRuleOutput();

        /**
         * Checks if the given value applies to this rule
         */
        public bool AppliesTo(int value);
    }
}
