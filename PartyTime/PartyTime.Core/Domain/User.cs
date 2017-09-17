using System;
namespace PartyTime.Core
{
     public class User:BaseEntity  
    {  
        public string Login { get; set; }  
        public string Email { get; set; }  
        public string Password { get; set; }    
        public string Name {get; protected set;} 
        public string SurName {get; protected set;} 
        
    }  
}
