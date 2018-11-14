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
            -	Sweepstakes(string name)
            -	void RegisterContestant(Contestant contestant)
            -	string PickWinner()
            -	void PrintContestantInfo(Contestant contestant)
        */

        //-https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netframework-4.7.2
        Dictionary<int, Contestant> dictionary;
        public int RegistrationNumber { get; set; }

        public Sweepstakes()
        {
            dictionary = new Dictionary<int, Contestant>();
            RegistrationNumber = 0;

        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = RegistrationNumber;
            dictionary.Add(RegistrationNumber, contestant);
            RegistrationNumber++;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            foreach (KeyValuePair<int, Contestant> contestant in dictionary)
            {
                Console.WriteLine($"Registration #: {contestant.Value.registrationNumber} Name: {contestant.Value.firstName} {contestant.Value.lastName}");
            }
        }

        // placeholder select random winner
        public string PickWinner()
        {
            string input = "";
            input = Console.ReadLine();
            return input;
        }




    }
}
