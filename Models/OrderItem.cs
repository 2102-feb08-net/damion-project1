using System;
using System.Text.Json.Serialization;

namespace Models
{

    public class OrderItems
    {

         public int Id { get; set; }
        public int? Orderid { get; set; }
        public int? Productid { get; set; }
        public int? Quantity { get; set; }




        public OrderItems()
        {
            
        }


        public OrderItems(int Id, int Orderid, int Productid, int Quantity){

            this.Id= Id;

            this.Orderid =Orderid;

            this.Productid = Productid;

            this.Quantity = Quantity;         
        }


         
        public OrderItems(int Orderid, int Productid, int Quantity){


            this.Orderid =Orderid;

            this.Productid = Productid;

            this.Quantity = Quantity;         
        }







    }
}
