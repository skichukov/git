using Game.Data;
using Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Services
{
    internal class HeroeService
    {
        private HeroeRepository heroRepository;

        public HeroeService()
        {
            heroRepository = new HeroeRepository();
        }

        public void InsertHero(string heroName, int a_points, int def_points, int h_points, 
            User user)
        {
            Character ch = new Character
            {
                UserId = user.Id,
                CharacterName = heroName,
                AttackPoints = a_points,
                DefencePoints = def_points,
                HealthPoints = h_points,
                DateCreated = DateTime.Now,
                ParentUser = user
            };

            heroRepository.CreateHero(ch);
        }

        public Character GetHeroById(int id)
        {
            return heroRepository.GetHeroById(id);
        }

        public List<Character> GetCharacters(User user)
        {
            return heroRepository.GetUserCharacters(user);
        }

        public void UpdateHero(Character ch)
        {
            heroRepository.UpdateHero(ch);
        }

        public void DeleteHero(int id)
        {
            heroRepository.DeleteHero(id);
        }
    }
}
