using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSimonF.Interfaces
{
    public interface IFizzBuzzAttribute
    {
        public bool DoesImplementFizzBuzz(Type type);
    }
}
