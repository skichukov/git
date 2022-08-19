using Game.Data;
using Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Services
{
    internal class UserService
    {
        private UserRepository _usersRepository;

        public UserService()
        {
            _usersRepository = new UserRepository();
        }

        public void InsertUser(string name, string username, string password)
        {
            User user = new User
            {
                Name = name,
                Username = username,
                DateCreated = DateTime.Now,
                Password = password
            };

            _usersRepository.CreateUser(user);
        }

        public void SaveUser(string username, string password)
        {
            User user = new User
            {
                Username = username,
                Password = password
            };

            _usersRepository.SaveUser(user);
        }

        public bool HasUserWith(string username, string password)
        {
            return _usersRepository.HasUserWith(username, password);
        }

        public User GetUserById(int id)
        {
            return _usersRepository.GetUserById(id);
        }

        public List<User> GetUsers()
        {
            return _usersRepository.GetUsers();
        }
    }
}
