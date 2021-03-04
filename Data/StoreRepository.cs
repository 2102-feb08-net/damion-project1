using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Data
{

    public class StoreRepository : IStore
    {
        private readonly DamionBuyContext _context;

        public StoreRepository(DamionBuyContext context)
        {
            _context = context;
        }

        public void AddStore(Models.Store store)
        {
            Store newstore = new Store()
                {

                StoreName = "ElectoBuy",
                StoreLocationAddress = store.StoreLocationAddress,
                StoreLocationCity = store.StoreLocationCity,
                StoreLocationState = store.StoreLocationState,
                StoreLocationCountry = store.StoreLocationCountry,
                StoreLocationZip = store.StoreLocationZip,
                StorePhoneNumber = store.StorePhoneNumber,
                };
                _context.Add(newstore);
                _context.SaveChanges();
        }

        public List<Models.Store> AllStores()
        {
            var database_stores = _context.Stores;

            List<Models.Store> AllStores = new List<Models.Store>();

            foreach(var store in database_stores){
                AllStores.Add(new Models.Store(store.Id, store.StoreLocationAddress, store.StoreLocationCity, store.StoreLocationState, store.StoreLocationCountry, store.StoreLocationZip, store.StorePhoneNumber));
            }

            return AllStores;
        }

        public Models.Store FindStore(string phone_number)
        {
                Models.Store newfoundstore = new Models.Store();


                 Store query = _context.Stores.Where(x => x.StorePhoneNumber.Equals(phone_number)).First();

                  if( query == null){

                    newfoundstore = null;

                    }       

                else{

                    newfoundstore.StoreLocationAddress = query.StoreLocationAddress;

                    newfoundstore.StoreLocationCity = query.StoreLocationCity;

                    newfoundstore.StoreLocationState = query.StoreLocationState;
                    newfoundstore.StoreLocationCountry = query.StoreLocationCountry;

                    newfoundstore.StoreLocationZip = query.StoreLocationCountry;
                    newfoundstore.StorePhoneNumber = query.StorePhoneNumber;

                     }

                return newfoundstore;
        }
    }
    }
