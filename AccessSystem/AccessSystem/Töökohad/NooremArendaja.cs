using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSystem
{
    public class NooremArendaja : Töökoht
    {
        public NooremArendaja()
        {
            Name = "Younger Software Developer";
            bool AccessToMainDoor = true;
            bool AccessToSoftWareDevRoom = true;
            bool AccessToBossRoom = false;
            bool AccessToKöök = true;
            bool AccessToDataWorkerRoom = false;
        }
    }
}
