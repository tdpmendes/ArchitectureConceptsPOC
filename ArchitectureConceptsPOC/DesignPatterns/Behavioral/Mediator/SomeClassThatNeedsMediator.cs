using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Mediator
{
    public class SomeClassThatNeedsMediator: ISomeClassThatNeedsMediator
    {
        private readonly IMediator _mediator;
        public SomeClassThatNeedsMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Execute()
        {
            var request = new SomeMediatorRequestDto();
            _mediator.Send(request);
        }
    }
}
