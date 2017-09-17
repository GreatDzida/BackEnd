using System.Collections.Generic;  
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