using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesUserStories
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //As a developer, I want to create a SweepstakesQueueManager class that uses the Queue data structure as an underlying structure.
        //-https://www.guru99.com/c-sharp-queue.html

        Queue<Sweepstakes> queueSweepstakes = new Queue<Sweepstakes>();

        public Sweepstakes GetSweepstakes()
        {

            return queueSweepstakes.Dequeue();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {

            queueSweepstakes.Enqueue(sweepstakes);
        }
        public void InsertSweepstakes()
        {
        }
    }
}
