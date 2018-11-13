using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesUserStories
{


    public class Sweepstakes
    {
        /*As a developer, I want to create a Sweepstakes class that uses the Dictionary data structure as an underlying structure. The Sweepstakes class will have the following methods with full implementation (write the functionality) of each method:
         * 
-	Sweepstakes(string name)
-	void RegisterContestant(Contestant contestant)
-	string PickWinner()
-	void PrintContestantInfo(Contestant contestant)
*/

        //-https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netframework-4.7.2
        Dictionary<int, Contestant> dictionary;

        public Sweepstakes()
        {
            dictionary = new Dictionary<int, Contestant>();

        }

        public void RegisterContestant(Contestant contestant)
        {

        }

        public void PickWinner()
        {

        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }


    }
}
