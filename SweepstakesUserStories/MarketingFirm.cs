using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesUserStories
{
    class MarketingFirm
    {
        //As a developer, I want to create a MarketingFirm class. 

        ISweepstakesManager iSweepstakesManager;

        public MarketingFirm(ISweepstakesManager iSweepstakesManager)
        {
            this.iSweepstakesManager = iSweepstakesManager;
        }

        public MarketingFirm()
        {
        }

        public void MarketingFirmMenu()
        {
            Console.Clear();
            Console.WriteLine("Sweepstake Main Menu:\n");
            Console.WriteLine("Enter '1' - Create a new Sweepstakes");
            Console.WriteLine("Enter '2' - Display active Sweepstakes");
            Console.WriteLine("Enter '3' - Contestant Screen");
            int input = 0;
            input = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                UserInterface userInterface = new UserInterface();
                switch (input)
                {
                    case 1:
                        CreateNewSweepstake();
                        break;
                    case 2:
                        GetSweepstakes();
                        break;
                    case 3:
                        userInterface.SweepstakeMainMenu();
                        break;
                    default:
                        break;
                }

            }

        }

        public void CreateNewSweepstake()
        {
            Console.WriteLine("Creating a new Sweepstake............");
            Console.WriteLine("What is the name of your Sweepstake?");
            string name = Console.ReadLine();
            Console.WriteLine($"Your {name} sweepstake has been created.");
            Console.ReadKey();
            Sweepstakes newSweepstakes = new Sweepstakes(name);
            //iSweepstakesManager.InsertSweepstakes(newSweepstakes);
            AddAnotherSweepstake();
        }


        public void AddAnotherSweepstake()
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

        }

        public Sweepstakes GetSweepstakes()
        {
            return iSweepstakesManager.GetSweepstakes();

        }



    }
}
