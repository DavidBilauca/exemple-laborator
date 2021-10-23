using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PSSC_L1_carucior_cumparaturi.Domain
{
    public record Adresa
    {
        public string Tara { get; }
        public string Localitate { get; }
        public string Strada { get; }
        public int Numar { get; }

        public Adresa(string tara,string localitate,string strada,int numar)
        {
            Tara = tara;
            Localitate = Localitate;
            Strada = strada;
            Numar = numar;
        }

        public override string ToString()
        {
            return $"{Tara}, {Localitate}, Str.{Strada}, nr.{Numar} ";
        }

    }
}
