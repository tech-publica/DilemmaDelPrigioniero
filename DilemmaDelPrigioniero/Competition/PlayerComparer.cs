using DilemmaDelPrigioniero.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilemmaDelPrigioniero.Competition
{
    public class PlayerComparer : IComparer<Player>
    {
        public int Compare(Player x, Player y)
        {
            return y.Score - x.Score;
        }
    }
}
