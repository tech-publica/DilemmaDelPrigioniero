using System;
using System.Collections.Generic;
using System.Text;

namespace DilemmaDelPrigioniero.Players
{
    public class Tit4Tat : Player
    {
        private Move lastMove = Move.COLLABORATE;

        public int Score { get; set; }

        public void AddScore(int score)
        {
            Score += score;
        }

        public void ChangeOpponent()
        {
            lastMove = Move.COLLABORATE;
        }

        public int CompareTo(Player other)
        {
            return other.Score - this.Score;
        }

        public Move NextMove()
        {
            return lastMove;
        }

        public void ReceiveOpponentMove(Move m)
        {
            lastMove = m;
        }

        public void Reset()
        {
            Score = 0;
        }
    }
}
