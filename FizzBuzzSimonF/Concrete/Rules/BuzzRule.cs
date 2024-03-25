using FizzBuzzSimonF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSimonF.Concrete.Rules
{
    public class BuzzRule : IFizzBuzzRule
    {
        public bool doesApply(int value)
        {
            return value % 5 == 0;
        }

        public string getRuleOutput()
        {
            return "Buzz";
        }
    }
}
