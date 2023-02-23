using ArchitectureConceptsPOC.SOLID.AbstractFactory.Base.Interfaces;
using ArchitectureConceptsPOC.SOLID.AbstractFactory.Model;
using System;

namespace ArchitectureConceptsPOC.SOLID.AbstractFactory.Base
{
    public abstract class AbstractFactory : IAbstractFactory
    {

        private IBaseFactory _realFactory;
        private IBaseFactory _fakeFactory;
        
        /* Potencial problema estrutural, 
         * Duas abstrações diferentes criadas apartir de uma mesma interface
         * Pode dar problema na hora do injetor de dependencia linkar os tipos às suas implementações
         */
        public AbstractFactory(IBaseFactory realFactory,
                               IBaseFactory fakeFactory)
        {
            _realFactory = realFactory ?? throw new ArgumentNullException(nameof(realFactory));
            _fakeFactory = fakeFactory ?? throw new ArgumentNullException(nameof(fakeFactory));
        }

        public Person CreateFakeLawyer() => _fakeFactory.CreateLawyer();

        public Person CreateFakeTeacher() => _fakeFactory.CreateTeacher();

        public Person CreateRealLawyer() => _realFactory.CreateLawyer();

        public Person CreateRealTeacher() => _realFactory.CreateTeacher();
    }
}
