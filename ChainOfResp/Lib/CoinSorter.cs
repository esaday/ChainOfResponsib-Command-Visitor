using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp.Lib
{
    public class CoinSorter
    {
        private Chain _holeOne = new CoinHole(1);
        private Chain _holeTwo = new CoinHole(2);
        private Chain _holeThree = new CoinHole(3);
        
        public CoinSorter()
        {
            _holeOne.SetNextChain(_holeTwo);
            _holeTwo.SetNextChain(_holeThree);
            _holeThree.SetNextChain(null);
            

            Demonstrate();
        }

        public void Demonstrate()
        {
            List<Coin> coins = new List<Coin>();
            coins.Add(new Coin(1f, "bktx"));
            coins.Add(new Coin(0.5f, "bktx"));
            coins.Add(new Coin(0.25f, "bktx"));
            coins.Add(new Coin(0.25f, "bktx"));
            coins.Add(new Coin(1f, "bktx"));
            coins.Add(new Coin(3f, "bktx"));


            foreach (var item in coins)
            {
                _holeOne.SortTheCoin(item);
                (_holeOne as CoinHole).IsOccupied = true;
            }

        }





    }
}
