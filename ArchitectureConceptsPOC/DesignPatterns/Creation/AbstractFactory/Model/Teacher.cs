using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.SOLID.AbstractFactory.Model
{
    public class Teacher : Person
    {
        public School EmployerSchool { get; set; }
        public Guid RegistrationInfo { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
