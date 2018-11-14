using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesUserStories
{
    public class Program
    {

        public static void Main(string[] args)
        {
            FactoryDesign factoryDesign = new FactoryDesign();
            factoryDesign.UserSelectManager();
            UserInterface userInterface = new UserInterface();
            userInterface.MainMenu();
        }
    }
}
