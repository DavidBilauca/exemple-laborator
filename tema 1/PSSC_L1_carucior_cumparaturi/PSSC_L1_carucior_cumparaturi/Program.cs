using PSSC_L1_carucior_cumparaturi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using static PSSC_L1_carucior_cumparaturi.Domain.Carucior;

namespace PSSC_L1_carucior_cumparaturi
{
    class Program
    {
        public static List<Produs> listaProduseStoc;

        public static void IncarcareStoc()
        {
            listaProduseStoc.Add(new Produs(
                "Lapte la 1L",
                20,
                "L100",
                new Adresa("Romania", "Timisoara", "Calea Aradului", 56)
                ));
            listaProduseStoc.Add(new Produs(
                "Paine",
                100,
                "P100",
                new Adresa("Romania", "Timisoara", "Calea Aradului", 56)
                ));
            listaProduseStoc.Add(new Produs(
                "Covrigi",
                30,
                "P101",
                new Adresa("Romania", "Timisoara", "Calea Aradului", 56)
                ));
            listaProduseStoc.Add(new Produs(
                "Iaurt 500ml",
                25,
                "L101",
                new Adresa("Romania", "Timisoara", "Calea Aradului", 56)
                ));
            listaProduseStoc.Add(new Produs(
                "Cafea",
                20,
                "C100",
                new Adresa("Romania", "Timisoara", "Calea Aradului", 56)
                ));
        }

        static void Main(string[] args)
        {
            IncarcareStoc();


            var listaProduse = AdaugareProduse().ToArray();
            CaruciorNevalidat listaProduseNevalidate = new(listaProduse);
            ICarucior rezultat = ValidareCarucior(listaProduseNevalidate);
            rezultat.Match(
                whenCaruciorNevalidat: rezultatNevalidat => listaProduseNevalidate,
                whenCaruciorInvalidat: rezultatInvalidat => rezultatInvalidat,
                whenCaruciorPlatit: rezultatPlatit => rezultatPlatit,
                whenCaruciorValidat: rezultatValidat => PlatireCarucior(rezultatValidat)
            );
        }

        private static List<ProdusNevalidat> AdaugareProduse()
        {
            string opt;
            AfisareStoc();
            do {
                Console.WriteLine("Alegeti un produs (cod):");
                opt=Console.ReadLine();


                var rezultat = from p in listaProduseStoc
                               where p.cod == opt
                               select p;
                if(rezultat==null)


            } while (opt.CompareTo("exit")!=0);

            return null;
        }

        private static ICarucior ValidareCarucior(CaruciorNevalidat caruciorNevalidat) =>
            new CaruciorValidat(new List<ProdusValidat>());

        private static ICarucior PlatireCarucior(CaruciorValidat caruciorValidat) =>
            new CaruciorPlatit(new List<ProdusValidat>(), DateTime.Now);

        public static void AfisareStoc()
        {
            Console.WriteLine("Stoc:\n");
            foreach (Produs p in listaProduseStoc)
            {
                Console.WriteLine(p.ToString()+"\n");
                Console.WriteLine("-------------------------------------------\n");
            }
        }


    }
}
