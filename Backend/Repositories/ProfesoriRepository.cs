using ExamenDAW.ContextModels;
using ExamenDAW.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExamenDAW.Repositories
{
    public class ProfesoriRepository : IProfesoriRepository
    {
        private readonly ExamContext _examContext;

        public ProfesoriRepository(ExamContext examContext)
        {
            _examContext = examContext;
        }

        public async Task<IEnumerable<Profesor>> GetProfesoriAsync()
        {
            var profesori = await _examContext.Profesori.ToListAsync();
            return profesori;
        }

        public async Task<IEnumerable<Profesor>> GetProfesoriCuMateriiAsync()
        {
            var profesori = await _examContext.Profesori.Include(p => p.ProfesoriMaterii).ToListAsync();
            return profesori;
        }

        public async Task<Profesor> PostProfesorAsync(Profesor profesor)
        {
            _examContext.Profesori.Add(profesor);
            await _examContext.SaveChangesAsync();
            return profesor;
        }
    }
}
