using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Lib;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectronicDevice aDevice = new Television();

            Command OnCommand = new TurnTVOff(aDevice);

            DeviceButton OnPressed = new DeviceButton(OnCommand);

            OnPressed.Press(); //executing task using command!

            OnCommand = new TurnTVOn(aDevice);

             OnPressed = new DeviceButton(OnCommand);

            OnPressed.Press();

            Console.ReadKey();
           
        }
    }
}
