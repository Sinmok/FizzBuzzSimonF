using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSimonF.Interfaces
{
    public interface IFizzBuzzGame
    {
        /**
      * Runs the game, get a list of outputs
      */
        public List<string> Run(List<int> values, List<IFizzBuzzRule> rules);
    }
}
