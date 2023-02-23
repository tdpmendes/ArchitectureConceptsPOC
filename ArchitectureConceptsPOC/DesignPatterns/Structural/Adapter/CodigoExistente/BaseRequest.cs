using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Adapter.CodigoExistente
{
    public class BaseRequest
    {
        public int Id { get; set; }
        public IDictionary<string,string> Parametros { get; set; }
    }
}
