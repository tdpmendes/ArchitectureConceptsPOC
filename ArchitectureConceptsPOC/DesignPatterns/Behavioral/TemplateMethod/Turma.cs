using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.TemplateMethod
{
    public class Turma : EntityBase
    {
        public IList<Aluno> Alunos { get; set; }
    }
}
