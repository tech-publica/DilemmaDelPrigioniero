using System;
using System.Collections.Generic;
using System.Text;

namespace DilemmaDelPrigioniero.Players
{
    public class AlwaysNo : Player
    {
        public int Score { get; private set; }
        public List<Move> opponentMoves = new List<Move>();

        public void AddScore(int score)
        {
            Score += score;

            /*if(score == 110 || score == 50)
            {
                opponentMoves.Add(Move.COLLABORATE);
            }
            else if(score == 30 || score == 0)
            {
                opponentMoves.Add(Move.DEFECT);
            }*/
        }

        public void ChangeOpponent()
        {
        }

        public int CompareTo(Player other)
        {
            return other.Score - this.Score; //non molto chiaro...
        }

        public Move NextMove()
        {
            return Move.DEFECT;
        }

        public void ReceiveOpponentMove(Move m)
        {
            /*List<Move> opponentMoves = new List<Move>();
            opponentMoves.Add(m);

            for (int i = 0; i < opponentMoves.Count -1; i++)
            {
                Console.WriteLine(opponentMoves[i]);
            }*/
        }


        public void Reset()
        {
             Score = 0;
        }
}
}
