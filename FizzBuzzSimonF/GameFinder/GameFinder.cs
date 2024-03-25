using FizzBuzzSimonF.Attributes;
using FizzBuzzSimonF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSimonF.GameFinder
{
    public class GameFinder
    {
        /**
         * Demo of reflection. Finds classes with [FizzBuzz] and ensures it implements IFizzBuzzGame or it's no good to us
         * In an ideal world, we could pass in a generic here to search by a generic type but it's hard coded due to time
         * 
         * This class could also potentially be an IGameFinder, but running out of time
         */
        public static IFizzBuzzGame FindFizzBuzzGame()
        {
            Type fizzBuzzAttribute = typeof(FizzBuzzAttribute);
            var classesWithFizzBuzzAttributes = Assembly.GetExecutingAssembly().GetTypes().Where(type => type.IsDefined(fizzBuzzAttribute));

            if (classesWithFizzBuzzAttributes.Any())
            {

                foreach (var match in classesWithFizzBuzzAttributes)
                {
                    var attribute = match.GetCustomAttribute<FizzBuzzAttribute>();

                    if (attribute != null && attribute.DoesImplementFizzBuzz(match))
                    {
                        return (IFizzBuzzGame)Activator.CreateInstance(type: match);
                    }
                }


            }

            throw new Exception("Cannot find any FizzBuzzGames");
        }

    }
}
