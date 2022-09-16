using Game.Data;
using Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Services
{
    internal class BattleService
    {
        private BattleRepository battleRep;

        public BattleService()
        {
            battleRep = new BattleRepository();
        }

        public void InserBattle(User user, Character w, Character l)
        {
            Battle b = new Battle
            {
                UserId = user.Id,
                WinnerId = w.Id,
                LoserId = l.Id,
                CreatedDate = DateTime.Now,
                Organiser = user,
                Winner = w,
                Loser = l
            };

            battleRep.CreateBattle(b);
            battleRep.SetLatestBattle(b);
        }

        public Battle GetLatestBattle()
        {
            return battleRep.GetLatestBattle();
        }

        public Battle GetBattleById(int id)
        {
            return battleRep.GetBattleById(id);
        }
    }
}
