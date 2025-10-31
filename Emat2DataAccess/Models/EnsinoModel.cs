using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emat2DataAccess.Models;

public class EnsinoModel
{
    public int Id { get; set; }
    public required string EnsinoNome { get; set; }
    
    //TODO: Implementar atributo para integrar na SED (TipoEnsino
}
