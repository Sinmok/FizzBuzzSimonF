using FizzBuzzSimonF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSimonF.Attributes
{
    public class FizzBuzzAttribute : Attribute, IFizzBuzzAttribute
    {
        public bool DoesImplementFizzBuzz(Type type)
        {
            throw new NotImplementedException();
        }
    }
}
