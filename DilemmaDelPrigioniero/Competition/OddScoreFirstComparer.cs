using DilemmaDelPrigioniero.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilemmaDelPrigioniero.Competition
{
    public class OddScoreFirstComparer : IComparer<Player>
    {
        public int Compare(Player x, Player y)
        {
            if ((x.Score & 1)!=0 && (y.Score & 1)==0)
            {
                return -1;
            }else if((x.Score & 1) == 0 && (y.Score & 1) != 0)
            {
                return 1;
            }

            return 0;
        }
    }
}
