using ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Base;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Dtos;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Interfaces;
using System;
using System.Collections.Generic;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Handlers
{
    public class ProcessingRequestHandler : BaseHandler, IHandler<Dto>
    {
        public override bool Handle(Dto baseRequest)
        {
            if (!(baseRequest is ProcessingHandlerRequestDto))
            {
                var errorDto = new ErrorDto()
                {
                    ErrorMessages = new List<string>() { "Invalid type sent to Handler" },
                    HandlerName = nameof(ProcessingRequestHandler),
                    Success = false
                };

                SetNext(new ErrorHandler());
                return base.Handle(errorDto);
            }

            Console.WriteLine("Processing Request Is Executed!");

            return base.Handle(baseRequest);
        }
    }
}
