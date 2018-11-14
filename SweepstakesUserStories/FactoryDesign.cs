using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesUserStories
{
    public class FactoryDesign
    {
        // As a developer, I want to use the factory design pattern to allow a user to choose between a SweepstakesStackManager or a SweepstakesQueueManager to manage the sweepstakes objects.
        //-https://www.dotnettricks.com/learn/designpatterns/factory-method-design-pattern-dotnet

        public ISweepstakesManager UserSelectManager()
        {

            Console.WriteLine("This program requires a queue or stack manager to begin.\n");
            Console.WriteLine("Enter '1' to use queue manager.");
            Console.WriteLine("Enter '2' to use stack manager.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    return new SweepstakesQueueManager();

                case 2:
                    return new SweepstakesStackManager();

                default:
                    Console.WriteLine("Invalid input, please try again.");
                    return null;

            }
        }


    }
}
