using System;
using System.Collections.Generic;
using System.Text;

namespace DilemmaDelPrigioniero.Players
{
    class VengefulPlayer : Player
    {

        public int Score
        {
            get;
            private set;
        }

        //public int BOTH_COOPERATE_SCORE = -1;
        //public int BOTH_DEFECT_SCORE = -1;
        //public int ONLY_ONE_COOPERATE_SCORE = -1;
        //public int ONLY_ONE_DEFECT_SCORE = -1;

        //private Move lastMove;

        private const int GOOD_INTENTION = 3;

        private int retaliation = 0;

        private int free_collaborate = 0;

        private List<Move> moves = new List<Move>();

        void Player.AddScore(int score) => Score += score;

        void Player.ChangeOpponent()
        {
            moves.Clear();
            retaliation = 0;
            free_collaborate = 0;
        }

        Move Player.NextMove()
        {

            if (retaliation != 0)
            {
                //lastMove = Move.DEFECT;
                return Move.DEFECT;


            }
            //lastMove = Move.COLLABORATE;
            return Move.COLLABORATE;


        }

        void Player.ReceiveOpponentMove(Move m)
        {
            moves.Add(m);
            if (m == Move.DEFECT && retaliation == 0)
            {
                if (free_collaborate > 0)
                {
                    free_collaborate--;
                }
                else {
                    foreach (var move in moves)
                    {
                        if (move == Move.DEFECT)
                        {
                            retaliation++;
                        }
                        free_collaborate = GOOD_INTENTION;
                    }
                }
                
            }
            
        }

        void Player.Reset()
        {
            Score = 0;
            moves.Clear();
            retaliation = 0;
            free_collaborate = 0;
        }

        public int CompareTo(Player other)
        {
            return other.Score - this.Score;
        }
    }
}

