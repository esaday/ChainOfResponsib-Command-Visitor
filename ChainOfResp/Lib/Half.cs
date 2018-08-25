using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp.Lib
{
    class Half : Chain
    {
        private Chain _nextChain;

        public void SetNextChain(Chain nextChain)
        {
            _nextChain = nextChain;
        }

        public void SortTheCoin(Coin coin)
        {
            if (coin.CoinVal == 0.5f)
            {
                Console.WriteLine("This coin is half and sorted");
            }
            else
            {
                _nextChain.SortTheCoin(coin);
            }
        }
    }
}
