using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Models
{
    [ApiController]
    [Route("api/storesinventory")]
    public class StoreInventoryController : ControllerBase
    {
        private readonly Istoreinventory _userrepo;

        public StoreInventoryController(Istoreinventory userrepo)
        {
            _userrepo = userrepo;
        }

        

               [HttpGet("{phone_number}")]
        public ActionResult<IEnumerable<StoreInventory>> ViewStoreInventory(string phone_number)
        { 

            var store = _userrepo.ViewStoreInventory(phone_number);

            return Ok(store);


        }


               [HttpPost("updatestoreinventory")]
        public void Updateinventory(StoreInventoryDTO stdto)
        { 



            _userrepo.Updateinventory(stdto.phonenumber, stdto.productname, stdto.quantity);

        


        }


          






        




    



    }



}