using FizzBuzzSimonF.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSimonF.Concrete
{
    public class FizzBuzzGame : IFizzBuzzGame
    {

        public List<string> Run(List<int> values, List<IFizzBuzzRule> rules)
        {
            if (rules.Count == 0)
            {
                throw new InvalidOperationException("Rules must not be empty");
            }

            var results = new List<string>();

            foreach (var value in values)
            {
                var output = string.Empty;

                foreach (var rule in rules.Where(rule => rule.DoesApplyTo(value)))
                {        
                    output = string.Concat(output, rule.GetRuleOutput());                         
                }


                results.Add(string.IsNullOrEmpty(output) ? value.ToString() : output);
            }

            return results;
        }

    }
}
