using System.Collections.Generic;  
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
    }  
}  