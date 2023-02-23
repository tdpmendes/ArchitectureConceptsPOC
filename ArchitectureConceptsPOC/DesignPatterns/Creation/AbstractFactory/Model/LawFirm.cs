using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.SOLID.AbstractFactory.Model
{
    public class LawFirm
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
        public Address Address { get; set; }
    }
}
