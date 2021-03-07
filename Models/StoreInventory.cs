using System;
using System.Text.Json.Serialization;

namespace Models
{

    public class StoreInventory
    {


        public int? Id { get; set; }
        public int?  ProductID {get; set;}
        public int? StoreID{get; set;}
        public int? ProductQuantity {get; set;}



        public StoreInventory() { }
        public StoreInventory(int Id, int ProductID, int StoreID, int ProductQuantity){

            if(ProductQuantity <= 0){
                    throw new ArgumentException("You can not add 0 items");
                }        
            else{
                   this.Id= Id;

                    this.ProductID =ProductID;

                    this.StoreID = StoreID;

                    this.ProductQuantity = ProductQuantity; 
                }        


                    
        }


         
          public StoreInventory(int ProductID, int StoreID, int ProductQuantity){

    if(ProductQuantity <= 0){
                    throw new ArgumentException("You can not add 0 items");
                }        
            else{
                   this.ProductID =ProductID;

            this.StoreID = StoreID;

            this.ProductQuantity = ProductQuantity;
                }   
               
        }


        






    }
}
