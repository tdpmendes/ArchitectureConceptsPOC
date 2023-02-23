using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.TemplateMethod
{
    public class ProfessorRepository : RepositoryBase<Professor>
    {
        public ProfessorRepository(Context db) : base(db)
        {
        }
        public async Task<IEnumerable<Professor>> GetProfessoresWithDisciplinasAsync()
        {
            return await Db.Professores.AsNoTracking()
                                       .Include(e => e.Disciplina)
                                       .ToListAsync();
        }
    }
}
