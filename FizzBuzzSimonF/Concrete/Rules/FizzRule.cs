using FizzBuzzSimonF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSimonF.Concrete.Rules
{
    public class FizzRule : IFizzBuzzRule
    {
        public bool doesApply(int value)
        {
            return value % 3 == 0;
        }

        public string getRuleOutput()
        {
            return "Fizz";
        }
    }
}
