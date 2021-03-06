﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesUserStories
{
   
    interface ISweepstakesManager
    {
        /*I want to write an ISweepstakesManager interface with the following methods for a sweepstakes management system:
         * 
-	void InsertSweepstakes(Sweepstakes sweepstakes)
-	Sweepstakes GetSweepstakes()

    */

        void InsertSweepstakes(Sweepstakes sweepstakes);
        Sweepstakes GetSweepstakes();
        void InsertSweepstakes();
    }
}
