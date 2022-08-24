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
        private static Constants constants = new Constants();

        private Constants()
        {
            us = new UserService();
        }

        public UserService GetService()
        {
            return us;
        }

        public static Constants GetConstants()
        {
            return constants;
        }
    }
}
