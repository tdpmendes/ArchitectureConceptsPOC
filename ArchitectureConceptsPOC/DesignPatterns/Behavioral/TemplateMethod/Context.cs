using Microsoft.EntityFrameworkCore;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.TemplateMethod
{
    public class Context : DbContext
    {
        public virtual DbSet<Aluno> Alunos { get; set; }
        public virtual DbSet<Disciplina> Disciplinas { get; set; }
        public virtual DbSet<Horario> Horarios { get; set; }
        public virtual DbSet<Professor> Professores { get; set; }
        public virtual DbSet<Turma> Turmas { get; set; }

        public Context()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Sempre conferir se a connection string bate com a sua configuracao
            optionsBuilder.UseSqlServer(Constants.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Turma>()
                            .HasMany(m => m.Alunos)
                            .WithOne()
                            .HasForeignKey(m => m.TurmaId);

        }
    }
}
