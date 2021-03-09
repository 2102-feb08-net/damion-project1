using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Data
{

    public class OrderRepository : IOrder
    {
        private readonly DamionBuyContext _context;

        public OrderRepository(DamionBuyContext context)
        {
            _context = context;
        }

        int IOrder.AddOrder(Models.Order customerorder)
        {
            var AddOrder = _context.Orders.OrderBy( x =>  x.Id).Last();
            Order neworder = new Order();

            neworder.CustomerId = customerorder.CustomerID;
            neworder.DatePlaced = (DateTime)customerorder.Date;
            neworder.StoreId = customerorder.StoreID;

            _context.Add(neworder);

            _context.SaveChanges();

            return neworder.Id;

        }

        void IOrder.AddOrderLine(OrderItems OrderItemLineList)
        {
            

            Data.OrderItem orderline = new  Data.OrderItem(){
                Orderid = OrderItemLineList.Orderid,
                Productid = OrderItemLineList.Productid,
                Quantity = (int)OrderItemLineList.Quantity

            };

            
           


            _context.Add(orderline);
            _context.SaveChanges();

        }

        void IOrder.ChangeInventory(int id, int Quantity, int Prodid)
        {
      
        
                StoreInventory dbInventory = _context.StoreInventories
                    .Where(x =>  x.StoreId == id && x.ProductId == Prodid)
                    .First();

                dbInventory.ProductQuantity =  dbInventory.ProductQuantity - Quantity;
                
                

                _context.Update(dbInventory);
                _context.SaveChanges();
            

        
        }
    }
}