using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Models
{ 

    public class StoreInventoryDTO{

         public string phonenumber{get;set;}

         public string productname {get;set;}

         public int quantity {get;set;}

       public StoreInventoryDTO(){}

    }





}