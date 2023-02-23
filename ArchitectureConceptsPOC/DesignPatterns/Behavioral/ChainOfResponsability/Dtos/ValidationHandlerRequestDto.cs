using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Dtos
{
    public class ValidationHandlerRequestDto : Dto
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
