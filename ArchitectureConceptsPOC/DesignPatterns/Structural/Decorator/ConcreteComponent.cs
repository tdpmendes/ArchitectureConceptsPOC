using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Decorator
{
    public class ConcreteComponent : IComponent
    {
        public void Execute()
        {
            Console.WriteLine("Executou ConcreteComponent.");
        }
    }
}
