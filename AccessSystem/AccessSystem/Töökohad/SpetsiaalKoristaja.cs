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
            AccessToMainDoor = true;
            AccessToSoftWareDevRoom = true;
            AccessToBossRoom = true;
            AccessToKöök = true;
            AccessToDataWorkerRoom = true;
        }
    }
}
