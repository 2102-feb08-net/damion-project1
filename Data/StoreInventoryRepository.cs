using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Data
{

    public class StoreInventoryRepository : Istoreinventory
    {
        private readonly DamionBuyContext _context;

        public StoreInventoryRepository(DamionBuyContext context)
        {
            _context = context;
        }

      

        public List<Models.StoreInventory> ViewStoreInventory(string store_phonenumber)

        {


            Models.Store newfoundstore = new Models.Store();


            Store storequery = _context.Stores.Where(x => x.StorePhoneNumber.Equals(store_phonenumber)).First();
            if (storequery == null)
            {

                newfoundstore = null;

            }

            else
            {
                newfoundstore.Id = storequery.Id;


                newfoundstore.StoreLocationAddress = storequery.StoreLocationAddress;

                newfoundstore.StoreLocationCity = storequery.StoreLocationCity;

                newfoundstore.StoreLocationState = storequery.StoreLocationState;
                newfoundstore.StoreLocationCountry = storequery.StoreLocationCountry;

                newfoundstore.StoreLocationZip = storequery.StoreLocationCountry;
                newfoundstore.StorePhoneNumber = storequery.StorePhoneNumber;

            }


            List<Models.StoreInventory> storeinventory = new List<Models.StoreInventory>();


            List<StoreInventory> query = _context.StoreInventories.Where(x => x.StoreId.Equals(newfoundstore.Id)).ToList();

            if (query == null)
            {

                storeinventory = null;

            }

            else
            {
                foreach (var item in query)
                {
                    Models.StoreInventory storei = new Models.StoreInventory();
                    storei.Id = item.Id;

                    storei.ProductID = item.ProductId;
                    storei.StoreID = item.StoreId;

                    storei.ProductQuantity = item.ProductQuantity;
                    storeinventory.Add(storei);

                }

            }

            return storeinventory;
        }

        void Istoreinventory.Updateinventory(string store_phonenumber, string product, int quantity)
        {

            Store storequery = _context.Stores.Where(x => x.StorePhoneNumber.Equals(store_phonenumber)).First();
            Models.Product newproduct = new Models.Product();
            
            
             Product productquery = _context.Products.Where(x => x.ProductName.Equals(product)).First();

            StoreInventory storeInventory = _context.StoreInventories.FirstOrDefault(x => x.StoreId.Equals(storequery.Id) && x.ProductId == productquery.Id);

            if (storeInventory == null)
            {

                StoreInventory storei = new StoreInventory();
                storei.ProductId = productquery.Id;
                storei.ProductQuantity = quantity;
                storei.StoreId = storequery.Id;

                _context.Add(storei);
                _context.SaveChanges();





            }
            else{

                storeInventory.ProductQuantity = quantity;
                _context.Update(storeInventory);
                _context.SaveChanges();
            }








    }
    }
}

