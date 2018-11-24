using System;
using Microsoft.AspNetCore.Mvc;

namespace SoftPlayer.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class HomeController
    {
        [HttpGet]
        public string Index()
        {
            return "Bem vindo!";
        }

        [HttpGet]
        public string showmethecode()
        {
            return "https://github.com/ajuniortorres/projetoteste";
        }

        [HttpGet]
        public string calculajuros(
            string valorinicial, string meses)
        {
            string retorno = "";

            try
            {
                double vlinicial = Convert.ToDouble(valorinicial);
                double juros = 0.01;
                double tempo = Convert.ToInt16(meses);

                double valorfinal = vlinicial * Math.Pow((1 + juros), tempo);
                valorfinal = (double)TruncateFunction((decimal)valorfinal, 2);

                return valorfinal.ToString("n2");
            }
            catch (Exception exc)
            {
                string erro = exc.Message;
                retorno = "erro";
            }

            return retorno;
        }

        private decimal TruncateFunction(decimal number, int digits)
        {
            decimal stepper = (decimal)(Math.Pow(10.0, (double)digits));
            int temp = (int)(stepper * number);
            return (decimal)temp / stepper;
        }
    }
}
