using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp.Lib
{
    public class Coin
    {
        private double _coinVal;
        private string _coinBackText;
        #region
        public double CoinVal
        {
            get
            {
                return _coinVal;
            }

        }

        public string CoinBackText
        {
            get
            {
                return _coinBackText;
            }

        }
        #endregion

        public Coin(double newVal, string backText)
        {
            _coinVal = newVal;
            _coinBackText = backText;
        }
    }
}
