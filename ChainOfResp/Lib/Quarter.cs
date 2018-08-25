using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp.Lib
{
    public class Quarter : Chain
    {
        private Chain _nextChain;

        public void SetNextChain(Chain nextChain)
        {
            _nextChain = nextChain;
        }

        public void SortTheCoin(Coin coin)
        {
            if (coin.CoinVal == 0.25f)
            {
                Console.WriteLine("This coin is quarter and sorted");
            }
            else
            {
                Console.WriteLine("I dont know what is this");
            }
        }
    }
}
