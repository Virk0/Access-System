﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSystem
{
    public abstract class Töökoht
    {
        public string Name;
        public int Access_lvl;

        public virtual string defineJob()
        {
            Console.WriteLine("This job is called " + Name);
            Console.WriteLine("My job has an access level of " + Access_lvl);
            return Name;
        }
    }
}
