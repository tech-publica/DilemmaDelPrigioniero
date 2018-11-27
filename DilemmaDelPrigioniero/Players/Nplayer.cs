using DilemmaDelPrigioniero.Competition;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilemmaDelPrigioniero.Players
{
    class Nplayer : Player
    {
        private Random rand = new Random();
        private int counter = 0;
        private float t = Tournament.NUM_MATCHES*0.1f;
        public int Score { get; private set; }

        public void AddScore(int score)
        {
            Score += score;
        }

        public void ChangeOpponent()
        {
            
        }

        public int CompareTo(Player other)
        {
            return other.Score - this.Score;
        }

        public Move NextMove()
        { 
            if(counter < t)
            {
                if (rand.Next(2) == 0)
                {
                    return Move.COLLABORATE;
                }
                return Move.DEFECT;

            }
            ++counter;
           return Move.COLLABORATE;
        }

        public void ReceiveOpponentMove(Move m)
        {
            
        }

        public void Reset()
        {
            Score = 0;
        }
    }
}
