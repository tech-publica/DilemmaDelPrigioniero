using System;
using System.Collections.Generic;
using System.Text;

namespace DilemmaDelPrigioniero.Competition
{
    public class Evolution
    {
        private const int NUM_EPOCHS = 1000;
        private const int NUM_CHANGES = 5;
        private Tournament tournament;
        public Evolution()
        {
            tournament = new Tournament();
        }

        public void Evolve()
        {
            for (int i = 0; i < NUM_EPOCHS; i++)
            {
                tournament.Reset();
                tournament.Giostra();
                tournament.Sort();
                BreedAndKill();
            }

            tournament.ShowResults();
        }

        private void BreedAndKill()
        {
            for (int i = 0; i < NUM_CHANGES; i++)
            {
                tournament.RemoveLast();
            }
            for (int i = 0; i < NUM_CHANGES; i++)
            {
                tournament.CloneAt(i);
            }
        }
    }
}
