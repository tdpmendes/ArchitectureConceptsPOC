using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Proxy
{
    public class Service : IService
    {
        public void Operation()
        {
            Console.WriteLine("Real Operation");
        }
    }
}
