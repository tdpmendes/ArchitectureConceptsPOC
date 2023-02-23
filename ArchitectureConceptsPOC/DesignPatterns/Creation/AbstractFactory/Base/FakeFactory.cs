using ArchitectureConceptsPOC.SOLID.AbstractFactory.Base.Interfaces;
using ArchitectureConceptsPOC.SOLID.AbstractFactory.Model;
using Bogus;

namespace ArchitectureConceptsPOC.SOLID.AbstractFactory.Base
{
    public class FakeFactory : IBaseFactory
    {
        public FakeFactory()
        {

        }

        private string[] fakeLawyers = new string[] { "Adrian", "Bruno", "Carlos" };
        public Model.Person CreateLawyer()
        {
            return new Faker<Lawyer>().RuleFor(x => x.Name, 
                                               y => y.PickRandom(fakeLawyers))
                                      .Generate();
        }

        private string[] fakeTeachers = new string[] { "Damian", "Edward", "Fabian" };
        public Model.Person CreateTeacher()
        {
            return new Faker<Teacher>().RuleFor(x => x.Name,
                                                y => y.PickRandom(fakeTeachers))
                                       .Generate();
        }
    }
}
