using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpeak
{
    class Dog : ISpeak
    {
        public Dog()
        {
        }

        public void Speak()
        {
            Console.WriteLine("Woof");
        }
    }
}
