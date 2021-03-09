using System;
using System.Text.Json.Serialization;

namespace Models
{ 

    public class User{
        
      public int? Id{get;set;}
        private string _FirstName;
        private string _LastName; 
        private string _Email; 
        private string _Password;
        private string _Role = "Member"; 

        public string FirstName{
            get{return _FirstName;}
                 
            set{
               if (value.Length > 0)
               {
                   _FirstName = value;

               }  
               else{
                   throw new ArgumentException("Please enter your First Name.");
               } 

            }
            

        }


         public string Role{
            get{return _Role;}
                 
            set{
               if (value.Length > 0)
               {
                   _Role = value;

               }  
               else{
                   throw new ArgumentException("Please enter a valid role");
               } 

            }
            

        }


           public string LastName{
            get{return _LastName;}
                 
            set{
               if (value.Length > 0)
               {
                   _LastName = value;

               }  
               else{
                   throw new ArgumentException("Please enter your Last Name.");
               } 

            }
            

        }   

        public string Email{

            get{return _Email;}
            set{
                if (value.Contains("@"))
                {
                    _Email = value;
                }
                else{
                   throw new ArgumentException("Please enter your correct Email.");
               } 



            }


        }


            public string Password{

            get{return _Password;}
            set{
                if (value.Length > 5)
                {
                    _Password = value;
                }
                else{
                   throw new ArgumentException("Please enter a strong password.");
               } 



            }


        }

        public User()
        {
            
        }


        public User(string FirstName, string LastName, string Email, string Password)
        {

            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Role = "User";
            this.Email = Email;
            this.Password = Password;
            
            
        }

          public User(int Id,string FirstName, string LastName, string Email, string Password)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Role = "User";
            this.Email = Email;
            this.Password = Password;
            
            
        }



    }



}