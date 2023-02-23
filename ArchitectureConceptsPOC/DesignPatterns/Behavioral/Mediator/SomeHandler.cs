using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Mediator
{
    public class SomeHandler : IRequestHandler<SomeMediatorRequestDto, SomeMediatorResponseDto>
    {
        public SomeHandler()
        {
        }

        public async Task<SomeMediatorResponseDto> Handle(SomeMediatorRequestDto request, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested) Console.WriteLine("Aborted");
            Console.WriteLine("SomeHandler has Run!");
            return new SomeMediatorResponseDto();
        }
    }
}
