using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesUserStories
{
    class MarketingFirm
    {
        //As a developer, I want to create a MarketingFirm class. 

        ISweepstakesManager iSweepstakesManager;

        public MarketingFirm(ISweepstakesManager iSweepstakesManager)
        {
            this.iSweepstakesManager = iSweepstakesManager;
        }
        public void InsertSweepstakes()
        {
            iSweepstakesManager.InsertSweepstakes(UserInterface.CreateNewSweepstake());
        }
        public Sweepstakes GetSweepstakes()
        {
            return iSweepstakesManager.GetSweepstakes();

        }

    }
}
