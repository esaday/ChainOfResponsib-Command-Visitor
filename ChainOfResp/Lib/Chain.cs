using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp.Lib
{
    public interface Chain
    {
        void SetNextChain(Chain nextChain);
        void SortTheCoin(Coin coin);


    }
}
