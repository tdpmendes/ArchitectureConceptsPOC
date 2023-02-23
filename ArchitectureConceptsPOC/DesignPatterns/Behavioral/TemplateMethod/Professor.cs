using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.TemplateMethod
{
    public class Professor : EntityBase
    {
        public decimal Salario { get; set; }

        [Column("disciplina_id")]
        public long DisciplinaId { get; set; }

        public Disciplina Disciplina { get; set; }
    }
}
