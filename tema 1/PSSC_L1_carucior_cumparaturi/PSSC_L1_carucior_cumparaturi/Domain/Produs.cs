using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace PSSC_L1_carucior_cumparaturi.Domain
{
    public record Produs
    {
        public static readonly Regex validareCod = new("^P[0-9]{3}$");

        public int cantitate { get; set; }
        public string cod { get; }
        public Adresa adresa { get; }

        public string denumire { get; }

        public Produs(string denumire,int cantitate, string cod, Adresa adresa)
        {
            if (cantitate > 0 && cantitate <= 100)
            {
                this.cantitate = cantitate;
                if (validareCod.IsMatch(cod))
                { 
                    this.cod = cod; 
                }
                else 
                { 
                    Console.WriteLine("Codul introdus este invalid!"); 
                }
            }
            else
            {
                Console.WriteLine("Cantitatea introdusa este invalida!");
            }
            this.adresa = adresa;
            this.denumire = denumire;
        }
        
        public override string ToString()
        {
            return $"{denumire}, cantitate:{cantitate}, cod: {cod} ,{adresa} ";
        }
    }
}
