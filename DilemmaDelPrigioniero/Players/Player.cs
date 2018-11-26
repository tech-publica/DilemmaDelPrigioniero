using System;
using System.Collections.Generic;
using System.Text;

namespace DilemmaDelPrigioniero.Players
{
    public enum Move { COLLABORATE, DEFECT }
    public interface Player : IComparable<Player>
    {
        int Score { get; }
        Move NextMove();
        void ReceiveOpponentMove(Move m);
        void AddScore(int score);
        void ChangeOpponent();
        void Reset();
    }
}
