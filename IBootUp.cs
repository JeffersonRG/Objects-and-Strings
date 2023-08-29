using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_and_Strings
{
    internal interface IBootUp
    {

        //enables the "Computer" and indicates whether it is starting up or shutting down in response to the PowerOnOff command.
        public bool IsOn { get; set; }

        public void powerOnOff();

    }
}
