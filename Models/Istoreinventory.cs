using System;
using System.Collections.Generic;

namespace Models
{
    public interface Istoreinventory
    {

        public void Updateinventory(string store_phonenumber, string productname, int quantity );
        public List<StoreInventory> ViewStoreInventory(string store_phonenumber); 



      
    }
}
