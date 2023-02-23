using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.SOLID.AbstractFactory.Model
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Address PreferredAddress { get; set; }
        public IList<Address> Addresses { get; set; }


    }
}
