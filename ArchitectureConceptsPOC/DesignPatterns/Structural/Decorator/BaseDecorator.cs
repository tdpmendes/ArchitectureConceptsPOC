using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Decorator
{
    public class BaseDecorator : IComponent
    {
        protected IComponent _component;

        public BaseDecorator(IComponent component)
        {
            _component = component ?? throw new ArgumentNullException(nameof(component));
        }

        public virtual void Execute()
        {
            Console.WriteLine("Executando BaseDecorator");
            _component.Execute();
        }
    }
}
