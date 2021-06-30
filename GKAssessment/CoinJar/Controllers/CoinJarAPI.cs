using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar.Controllers
{
    [ApiController]
    [Route("coin")]
    public class CoinJarAPI : ControllerBase
    {
        private readonly CoinJar _coinJar;
        public CoinJarAPI()
        {
            _coinJar = new CoinJar();

        } 
        [HttpGet]
        public IActionResult GetTotAmount()
        {
            return Ok(_coinJar.GetTotalAmount());
        }
        [HttpPost] 
        public string AddCoin(Interfaces.ICoin coin)
        {
            _coinJar.AddCoin(coin);
            return "Coin Added to jar";
        }
        [HttpPut]
        public IActionResult ResetJar()
        {
            _coinJar.Reset();
            return Ok();
        }
    }
}
