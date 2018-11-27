using DilemmaDelPrigioniero.Competition;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilemmaDelPrigioniero.Players
{
    class GianPlayer : Player
    {
        public int Score { get; private set; }

        public Move opponentMove = Move.DEFECT;
        private float t = Tournament.NUM_MATCHES * 0.1f;
        public int counterDefect = 0;

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
            if (counterDefect > t)
            {
                return Move.DEFECT;
            }
            if(opponentMove == Move.DEFECT)
            {
                return Move.DEFECT;
            }
            return Move.COLLABORATE;

        }

        public void ReceiveOpponentMove(Move m)
        {
            if (m == Move.DEFECT)
            {
                opponentMove = m;
                ++counterDefect;
            }
            else if (m == Move.COLLABORATE)
            {
                opponentMove = m;
            }
        }

        public void Reset()
        {
            Score = 0;
        }
    }
}
