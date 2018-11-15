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
        Contestant contestant = new Contestant();
        public int registrationNumber { get; set; }

        public void MainMenu()
        {
            StartProgramIntro();
            MarketingFirm marketingFirm = new MarketingFirm();
            marketingFirm.MarketingFirmMenu();

        }

        public void StartProgramIntro()
        {
            Console.Clear();
            Console.WriteLine("Welcome -- Insert Business Name Here -- Marketing Firm.\n");
        }


        public void SweepstakeMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Sweepstake Main Menu:\n");
            Console.WriteLine("Enter '1' - Register a new contestant");
            Console.WriteLine("Enter '2' - Display contestants info.");
            Console.WriteLine("Enter '3' - Select a winner for the Sweepstake.");
            Console.WriteLine("Enter '4' - Change data structure Manager.");
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
                        sweepstakes.PrintContestantInfo(contestant);
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
            CreateNewContestant();
            GetContestantFirstName();
            GetContestantLastName();
            GetContestantEmailAddress();
            GetContestantRegistrationNumber();
            sweepstakes.RegisterContestant(contestant);
            EnterAnotherContestant();
        }
        public void CreateNewContestant()
        {
            contestant = new Contestant();
        }
        public void GetContestantFirstName()
        {
            Console.WriteLine("Please enter a First name: ");
            contestant.firstName = Console.ReadLine();
        }
        public void GetContestantLastName()
        {
            Console.WriteLine("Please enter a Last name: ");
            contestant.lastName = Console.ReadLine();
        }
        public void GetContestantEmailAddress()
        {
            Console.WriteLine("Please enter an email address: ");
            contestant.emailAddress = Console.ReadLine();
        }
        public void GetContestantRegistrationNumber()
        {
            contestant.registrationNumber = registrationNumber;
            registrationNumber++;
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
                Console.Clear();
                EnterUserInformation();
            }
            if (input[0] == 'n' || input[0] == 'N')
            {
                Console.Clear();
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