using System;
using System.Collections.Generic;

namespace Models
{
    public interface IProduct
    {

        public void AddProduct(Product product);

        public Product FindProductByName(string name);

        public Product FindProductById(int id);

         public List<Product> GetAllProducts();


        


    }
}
