using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Dtos
{
    public class ErrorDto : Dto
    {
        public IList<string> ErrorMessages {get;set;}
        public string HandlerName { get; set; }
        public bool Success { get; set; } = true;
    }
}
