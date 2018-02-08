using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSystem
{
    class Ülemus : Töökoht
    {
        public Ülemus()
        {
            Name = "Boss";
            AccessToMainDoor = true;
            AccessToSoftWareDevRoom = true;
            AccessToBossRoom = true;
            AccessToKöök = true;
            AccessToDataWorkerRoom = true;
        }
    }
}
