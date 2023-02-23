using ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Base;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Dtos;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Handlers
{
    public class ValidationRequestHandler : BaseHandler, IHandler<Dto>
    {
        private IList<string> AllowedNames = new List<string>{ "Adrian", "Bruno", "Carlos"};
        private IList<string> AllowedDomains = new List<string>() { "gmail.com", "hotmail.com", "yahoo.com" };

        public override bool Handle(Dto baseRequest)
        {
            if (!(baseRequest is ValidationHandlerRequestDto))
            {
                var errorDto = new ErrorDto()
                {
                    ErrorMessages = new List<string>() { "Invalid type sent to Handler" },
                    HandlerName = this.GetType().Name,
                    Success = false
                };
                
                SetNext(new ErrorHandler());
                return base.Handle(errorDto);
            }

            var request = (ValidationHandlerRequestDto)baseRequest;
            Dto response;
            var errors = new ErrorDto();

            if (!AllowedNames.Contains(request.Name))
            {
                SetNext(new ErrorHandler());

                errors.HandlerName = nameof(ValidationRequestHandler);
                errors.ErrorMessages = new List<string>();
                errors.Success = false;
                
                errors.ErrorMessages.Add("Provided name is not allowed on Whitelist");
                response = errors;
            }

            if (!AllowedDomains.Contains(request.Email.Split('@')[1]))
            {
                if (errors.ErrorMessages == null) errors.ErrorMessages = new List<string>();
                
                errors.HandlerName = nameof(ValidationRequestHandler);
                errors.Success = false;
                errors.ErrorMessages.Add("Provided e-mail domain not allowed on Whitelist");
            }

            if (errors.ErrorMessages != null)
            {
                SetNext(new ErrorHandler());
                return base.Handle(errors);
            }

            var nextRequest = new ProcessingHandlerRequestDto() //new Dto()
            {
                //preenche
            };
            SetNext(new ProcessingRequestHandler());
            return base.Handle(nextRequest);
        }
    }
}
