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
    }


    }


    

