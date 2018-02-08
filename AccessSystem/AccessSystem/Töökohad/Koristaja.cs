using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSystem
{
   public class Koristaja : Töökoht
    {
        public Koristaja()
        {
            Name = "Cleaner";
            AccessToMainDoor = true;
            AccessToSoftWareDevRoom = true;
            AccessToBossRoom = false;
            AccessToKöök = true;
            AccessToDataWorkerRoom = true;
        }
    }
}
