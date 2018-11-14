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

        //public ISweepstakesManager UserSelectManager()
        //{

        //    Console.WriteLine("This program requires a queue or stack manager to begin.\n");
        //    Console.WriteLine("Enter '1' to use queue manager.");
        //    Console.WriteLine("Enter '2' to use stack manager.");
        //    int userInput = Convert.ToInt32(Console.ReadLine());

        //    switch (userInput)
        //    {
        //        case 1:
        //            return new SweepstakesQueueManager();

        //        case 2:
        //            return new SweepstakesStackManager();

        //        default:
        //            Console.WriteLine("Invalid input, please try again.");
        //            return null;
        //    }
        //}
        ISweepstakesManager iSweepstakes;

        public void UserSelectManager()
        {
            Console.Clear();
            int i;
            Console.WriteLine("This program requires a queue or stack manager to begin.\n");
            Console.WriteLine("Enter '1' to use queue manager.");
            Console.WriteLine("Enter '2' to use stack manager.");
            string userInput = Console.ReadLine();
            if(Int32.TryParse(userInput, out i))
            {
                switch (i)
                {
                    case 1:
                        new SweepstakesQueueManager();
                        Console.WriteLine("Loading Queue Manager...............................");
                        System.Threading.Thread.Sleep(3000);
                        break;
                    case 2:
                        new SweepstakesStackManager();
                        Console.WriteLine("Loading Stack Manager...................................");
                        System.Threading.Thread.Sleep(3000);
                        break;
                    default:
                        Console.WriteLine("Invalid number, Press any key to try again.");
                        Console.ReadKey();
                        UserSelectManager();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a numeric value. PRESS any key to try again");
                Console.ReadKey();
                UserSelectManager();
            }

        }

    }
}
