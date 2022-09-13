using Game.Data;
using Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Services
{
    internal class RoundService
    {
        private RoundRepository roundRep;
        private List<Round> rounds;

        public RoundService()
        {
            roundRep = new RoundRepository();
            rounds = new List<Round>();
        }

        public void AddRoundToList(int p1, int p2, int i, int rand)
        {
            Round round = new Round
            {
                Character1State = p1,
                Character2State = p2,
                RoundIndex = i,
                RandomNumber = rand
            };

            rounds.Add(round);
        }

        public List<Round> GetLocalRounds()
        {
            return rounds;
        }
    }
}
