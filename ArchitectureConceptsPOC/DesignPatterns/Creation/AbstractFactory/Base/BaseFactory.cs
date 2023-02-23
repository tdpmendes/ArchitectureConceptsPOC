using ArchitectureConceptsPOC.SOLID.AbstractFactory.Base.Interfaces;
using ArchitectureConceptsPOC.SOLID.AbstractFactory.Model;
using System;
using System.Collections.Generic;

namespace ArchitectureConceptsPOC.SOLID.AbstractFactory.Base
{
    public class BaseFactory : IBaseFactory
    {
        /*Sem Dependencias Ainda :D*/
        
        public BaseFactory()
        {

        }

        public Model.Person CreateLawyer()
        {
            return new Lawyer()
            {
                Id = Guid.NewGuid(),
                Addresses = new List<Address>()
                {
                    new Address()
                    {

                    },
                    new Address()
                    {

                    }
                },
                EmployerInfo = new LawFirm()
                {
                    Address = new Address()
                    {

                    },
                    Name = "Saul Goodman's",
                    Specialization = "Treachery >:3"
                },

                BirthDate = DateTime.Now.AddYears(-25),
                Name = "Jimmy",
                PreferredAddress = new Address()
                {

                },
                Registration = "ASDF1234"
            };
        }

        public Model.Person CreateTeacher()
        {
            return new Teacher()
            {
                Id = Guid.NewGuid(),
                RegistrationInfo = Guid.NewGuid(),
                Name = "Professor Layton",
                BirthDate = DateTime.Now.AddYears(-35),
                Addresses = new List<Address>()
                {
                    new Address()
                    {

                    },
                    new Address()
                    {

                    }
                },
                EmployerSchool = new School()
                {
                    Address = new Address() { },
                    DirectorName = "Dr Who",
                    Name = "Space Time Continum School"
                }
            };
        }
    }
}
