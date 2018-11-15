using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesUserStories
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //As a developer, I want to create a SweepstakesStackManager class that uses the Stack data structure as an underlying structure.
        //-https://www.guru99.com/c-sharp-stack.html
        Stack<Sweepstakes> stackSweepstakes = new Stack<Sweepstakes>();
        MarketingFirm marketingFirm = new MarketingFirm();

        public void DisplayAllSweepstakes()
        {
        }

        public Sweepstakes GetSweepstakes()
        {

            return stackSweepstakes.Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {

            stackSweepstakes.Push(sweepstakes);
        }

        public void InsertSweepstakes()
        {
        }
    }
}
