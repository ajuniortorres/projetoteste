using System;
using Xunit;
using SoftPlayer.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Testes
{
    public class UnitTest1
    {
        [Fact]
        public void Testar()
        {
            HomeController controller = new HomeController();
            string result = controller.Calculajuros("100", "5");

            Assert.Equal("105,10", result);
        }

        [Fact]
        public void TestarErro()
        {
            HomeController controller = new HomeController();
            string result = controller.Calculajuros("ASD", "ASD");

            Assert.Equal("erro", result);
        }
    }
}
