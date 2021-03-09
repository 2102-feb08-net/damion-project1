using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Models
{
    [ApiController]
    [Route("api/orders")]
    public class OrderController : ControllerBase
    {
        private readonly IOrder _userrepo;

        public OrderController(IOrder userrepo)
        {
            _userrepo = userrepo;
        }

      


        
           [HttpPost("addorder")]
        public IActionResult AddOrder(Models.Order customerorder)
        { 
          int orderid = _userrepo.AddOrder(customerorder);

          return Ok(orderid);

        }

           [HttpPost("AddOrderLine")]
        public void AddOrderLine(OrderItems OrderItemLineList)
        { 
            _userrepo.AddOrderLine(OrderItemLineList);

        }



          [HttpPost("changeinventory")]
        public void ChangeInventory(Models.OrderInventoryUpdator order)
        { 
            _userrepo.ChangeInventory(order.id, order.quantity,order.productid);

        }


        [HttpGet("getcustomerorders/{id}")]
        public ActionResult<IEnumerable<Order>> ReturnAllOrdersBasedOnCustomer(int id)
        { 

            var store = _userrepo.ReturnAllOrdersBasedOnCustomer(id);

            return Ok(store);


        }










    



    }



}