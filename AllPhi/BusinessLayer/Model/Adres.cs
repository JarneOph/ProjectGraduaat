using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    public class Adres
    {
        public Adres(string straat, string stad, int postcode, int nummer)
        {
            Straat = straat;
            Stad = stad;
            Postcode = postcode;
            Nummer = nummer;
        }

        public string Straat { get; }
        public string Stad { get; }
        public int Postcode { get; }
        public int Nummer { get; }


    }
}
