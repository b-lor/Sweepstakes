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
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int idNumber;



        public Contestant()
        {

            firstName = UserInterface.FirstName();
            lastName = UserInterface.LastName();
            //idNumber = UserInterface.IdNumber();
        }

    }
}
