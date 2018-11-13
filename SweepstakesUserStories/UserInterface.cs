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
            SweepstakeMainMenu();
        }

        public static string SweepstakeMainMenu()
        {
            Console.WriteLine("Sweepstake Main Menu:\n");
            Console.WriteLine("What would you like to do?\n");
            string input = "";
            input = Console.ReadLine();
            return input;
        }

        public void EnterUserInformation()
        {
            GetContestantFirstName();
            GetContestantLastName();
            GetContestantEmailAddress();
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



    }
}
