using System;

namespace DilemmaDelPrigioniero.Players
{
    public class Matteo : Player
    {
        public int Score { get; private set; }
        private int History;
        private const int HISTORY_LENGHT = 5;

        public void ChangeOpponent()
        {
            History=0;
        }
        
        public Move NextMove()
        {
            if (History > HISTORY_LENGHT)
            {
                return Move.COLLABORATE;
            }
            return Move.DEFECT;
        }

        public void ReceiveOpponentMove(Move m)
        {
            if (m == Move.COLLABORATE)
            {
                History++;
            }
        }

        public int CompareTo(Player other)
        {
            return other.Score - this.Score;
        }

        public void AddScore(int score)
        {
            this.Score += score;
        }

      

        public void Reset()
        {
            Score = 0;
        }

    }
}
