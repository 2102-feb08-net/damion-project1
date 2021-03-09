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
                    LastName = customer.LastName,
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
                    user.Role = query.Role;
                    user.FirstName = query.FirstName;
                    user.LastName = query.LastName;
                    user.Email = query.Email;
                    user.Id = query.Id;
                    user.Password = query.Password;
                    

              }
              else{
                   user.FirstName = null;
                    user.LastName = null;
                    user.Email =null;
                    user.Id = null;
                    user.Password =null;
                    user.Role = null;

              }

              return user;
              
             }

       public Models.User GetCustomerById(int id)
        {
             var query = _context.Members.FirstOrDefault(p => p.Id == id);
              User user = new User();
             if(query !=null){
                    user.FirstName = query.FirstName;
                    user.LastName = query.LastName;
                    user.Email = query.Email;
                    user.Id = query.Id;
                    user.Password = query.Password;
                    user.Role = query.Role;

              }
              else{
                   user.FirstName = null;
                    user.LastName = null;
                    user.Email =null;
                    user.Id = null;
                    user.Password =null;
                    user.Role = null;

              }

              return user;
        }

    
    }
    }
