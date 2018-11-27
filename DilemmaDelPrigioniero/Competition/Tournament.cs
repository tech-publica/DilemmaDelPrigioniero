using DilemmaDelPrigioniero.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilemmaDelPrigioniero.Competition
{
    public class Tournament
    {
        public const int NUM_CLONES = 3;
        public const int NUM_MATCHES = 100;

        public const int BOTH_COOPERATE_SCORE = 50;
        public const int BOTH_DEFECT_SCORE = 30;
        public const int ONLY_ONE_COOPERATE_SCORE = 0;
        public const int ONLY_ONE_DEFECT_SCORE = 80;

        private Random dice;

        private List<Player> players = new List<Player>();
        public Tournament()
        {
            dice = new Random();

            for (int i = 0; i < NUM_CLONES; i++)
            {

                players.Add(new DummyPlayer());
                players.Add(new BastardInside());
                players.Add(new DrunkPlayer());
                players.Add(new Tit4Tat());
                players.Add(new Matteo());
                players.Add(new AlwaysNo());
                players.Add(new MyPlayerAl5());
                players.Add(new MyPlayer_Al6());
                players.Add(new GianPlayer());
                players.Add(new Nplayer());
                players.Add(new RickDeckard());
                players.Add(new VengefulPlayer());
            }

            for (int i = 0; i <players.Count; i++)
            {
                int x = dice.Next(players.Count);
                int y = dice.Next(players.Count);

                var temp = players[x];
                players[x] = players[y];
                players[y] = temp;
            }
        }

        public void RemoveLast()
        {
            players.RemoveAt(players.Count - 1);
        }

        public void CloneAt(int index)
        {
            var p = players[index];
            Player clone = (Player) Activator.CreateInstance(p.GetType());
            players.Add(clone);
        }

        public void Giostra()
        {
            for (int i = 0; i < players.Count-1; i++)
            {
                for (int j = i+1; j < players.Count; j++)
                {
                    Giostra(players[i], players[j]);
                }
            }
        }

        public void ShowResults()
        {
            foreach (var item in players)
            {
                Console.WriteLine($"{item.GetType().Name}: {item.Score}");
            }
        }

        public void Sort()
        {
            Extensions.BubbleSortComparable(players);
            //players.Sort(new PlayerComparer());
        }


        public void Reset()
        {
            foreach(var p in players)
            {
                p.Reset();
            }
        }

        private void Giostra(Player p1, Player p2)
        {
            p1.ChangeOpponent();
            p2.ChangeOpponent();
            for (int i = 0; i < NUM_MATCHES; i++)
            {
                Move m1 = p1.NextMove();
                Move m2 = p2.NextMove();
                p1.ReceiveOpponentMove(m2);
                p2.ReceiveOpponentMove(m1);

                if (m1==Move.COLLABORATE && m2==Move.COLLABORATE)
                {
                    p1.AddScore(BOTH_COOPERATE_SCORE);
                    p2.AddScore(BOTH_COOPERATE_SCORE);
                }
                else if (m1 == Move.COLLABORATE && m2 == Move.DEFECT)
                {
                    p1.AddScore(ONLY_ONE_COOPERATE_SCORE);
                    p2.AddScore(ONLY_ONE_DEFECT_SCORE);
                }
                else if (m1 == Move.DEFECT && m2 == Move.COLLABORATE)
                {
                    p1.AddScore(ONLY_ONE_DEFECT_SCORE);
                    p2.AddScore(ONLY_ONE_COOPERATE_SCORE);
                }
                else if (m1 == Move.DEFECT && m2 == Move.DEFECT)
                {
                    p1.AddScore(BOTH_DEFECT_SCORE);
                    p2.AddScore(BOTH_DEFECT_SCORE);
                }
                
            }
        }
    }
}
