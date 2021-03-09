using System;
using System.Collections.Generic;

namespace Models
{
    public interface IOrder
    {

       public int AddOrder(Models.Order customerorder);

        public int DeleteOrder(Models.Order customerorder);
       public void AddOrderLine(OrderItems OrderItemLineList);

       public void ChangeInventory(int id, int quantity, int productid);

       public List<Order> ReturnAllOrdersBasedOnCustomer(int id);
       

       


    }
}
