using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.SOLID.AbstractFactory.Model
{
    public class Lawyer : Person
    {
        public LawFirm EmployerInfo { get; set; }
        public string Registration { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
