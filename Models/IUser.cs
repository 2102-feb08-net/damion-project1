using System;

namespace Models
{
    public interface IUser
    {

        public void AddCustomer(User customer);


       public User SearchUserByEmail(string email);

       public User GetCustomerById(int id);

    }
}
