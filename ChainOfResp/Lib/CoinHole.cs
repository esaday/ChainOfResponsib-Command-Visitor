using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp.Lib
{
    class CoinHole : Chain
    {
        private int holeNumber;
        private Chain _nextChain;
        bool _isOccupied = false;

        public bool IsOccupied
        {
            get
            {
                return _isOccupied;
            }

            set
            {
                _isOccupied = value;
            }
        }

        public int HoleNumber
        {
            get
            {
                return holeNumber;
            }

            set
            {
                holeNumber = value;
            }
        }
        public CoinHole(int number)
        {
            HoleNumber = number;
        }
        public void SetNextChain(Chain nextChain)
        {
            _nextChain = nextChain;
        }

        public void SortTheCoin(Coin coin)
        {
            if (!IsOccupied)
            {
                if (coin.CoinVal == 1f)
                {
                    Console.WriteLine("Hole number" + HoleNumber + "    This coin is one and sorted");
                }
                else if (coin.CoinVal == 0.5f)
                {
                    Console.WriteLine("Hole number" + HoleNumber + "    This coin is half and sorted");
                    IsOccupied = true; //demonstration purpose
                }
                else if (coin.CoinVal == 0.25f)
                {
                    Console.WriteLine("Hole number" + HoleNumber + "    This coin is quarter and sorted");

                }
                else
                {
                    Console.WriteLine("Hole number" + HoleNumber + "    I dont recognize this!");
                }
            }
           
            else
            {
                if (_nextChain != null)
                    _nextChain.SortTheCoin(coin);
                else
                    Console.WriteLine("This coin couldn't be sorted, putting it back to tray.");
            }
        }
    }
}
