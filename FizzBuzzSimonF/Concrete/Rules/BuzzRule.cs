using FizzBuzzSimonF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSimonF.Concrete.Rules
{
    public class BuzzRule : AbstractFizzBuzzRule
    {

        public BuzzRule() {
            this._outputText = "Buzz";
        }

        public override bool AppliesTo(int value)
        {
            return value % 5 == 0;
        }

    }
}
