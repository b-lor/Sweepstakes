using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesUserStories
{
    public class UserInterface

    {
        public void MainMenu()
        {
            StartProgram();
            CreateNewSweepstake();

            SweepstakeMainMenu();
        }

        public static string StartProgram()
        {
            Console.WriteLine("Which data type would you like to start the program with?\n");
            Console.WriteLine("Enter '1' for Stack");
            Console.WriteLine("Enter '2' for Queue");
            string input = "";
            input = Console.ReadLine();
            return input;
        }
       
        public static string CreateNewSweepstake()
        {
            Console.WriteLine("Creating a new Sweepstake............");
            Console.WriteLine("What is the name of your Sweepstake?");
            string input = "";
            input = Console.ReadLine();
            return input;
        }
        public static string SweepstakeMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Sweepstake Main Menu:\n");
            Console.WriteLine("Enter '1' - Register a new contestant");
            Console.WriteLine("Enter '2' - Pick a Winner.");
            Console.WriteLine("Enter '3' - Display Winner.");
            string input = "";
            input = Console.ReadLine();
            return input;
        }

        public void EnterUserInformation()
        {
            GetContestantFirstName();
            GetContestantLastName();
            GetContestantEmailAddress();
            EnterAnotherContestant();
        }
        public static string GetContestantFirstName()
        {
            Console.WriteLine("Please enter a First name: ");
            string input = "";
            input = Console.ReadLine();
            return input;
        }
        public static string GetContestantLastName()
        {
            Console.WriteLine("Please enter a Last name: ");
            string input = "";
            input = Console.ReadLine();
            return input;
        }
        public static string GetContestantEmailAddress()
        {
            Console.WriteLine("Please enter an Email Address: ");
            string input = "";
            input = Console.ReadLine();
            return input;
        }

        public static string EnterAnotherContestant()
        {
            Console.Clear();
            Console.WriteLine("Would you like to add another contestant\n");
            Console.WriteLine("Enter 'Y' for Yes");
            Console.WriteLine("Enter 'N' for No");
            string input = "";
            input = Console.ReadLine();
            return input;
        }

    }
}
