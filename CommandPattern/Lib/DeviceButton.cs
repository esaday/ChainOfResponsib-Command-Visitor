using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Lib
{
    class DeviceButton //Invoker
    {
        Command theCommand;

        public DeviceButton(Command newCommand)
        {
            theCommand = newCommand;
        }

        public void Press()
        {
            theCommand.Execute();
        }

    }
}
