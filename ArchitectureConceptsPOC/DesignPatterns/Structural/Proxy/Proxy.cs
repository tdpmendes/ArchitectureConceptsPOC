using System;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Proxy
{
    public class Proxy : IService
    {
        private IService _realService;

        private bool accessAllowed = true;
        
        public Proxy(IService service)
        {
            _realService = service ?? throw new ArgumentNullException(nameof(service));
        }
        public void Operation()
        {
            if (CheckAccess()) _realService.Operation();
            else Console.WriteLine("Access Denied");
        }

        private bool CheckAccess()
        {
            return accessAllowed;
        }
    }
}
