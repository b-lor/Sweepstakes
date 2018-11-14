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
            EnterUserInformation();
        }

        public static string StartProgram()
        {
            Console.WriteLine("Welcome -- Insert Business Name Here -- Marketing Firm.\n");
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
        public static int SweepstakeMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Sweepstake Main Menu:\n");
            Console.WriteLine("Enter '1' - Register a new contestant");
            Console.WriteLine("Enter '2' - Display contestants info.");
            Console.WriteLine("Enter '3' - Select a winner for the Sweepstake.");
            int input = 0;
            input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
        public void OptionSelected()
        {
            while (true)
            {
                switch (SweepstakeMainMenu())
                {
                    case 1:
                        EnterUserInformation();
                        break;
                    case 2:
                        DisplayContestant();
                        break;
                    case 3:
                        SelectWinner();
                        break;
                    default:
                        return;
                }

            }
        }
        public void EnterUserInformation()
        {
            GetContestantFirstName();
            GetContestantLastName();
            GetContestantEmailAddress();
            GetContestantRegistrationNumber();
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
        public static int GetContestantRegistrationNumber()
        {
            int input = 0;
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
        public void DisplayContestant()
        {

        }

        public void SelectWinner()
        {

        }

        public void NotifyContestantsOfAWinner()
        {
            //bonus
            //use observer pattern to display notifications 
            Console.Clear();
            Console.WriteLine("Sweepstake is over. Proceed to notify all participants of the winner.");
            Console.WriteLine("Press 'Enter' to continue sending message");
            Console.ReadLine();
        }

        public void EmailTheWinner()
        {
            //bonus
            //use built in smtpclient to send email
            Console.Clear();
            Console.WriteLine("Emailing the winner. Continue....");
            Console.ReadLine();
        }

    }
}
