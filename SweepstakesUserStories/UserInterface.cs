using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesUserStories
{
    public class UserInterface
    {
        public static string FirstName()
        {
            Console.WriteLine("Please enter a first name: ");
            string input = "";
            input = Console.ReadLine();
            return input;
        }
        public static string LastName()
        {
            Console.WriteLine("Please enter a last name: ");
            string input = "";
            input = Console.ReadLine();
            return input;
        }

        public void IdNumber()
        {

        }

    }
}
