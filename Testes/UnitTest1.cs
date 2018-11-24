using Xunit;
using SoftPlayer.Controllers;

namespace Testes
{
    public class UnitTest1
    {
        [Fact]
        public void Testar()
        {
            HomeController controller = new HomeController();
            string result = controller.calculajuros("100", "5");

            Assert.Equal("105,10", result);
        }

        [Fact]
        public void TestarErro()
        {
            HomeController controller = new HomeController();
            string result = controller.calculajuros("ASD", "ASD");

            Assert.Equal("erro", result);
        }

        [Fact]
        public void TestarURL()
        {
            HomeController controller = new HomeController();
            string result = controller.showmethecode();

            Assert.Equal("https://github.com/ajuniortorres/projetoteste",
                result);
        }
    }
}
