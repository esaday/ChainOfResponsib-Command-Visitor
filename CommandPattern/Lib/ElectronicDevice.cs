using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Lib
{
    interface ElectronicDevice //abst. reciever
    {
        void On();
        void Off();
        void VolumeUp();
        void VolumeDown();
    }
}
