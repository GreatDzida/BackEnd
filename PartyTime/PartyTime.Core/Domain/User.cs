using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyTime.Core
{
     public class User:BaseEntity  
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id {get;set;}
        public string Login { get; set; }  
        public string Email { get; set; }  
        public string Password { get; set; }    
        public string Name {get; protected set;} 
        public string Surname {get; protected set;}
        public string Phone { get; set; }
        public DateTime CreatedAt { get; private set; }
       

        public User(Guid id, string name,string surname,
            string email,string phone,string login, string password)
        {
            Id = id;
            SetName(name);
            SetSurname(surname);
            SetPhone(phone);
            SetEmail(email);
            SetLogin(login);
            SetPassword(password);
            CreatedAt = DateTime.UtcNow;
        }

        private void SetSurname(string surname)
        {
            if (string.IsNullOrWhiteSpace(surname))
            {
                throw new Exception($"User can not have an empty login.");
            }
            Surname = surname;
        }

        private void SetLogin(string login)
        {
            if (string.IsNullOrWhiteSpace(login))
            {
                throw new Exception($"User can not have an empty login.");
            }
            Login = login;
        }

        private void SetPhone(string phone)
        {
            if(string.IsNullOrWhiteSpace(phone))
            {
                throw new Exception($"User can not have an empty phone.");
            }
            Phone = phone;
        }

        public void SetName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new Exception($"User can not have an empty name.");
            }
            Name = name;
        }

        public void SetEmail(string email)
        {
            if(string.IsNullOrWhiteSpace(email))
            {
                throw new Exception($"User can not have an empty email.");
            }
            Email = email;
        }     

        public void SetPassword(string password)
        {
            if(string.IsNullOrWhiteSpace(password))
            {
                throw new Exception($"User can not have an empty password.");
            }
            Password = password;
        }      
    }  
}
