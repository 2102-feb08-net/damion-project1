using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Models
{
    [ApiController]
    [Route("api/users")]
    public class ElectobuyController : ControllerBase
    {
        private readonly IUser _userrepo;

        public ElectobuyController(IUser userrepo)
        {
            _userrepo = userrepo;
        }

        [HttpGet("{email}")]
        public ActionResult<IEnumerable<User>> SearchUserByEmail(string email)
        { 

            var user = _userrepo.SearchUserByEmail(email);

            return Ok(user);


        }

           [HttpGet("getcustomerbyid/{id}")]
        public ActionResult<IEnumerable<User>> Get(int id)
        { 

            var store = _userrepo.GetCustomerById(id);

            return Ok(store);


        }


        
           [HttpPost("adduser")]
        public void AddCustomer(AddUserDTO user)


        { 
            Models.User  newuser = new User();
            newuser.Email = user.Email;
            newuser.FirstName =  user.FirstName;
            newuser.Lastname = user.LastName;
            newuser.Password = user.Password;
            newuser.Role = user.Role;
            

            



            _userrepo.AddCustomer(newuser);



        }





    



    }



}