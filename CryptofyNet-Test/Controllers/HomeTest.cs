using System;
using Xunit;
using Cryptofy_Net.Controllers;

namespace CryptofyNet_Test
{
    public class HomeTest
    {
        [Fact]
        public void sum()
        {
            var home_controller = new HomeController();
            var result = home_controller.Sum();
            Assert.Equal(10, result);
        }
    }
}
