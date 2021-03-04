using System;
using System.Text.Json.Serialization;

namespace Models
{

    public class Store
    {


        public int Id { get; set; }
        public string StoreName = "ElectoBuy";
        public string StoreLocationAddress { get; set; }
        public string StoreLocationCity { get; set; }
        public string StoreLocationState { get; set; }
        public string StoreLocationCountry { get; set; }
        public string StoreLocationZip { get; set; }
        public string StorePhoneNumber { get; set; }


        public Store()
        {
            
        }


        public Store(int Id, string StoreLocationAddress,string StoreLocationCity, string StoreLocationState,string StoreLocationCountry,string StoreLocationZip, string StorePhoneNumber )
        {

            this.Id= Id;

            this.StoreLocationAddress =StoreLocationAddress;

            this.StoreLocationCity = StoreLocationCity;

            this.StoreLocationState = StoreLocationState;

            this.StoreLocationCountry = StoreLocationCountry;

            this.StoreLocationZip = StoreLocationZip;
            this.StorePhoneNumber = StorePhoneNumber;

            
        }


         public Store(string StoreLocationAddress,string StoreLocationCity, string StoreLocationState,string StoreLocationCountry,string StoreLocationZip, string StorePhoneNumber )
        {
            this.StoreLocationAddress =StoreLocationAddress;

            this.StoreLocationCity = StoreLocationCity;

            this.StoreLocationState = StoreLocationState;

            this.StoreLocationCountry = StoreLocationCountry;

            this.StoreLocationZip = StoreLocationZip;
            this.StorePhoneNumber = StorePhoneNumber;

            
        }






    }
}
