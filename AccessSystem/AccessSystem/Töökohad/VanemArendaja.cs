﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSystem
{
    class VanemArendaja : Töökoht
    {
        public VanemArendaja()
        {
            Name = "Older Software Developer";
            AccessToMainDoor = true;
            AccessToSoftWareDevRoom = true;
            AccessToBossRoom = true;
            AccessToKöök = true;
            AccessToDataWorkerRoom = true;
        }
    }
}
