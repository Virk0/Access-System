using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSystem
{
    class SpetsiaalKoristaja : Töökoht
    {
        public SpetsiaalKoristaja()
        {
            Name = "Special Cleaner";
            bool AccessToMainDoor = true;
            bool AccessToSoftWareDevRoom = true;
            bool AccessToBossRoom = true;
            bool AccessToKöök = true;
            bool AccessToDataWorkerRoom = true;
        }
    }
}
