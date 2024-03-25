using FizzBuzzSimonF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSimonF.Concrete.Rules
{
    public class FizzRule : AbstractFizzBuzzRule
    {

        public FizzRule()
        {
            this._outputText = "Fizz";
        }


        public override bool DoesApplyTo(int value)
        { 
            return value % 3 == 0;
        }


    }
}
