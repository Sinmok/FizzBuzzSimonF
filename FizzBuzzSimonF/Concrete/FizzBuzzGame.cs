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

        private List<IFizzBuzzRule> _rules = [];

        public List<string> Run(List<int> values)
        {
            var results = new List<string>();

            foreach (var value in values)
            {
                var output = string.Empty;

                foreach (var rule in this._rules)
                {
                    if (rule.DoesApplyTo(value))
                    {
                        output = string.Concat(output, rule.GetRuleOutput());
                    }
             
                }


                results.Add(string.IsNullOrEmpty(output) ? value.ToString() : output);
            }

            return results;
        }

        public void SetRules(List<IFizzBuzzRule> rules)
        {
            _rules = rules;
        }
    }
}
