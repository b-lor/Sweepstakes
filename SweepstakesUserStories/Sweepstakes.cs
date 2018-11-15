using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesUserStories
{


    public class Sweepstakes
    {
        /*As a developer, I want to create a Sweepstakes class that uses the Dictionary data structure as an underlying structure. 
         * The Sweepstakes class will have the following methods with full implementation (write the functionality) of each method:
         * 
            -   Sweepstakes(string name)
            -   void RegisterContestant(Contestant contestant)
            -   string PickWinner()
            -   void PrintContestantInfo(Contestant contestant)
        */

        //-https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netframework-4.7.2
        Dictionary<int, Contestant> dictionary;
        string SweepstakesName;
        private int RegistrationNumber;
   

        public Sweepstakes()
        {
            dictionary = new Dictionary<int, Contestant>();
        }
        public Sweepstakes(string sweepstakesName)
        {
            SweepstakesName = sweepstakesName;
        }

        public void RegisterContestant(Contestant contestant)
        {

            dictionary.Add(RegistrationNumber, contestant);
            RegistrationNumber++;
            Console.WriteLine("Contestant added! \n");

        }

        public void PrintContestantInfo(Contestant contestant)
        {
            foreach (KeyValuePair<int, Contestant> participants in dictionary)
            {
                Console.WriteLine("Contestant ID: " + " " + participants.Value.registrationNumber + "\n" + participants.Value.firstName + " " + participants.Value.lastName + "\n" + "Email: " + " " + participants.Value.emailAddress);
            }
            Console.ReadKey();
        }

        // placeholder select random winner
        public string PickWinner()
        {
            Random random = new Random();
            int randomPick = random.Next(0, dictionary.Count);
            foreach (KeyValuePair<int, Contestant> participants in dictionary)
            {
                if (randomPick == participants.Key)
                    Console.WriteLine("Winner of the sweepstake is : " + " " + participants.Value.firstName + " " + participants.Value.lastName);
            }
            Console.ReadKey();
            return "done";

        }

    }
}