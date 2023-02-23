using ArchitectureConceptsPOC.SOLID.Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.SOLID.Prototype
{
    public class ClassePrototipavel : EntidadeGenerica, IPrototype<ClassePrototipavel>
    {
        public string Nome { get; set; }
        public string Documento { get; set; }


        public ClassePrototipavel Clone()
        {
            return new ClassePrototipavel()
            {
                Nome = this.Nome,
                Documento = this.Documento
            };
        }

        public override string ToString()
        {
            return $"{Nome} - {Documento}";
        }
    }
}
