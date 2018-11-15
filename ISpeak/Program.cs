using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpeak
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISpeak> list = new List<ISpeak>();
            

            list.Add(new Cow());
            list.Add(new Dog());
            list.Add(new Philosopher());

            foreach (ISpeak s in list)
            {
                s.Speak();
            }

            ISpeak speeker = new Philosopher();
            speeker.Speak();
            // speeker.Think(); won't work because ISpeak does not have Think method

            Philosopher speeker2 = new Philosopher();
            speeker2.Think();
        }
    }
}
