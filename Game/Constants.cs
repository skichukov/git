﻿using Game.Models;
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
        private static Constants constants = new Constants();

        private Constants()
        {
            us = new UserService();
            hs = new HeroeService();
        }

        public UserService GetUserService()
        {
            return us;
        }

        public HeroeService GetHeroeService()
        {
            return hs;
        }

        public User GetCurrentUser()
        {
            return GetUserService().GetCurrentUser();
        }

        public static Constants GetConstants()
        {
            return constants;
        }
    }
}
