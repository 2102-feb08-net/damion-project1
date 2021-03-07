using System;
using System.Text.Json.Serialization;

namespace Models
{

    public class Product
    {


        public int Id { get; set; }
        public string ProductName {get;set;}
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }

        public Product()
        {
            
        }


        public Product(int Id, string ProductName,decimal ProductPrice, string ProductDescription)
        {

            this.Id= Id;

            this.ProductName =ProductName;

            this.ProductPrice = ProductPrice;

            this.ProductDescription = ProductDescription;
            
        }


            public Product( string ProductName,int ProductPrice, string ProductDescription)
        {

            this.ProductName =ProductName;

            this.ProductPrice = ProductPrice;

            this.ProductDescription = ProductDescription;
            
        }





    }
}
