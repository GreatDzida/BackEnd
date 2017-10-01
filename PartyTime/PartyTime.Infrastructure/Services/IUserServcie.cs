using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PartyTime.Core;
  
namespace PartyTime.Infastructure 
{  
    public  interface IUserService  
    {  
        IEnumerable<User> GetUsers();  
        User GetUser(long id);  
        void InsertUser(User user);  
        void UpdateUser(User user);  
        void DeleteUser(long id);  

        Task RegisterAsync(Guid userId, string email,
            string name,string surname,string login, string password,string phone);
    }  
}  