using System;
using System.Collections.Generic;

namespace CoinJar
{
    enum eCoinType
    {
        Cent,
        Nickel,
        Dime,
        QuarterDollar,
        HalfDollar,
        NativeAmericanDollar,
        PresidentialDollar
    }
    public class CoinJar : Interfaces.ICoinJar
    {
        private List<Interfaces.ICoin> Coins { get; set; }
        public decimal JarMaxVolume { get; private set; }
        public decimal UsedVolume { get; private set; }
        public decimal TotAmount { get; private set; }
        public CoinJar()
        {
            this.Coins = new List<Interfaces.ICoin>();
            this.TotAmount = 0;
            this.JarMaxVolume = 42;
            this.UsedVolume = 0;
        }
        public void AddCoin(Interfaces.ICoin coin)
        {
            if(coin == null)
                throw new CoinNullException();

            //if (coin.GetType().BaseType != typeof(eCoinType))
            //    throw new InValidCoinException("The coin jar only accepts US Coin.");

            if (this.JarMaxVolume < (this.UsedVolume + coin.Volume))
                throw new CoinOverFlowException();

            this.Coins.Add(coin);
            this.TotAmount += coin.Amount;
            this.UsedVolume += coin.Volume;
        }
        public decimal GetTotalAmount()
        {
            return TotAmount;
        }
        public void Reset()
        {
            Coins = new List<Interfaces.ICoin>();
            TotAmount = 0;
            UsedVolume = 0;
            JarMaxVolume = 42;
        }
    }
    public class InValidCoinException : Exception
    {
        public InValidCoinException(string message)
            : base(message)
        {
        }
    }
    public class CoinOverFlowException : Exception
    {
        public CoinOverFlowException()
            : base("Coin Volume exceeded.")
        {
        }
    }
    public class CoinNullException : NullReferenceException
    {
        public CoinNullException()
            : base("Coin is null.")
        {
        }
    }                                                                               
}
