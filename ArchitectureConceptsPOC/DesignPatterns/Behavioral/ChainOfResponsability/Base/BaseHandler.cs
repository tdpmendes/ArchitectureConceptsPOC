using ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Interfaces;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Dtos;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Base
{
    public class BaseHandler : IHandler<Dto>
    {
        private IHandler<Dto> _next;

        public virtual bool Handle(Dto request)
        {
            if (_next != null) _next.Handle(request);
            return true;
        }

        public void SetNext(IHandler<Dto> handler)
        {
            _next = handler;
        }
    }
}
