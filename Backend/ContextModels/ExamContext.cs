using ExamenDAW.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExamenDAW.ContextModels
{
    public class ExamContext: DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProfesorMaterie>().HasKey(pm => new { pm.ProfesorId, pm.MaterieId });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Profesor> Profesori { get; set; }
        public DbSet<Materie> Materii { get; set; }
        public DbSet<ProfesorMaterie> ProfesoriMaterii { get; set; }

        public ExamContext(DbContextOptions<ExamContext> options) : base(options) { }
    }
}
