using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesUserStories
{
    public class Contestant
    {
        //As a developer, I want to create a Contestant class that has a first name, last name, email address, and registration number.
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public int registrationNumber { get; set; }

        public Contestant()
        {

            //firstName = UserInterface.GetContestantFirstName();
            //lastName = UserInterface.GetContestantLastName();
            //emailAddress = UserInterface.GetContestantEmailAddress();
        }

    }
}
