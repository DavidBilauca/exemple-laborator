using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC_L1_carucior_cumparaturi.Domain
{
    public record ProdusNevalidat(String? denumire, int? cantitate, string? cod, Adresa? adresa);
    
}
