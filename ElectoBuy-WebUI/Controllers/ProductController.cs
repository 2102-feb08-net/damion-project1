using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Models
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _userrepo;

        public ProductController(IProduct userrepo)
        {
            _userrepo = userrepo;
        }

        [HttpGet("findproductbyname/{name}")]
        public ActionResult<IEnumerable<Product>> FindProductByName(string name)
        { 

            var product = _userrepo.FindProductByName(name);

            return Ok(product);


        }

           [HttpGet("findproductybyid/{id}")]
        public ActionResult<IEnumerable<Product>> Get(int id)
        { 

            var product = _userrepo.FindProductById(id);

            return Ok(product);


        }


           [HttpPost("addproduct")]
        public void AddProduct(Product product)
        { 

             _userrepo.AddProduct(product);

            


        }




    



    }



}