using ArchitectureConceptsPOC.SOLID.AbstractFactory.Model;

namespace ArchitectureConceptsPOC.SOLID.AbstractFactory.Base.Interfaces
{
    public interface IBaseFactory
    {
        public Person CreateTeacher();
        public Person CreateLawyer();
    }
}
