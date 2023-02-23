using ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Base;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Dtos;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Interfaces;
using System;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Handlers
{
    public class ErrorHandler : BaseHandler , IHandler<Dto>
    {
        public override bool Handle(Dto request)
        {
            if (!(request is ErrorDto))
            {
                throw new Exception("Invalid Type sent to ErrorHandler, should send only ErrorDto objects");
            }

            var errorDto = (ErrorDto)request;

            Console.WriteLine($"There was an error on {errorDto.HandlerName}");
            Console.WriteLine($"Messages: ");
            foreach (var message in errorDto.ErrorMessages)
            {
                Console.WriteLine(message);

            }
            return base.Handle(new Dto());
        }
    }
}
