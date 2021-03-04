using System;
using System.Text.Json.Serialization;

namespace Models
{ 

    public class User{
        
        [JsonIgnore] public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
         [JsonIgnore]public string Role { get; set; }
        public string Email { get; set; }

        [JsonIgnore] public string Password { get; set; }


        public User()
        {
            
        }


        public User(string FirstName, string LastName, string Role, string Email, string Password)
        {

            this.FirstName = FirstName;
            this.Lastname = LastName;
            this.Role = Role;
            this.Email = Email;
            this.Password = Password;
            
            
        }

          public User(int Id,string FirstName, string LastName, string Role, string Email, string Password)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.Lastname = LastName;
            this.Role = Role;
            this.Email = Email;
            this.Password = Password;
            
            
        }



    }



}