﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpeak
{
    class Cow : ISpeak
    {
        public Cow()
        {
        }

        public void Speak()
        {
            Console.WriteLine("Moooo");
        }
    }
}
