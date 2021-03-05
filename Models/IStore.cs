using System;
using System.Collections.Generic;

namespace Models
{
    public interface IStore
    {

        public void AddStore(Store store);

        public Store FindStore(string phone_number);

        public List<Store> AllStores();

        public Store FindStoreById(int id);

        public List<Order> FindStoreOrderHistory(int id);

        


    }
}
