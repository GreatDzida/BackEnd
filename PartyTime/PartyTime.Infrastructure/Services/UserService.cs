using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PartyTime.Core;

namespace PartyTime.Infastructure
{
    public class UserService : IUserService
    {
        IRepository<User> userRepository;
        public UserService(IRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }
        void IUserService.DeleteUser(long id)
        {
            throw new System.NotImplementedException();
        }

        User IUserService.GetUser(long id)
        {
            throw new System.NotImplementedException();
        }

        //  Async IUserService.GetUser(long id)
        // {
        //     throw new System.NotImplementedException();
        // }

        public async Task RegisterAsync(Guid userId, string email,
          string name, string surname,string login, string password, string phone)
        {
            //TODO: Check is user in db
            //var user = await userRepository.GetAsync(email);
            // if (user != null)
            // {
            //     throw new Exception($"User with email: '{email}' already exists.");
            // }
            var user = new User(userId, name,surname, email,phone,login, password);
            await userRepository.Insert(user);
        }

        IEnumerable<User> IUserService.GetUsers()
        {
            throw new System.NotImplementedException();
        }

        void IUserService.InsertUser(User user)
        {
            throw new System.NotImplementedException();
        }

        void IUserService.UpdateUser(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}