using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Decorator
{
    public class ConcreteDecorator : BaseDecorator
    {
        public ConcreteDecorator(IComponent component) : base(component)
        {
            _component = component ?? throw new ArgumentNullException(nameof(component));
        }

        public override void Execute()
        {
            base.Execute();
            Console.WriteLine("Executando Concrete Decorator");
        }
    }
}
