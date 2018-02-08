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
            AccessToMainDoor = true;
            AccessToSoftWareDevRoom = false;
            AccessToBossRoom = false;
            AccessToKöök = true;
            AccessToDataWorkerRoom = true;
        }
    }
}
