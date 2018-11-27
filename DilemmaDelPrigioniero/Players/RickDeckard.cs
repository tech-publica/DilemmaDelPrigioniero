﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DilemmaDelPrigioniero.Players
{
    class RickDeckard : Player
    { 
        public int Score { get; private set; }

        public void AddScore(int score)
        {
            this.Score += score;
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
            return Move.DEFECT;
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
