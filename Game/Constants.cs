using Game.Models;
using Game.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Constants
    {
        private UserService us;
        private HeroeService hs;
        private BattleService bs;
        private static Constants constants = new Constants();

        private Constants()
        {
            us = new UserService();
            hs = new HeroeService();
            bs = new BattleService();
        }

        public UserService GetUserService()
        {
            return us;
        }

        public HeroeService GetHeroeService()
        {
            return hs;
        }

        public BattleService GetBattleService()
        {
            return bs;
        }

        public User GetCurrentUser()
        {
            return GetUserService().GetCurrentUser();
        }

        public Battle GetLatestBattle()
        {
            return GetBattleService().GetLatestBattle();
        }

        public static Constants GetConstants()
        {
            return constants;
        }
    }
}
