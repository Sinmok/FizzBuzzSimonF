using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSimonF.Interfaces
{
    public interface IFizzBuzzGame
    {
        public List<string> Run(List<int> values);

        public void SetRules(List<IFizzBuzzRule> rules);
    }
}
