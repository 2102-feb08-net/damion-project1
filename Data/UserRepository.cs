using System;
using System.Linq;
using Models;

namespace Data
{

    public class UserRepository : IUser
    {
        private readonly DamionBuyContext _context;

        public UserRepository(DamionBuyContext context)
        {
            _context = context;
        }
        public void AddCustomer(User customer)
        {
              var newCustomer = new Member()
                {
                    FirstName = customer.FirstName,
                    LastName = customer.Lastname,
                    Role = customer.Role,
                    Email = customer.Email,
                    Password = customer.Password
                };

                _context.Add(newCustomer);

                _context.SaveChanges();
        }

        public User SearchUserByEmail(string email)
        {
             var query = _context.Members.FirstOrDefault(p => p.Email == email);
              User user = new User();
             if(query !=null){
                    user.FirstName = query.FirstName;
                    user.Lastname = query.LastName;
                    user.Email = query.Email;
                    user.Id = query.Id;
                    user.Password = query.Password;
                    user.Role = query.Role;

              }
              else{
                  throw new Exception("User was not found. Please try again.");
              }

              return user;
              
             }
           
        }
    }
