using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Lib
{
    class TurnTVOn : Command // concrete command
    {
        ElectronicDevice theDevice;

        public TurnTVOn(ElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }

        public void Execute()
        {
            theDevice.On();
        }
    }

    class TurnTVOff : Command // concrete command
    {
        ElectronicDevice theDevice;

        public TurnTVOff(ElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }

        public void Execute()
        {
            theDevice.Off();
        }
    }

    class TurnTVUp : Command // concrete command
    {
        ElectronicDevice theDevice;

        public TurnTVUp(ElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }

        public void Execute()
        {
            theDevice.VolumeUp();
        }
    }
}
