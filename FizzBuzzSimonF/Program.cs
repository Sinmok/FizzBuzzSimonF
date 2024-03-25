// See https://aka.ms/new-console-template for more information
using FizzBuzzSimonF.Concrete;
using FizzBuzzSimonF.Concrete.Rules;
using FizzBuzzSimonF.GameFinder;
using FizzBuzzSimonF.Interfaces;


IFizzBuzzGame game = GameFinder.FindFizzBuzzGame();

//Could get rules from a RuleFactory?
var rules = new List<IFizzBuzzRule>()
{
    new CustomFizzBuzzRule(3, "Fizz"),
    new BuzzRule()
};


var range = Enumerable.Range(1, 100).ToList();

//Could potentially be a IFizzBuzzOutputHandler or simliar to swap out output methods but ran out of time
game.Run(range, rules).ForEach(result => Console.WriteLine(result));