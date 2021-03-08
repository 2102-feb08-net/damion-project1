using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Data
{

    public class ProductRepository : IProduct
    {
        private readonly DamionBuyContext _context;

        public ProductRepository(DamionBuyContext context)
        {
            _context = context;
        }

        void IProduct.AddProduct(Models.Product product)
        {
              var newproduct = new Product()
                {
                    ProductName = product.ProductName,
                    ProductPrice = product.ProductPrice,
                    ProductDescription = product.ProductDescription
                };

                _context.Add(newproduct);

                _context.SaveChanges();
        }

        Models.Product IProduct.FindProductById(int id)
        {
              Models.Product newproduct = new Models.Product();


            Product storequery = _context.Products.Where(x => x.Id.Equals(id)).First();

            if(storequery == null){
                newproduct = null;
            }
            else{
                newproduct.Id = storequery.Id;
                newproduct.ProductName = storequery.ProductName;
                newproduct.ProductDescription = storequery.ProductDescription;
                newproduct.ProductPrice = storequery.ProductPrice;     
            }

            return newproduct;
        }

        Models.Product IProduct.FindProductByName(string name)
        {
             Models.Product newproduct = new Models.Product();


            Product storequery = _context.Products.Where(x => x.ProductName.Equals(name)).First();

            if(storequery == null){
                newproduct = null;
            }
            else{
                newproduct.Id = storequery.Id;
                newproduct.ProductName = storequery.ProductName;
                newproduct.ProductDescription = storequery.ProductDescription;
                newproduct.ProductPrice = storequery.ProductPrice;     
            }

            return newproduct;
        }


                public List<Models.Product> GetAllProducts()
        {
                     var database_products = _context.Products;

            List<Models.Product> AllProducts = new List<Models.Product>();

            foreach(var product in database_products){
                AllProducts.Add(new Models.Product(product.Id, product.ProductName, product.ProductPrice, product.ProductDescription));
            }
            return AllProducts;

            
        }

    }
}

