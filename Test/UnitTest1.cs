using System;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void UserCreation()
        {
                Models.User u = new Models.User();
                Assert.NotNull(u);
                
        }


           [Fact]
        public void StoreName()
        {
                Models.Store name = new Models.Store();
                Assert.Equal("ElectoBuy", name.StoreName);
                
        }


              [Fact]
        public void StoreCreation()
        {
                Models.Store name = new Models.Store();
                Assert.NotNull(name);
                
        }


                  [Fact]
        public void ProductCreation()
        {
                Models.Product name = new Models.Product();
                Assert.NotNull(name);
                
        }



                 [Fact]
        public void OrderNotNull()
        {
                Models.Order name = new Models.Order();
                Assert.NotNull(name);
                
        }




               [Fact]
        public void StoreInventoryNotNull()
        {
                Models.StoreInventory name = new Models.StoreInventory();
                Assert.NotNull(name);
                
        }




        
               [Fact]
        public void OrderItemNotNull()
        {
                Models.OrderItems name = new Models.OrderItems();
                Assert.NotNull(name);
                
        }
    }


    }


    

