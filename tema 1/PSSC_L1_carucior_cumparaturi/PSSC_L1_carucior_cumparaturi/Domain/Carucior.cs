using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Choices;

namespace PSSC_L1_carucior_cumparaturi.Domain
{
    public static partial class Carucior
    {
        public static List<Produs> ListaProduse;
    }

        [AsChoice]
    public static partial class Carucior
    {
        
        public interface ICarucior { }

        public record CaruciorGol():ICarucior;
        public record CaruciorNevalidat(IReadOnlyCollection<ProdusNevalidat> ListaProduse) : ICarucior;
        public record CaruciorInvalidat(IReadOnlyCollection<ProdusNevalidat> ListaProduse, string motiv) : ICarucior;
        public record CaruciorValidat(IReadOnlyCollection<ProdusValidat> ListaProduse) : ICarucior;
        public record CaruciorPlatit(IReadOnlyCollection<ProdusValidat> ListaProduse,DateTime dataPlatii) : ICarucior;
    }
}
