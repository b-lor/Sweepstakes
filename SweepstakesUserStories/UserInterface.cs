using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesUserStories
{
    public class UserInterface

    {
        Sweepstakes sweepstakes = new Sweepstakes();

        public void MainMenu()
        {
            StartProgramIntro();
            CreateNewSweepstake();

            SweepstakeMainMenu();

        }

        public void StartProgramIntro()
        {
            Console.Clear();
            Console.WriteLine("Welcome -- Insert Business Name Here -- Marketing Firm.\n");
        }

        public static string CreateNewSweepstake()
        {
            Console.WriteLine("Creating a new Sweepstake............");
            Console.WriteLine("What is the name of your Sweepstake?");
            string input = "";
            input = Console.ReadLine();
            Console.WriteLine($"Your {input} has been created.");
            Console.ReadKey();
            AddAnotherSweepstake();
            return input;
        }

        public static string AddAnotherSweepstake()
        {
            Console.Clear();
            Console.WriteLine("Would you like to add another Sweepstake\n");
            Console.WriteLine("Enter 'Y' for Yes");
            Console.WriteLine("Enter 'N' for No");
            string input = "";
            input = Console.ReadLine();

            if (input[0] == 'y' || input[0] == 'Y')
            {
                CreateNewSweepstake();
            }
            if (input[0] == 'n' || input[0] == 'N')
            {
                UserInterface userInterface = new UserInterface();
                userInterface.SweepstakeMainMenu();
            }
            Console.WriteLine("That is not a valid option, try again.");
            AddAnotherSweepstake();
            return input;
        }
        public void SweepstakeMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Sweepstake Main Menu:\n");
            Console.WriteLine("Enter '1' - Register a new contestant");
            Console.WriteLine("Enter '2' - Display contestants info.");
            Console.WriteLine("Enter '3' - Select a winner for the Sweepstake.");
            int input = 0;
            input = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                switch (input)
                {
                    case 1:
                        EnterUserInformation();
                        break;
                    case 2:
                        sweepstakes.PrintContestantInfo();
                        break;
                    case 3:
                        sweepstakes.PickWinner();
                        break;
                    default:
                        break;
                }
                SweepstakeMainMenu();
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
            Console.WriteLine("Please enter a First name  whyyyyyyy: ");
            string firstName = Console.ReadLine();
            return firstName;
        }
        public static string GetContestantLastName()
        {
            Console.WriteLine("Please enter a Last name: ");
            string lastName = Console.ReadLine();
            return lastName;
        }
        public static string GetContestantEmailAddress()
        {
            Console.WriteLine("Please enter an Email address: ");
            string emailAddress = Console.ReadLine();
            return emailAddress;
        }
        public static int GetContestantRegistrationNumber()
        {
            int input = 0;
            return input;
        }

        public void EnterAnotherContestant()
        {
            Console.Clear();
            Console.WriteLine("Would you like to add another contestant\n");
            Console.WriteLine("Enter 'Y' for Yes");
            Console.WriteLine("Enter 'N' for No");
            string input = "";
            input = Console.ReadLine();

            if (input[0] == 'y' || input[0] == 'Y')
            {
                EnterUserInformation();
            }
            if (input[0] == 'n' || input[0] == 'N')
            {
                SweepstakeMainMenu();
            }
            Console.WriteLine("That is not a valid option, try again.");
            EnterAnotherContestant();

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