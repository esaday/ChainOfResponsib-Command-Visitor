using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Lib
{
    class Television : ElectronicDevice //concrete reciever
    {
        private int volume = 0;

        public void Off()
        {
            Console.WriteLine("TV is off");
        }

        public void On()
        {
            Console.WriteLine("TV is on");
        }

        public void VolumeDown()
        {
            volume++;
            Console.WriteLine("TV volume is at" + volume);
        }

        public void VolumeUp()
        {
            volume--;
            Console.WriteLine("TV volume is at" + volume);
        }
    }
}
