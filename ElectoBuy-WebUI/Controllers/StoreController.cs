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

            var store = _userrepo.AllStores();

            return Ok(store);


        }

               [HttpGet("{phone_number}")]
        public ActionResult<IEnumerable<Store>> FindStore(string phone_number)
        { 

            var store = _userrepo.FindStore(phone_number);

            return Ok(store);


        }

            [HttpPost]
        public void AddStore(Store store)
        { 

            _userrepo.AddStore(store);    
        }




    



    }



}