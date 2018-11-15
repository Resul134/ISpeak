using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpeak
{
    class Philosopher : ISpeak
    {


        public void Speak()
        {
            Console.WriteLine("Wooow");
        }

        public void Think()
        {
            Console.WriteLine("hmmmmm");
        }
    }
}
