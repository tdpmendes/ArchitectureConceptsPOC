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

        public async void Execute()
        {
            var request = new SomeMediatorRequestDto();
            var response = await _mediator.Send(request);
        }
    }
}
