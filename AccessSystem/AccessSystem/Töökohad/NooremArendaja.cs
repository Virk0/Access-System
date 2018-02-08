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
            AccessToMainDoor = true;
            AccessToSoftWareDevRoom = true;
            AccessToBossRoom = false;
            AccessToKöök = true;
            AccessToDataWorkerRoom = false;
        }
    }
}
