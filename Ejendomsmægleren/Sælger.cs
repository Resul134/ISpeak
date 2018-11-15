using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejendomsmægleren
{
    class Sælger : Regler, Regler2
    {
        public string Adresse { get; set; }
        public int ID { get; set; }
        public string Navn { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
    }
}
