using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejendomsmægleren
{
    class Ejendomme : Regler
    {
        private int _id;
        private string _type;
        private string _adresse;
        private double _pris;
        private string _størrelse;

        public string Størrelse
        {
            get { return _størrelse; }
            set { _størrelse = value; }
        }

        public double Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public string Type1
        {
            get { return _type; }
            set { _type = value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
