using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.SOLID.AbstractFactory.Base.Interfaces
{
    public interface IAbstractFactory
    {
        public Model.Person CreateFakeTeacher();
        public Model.Person CreateRealTeacher();
        public Model.Person CreateFakeLawyer();
        public Model.Person CreateRealLawyer();

    }
}
