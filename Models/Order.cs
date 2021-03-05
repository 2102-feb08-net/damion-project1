using System;
using System.Text.Json.Serialization;

namespace Models
{

    public class Order
    {


        public int? Id { get; set; }
        public int?  CustomerID {get; set;}
        public DateTime? Date{get; set;}
        public int? StoreID {get; set;}
    


        public Order()
        {
            
        }


        public Order(int Id, int CustomerID,DateTime Date, int StoreID){

            this.Id= Id;

            this.CustomerID =CustomerID;

            this.Date = Date;

            this.StoreID = StoreID;         
        }


         
        public Order( int CustomerID,DateTime Date, int StoreID){


            this.CustomerID =CustomerID;

            this.Date = Date;

            this.StoreID = StoreID;         
        }







    }
}
