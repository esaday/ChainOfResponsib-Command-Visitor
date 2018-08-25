using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp.Lib
{
     class One : Chain
    {
        private Chain _nextChain;

        public void SetNextChain(Chain nextChain)
        {
            _nextChain = nextChain;
        }

        public void SortTheCoin(Coin coin)
        {
            if (coin.CoinVal == 1f)
            {
                Console.WriteLine("This coin is one and sorted");
            }
            else
            {
                _nextChain.SortTheCoin(coin);
            }
        }
    }
}
