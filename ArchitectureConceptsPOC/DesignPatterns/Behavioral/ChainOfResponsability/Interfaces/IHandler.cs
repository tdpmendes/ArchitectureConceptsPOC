using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Interfaces
{
    public interface IHandler<Dto>
    {
        public void SetNext(IHandler<Dto> handler);

        public bool Handle(Dto request) { return false; }
    }
}
