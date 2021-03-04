using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Models
{
    [ApiController]
    [Route("api/stores")]
    public class StoreController : ControllerBase
    {
        private readonly IStore _userrepo;

        public StoreController(IStore userrepo)
        {
            _userrepo = userrepo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Store>> AllStores()
        { 

            var user = _userrepo.AllStores();

            return Ok(user);


        }

               [HttpGet("{phone_number}")]
        public ActionResult<IEnumerable<Store>> FindStore(string phone_number)
        { 

            var user = _userrepo.FindStore(phone_number);

            return Ok(user);


        }




    



    }



}