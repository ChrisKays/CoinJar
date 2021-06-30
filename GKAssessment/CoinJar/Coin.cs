using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    public class Coin : Interfaces.ICoin
    {
        private decimal _amount;
        private decimal _volume;
        public decimal Amount
        {
            get => _amount;
            set => _amount = value;
        }
        public decimal Volume
        {
            get => _volume;
            set => _volume = value;
        }
    }
}
