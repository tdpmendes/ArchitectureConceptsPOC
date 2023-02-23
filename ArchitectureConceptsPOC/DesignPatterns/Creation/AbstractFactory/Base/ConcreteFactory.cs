using ArchitectureConceptsPOC.SOLID.AbstractFactory.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.SOLID.AbstractFactory.Base
{
    public class ConcreteFactory : AbstractFactory
    {
        public ConcreteFactory(IBaseFactory realFactory, 
                               IBaseFactory fakeFactory) : base(realFactory, fakeFactory)
        {
        }
    }
}
