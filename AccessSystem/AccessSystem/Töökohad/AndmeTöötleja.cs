using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSystem
{
    public class AndmeTöötleja : Töökoht
    {
        public AndmeTöötleja()
        {
            Name = "Data Worker";
            bool AccessToMainDoor = true;
            bool AccessToSoftWareDevRoom = false;
            bool AccessToBossRoom = false;
            bool AccessToKöök = true;
            bool AccessToDataWorkerRoom = true;
        }
    }
}
