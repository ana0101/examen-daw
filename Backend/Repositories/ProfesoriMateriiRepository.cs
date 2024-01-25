using ExamenDAW.ContextModels;
using ExamenDAW.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExamenDAW.Repositories
{
    public class ProfesoriMateriiRepository : IProfesoriMateriiRepository
    {
        private readonly ExamContext _examContext;

        public ProfesoriMateriiRepository(ExamContext examContext)
        {
            _examContext = examContext;
        }

        public async Task<IEnumerable<ProfesorMaterie>> GetProfesoriMateriiAsync()
        {
            var profesoriMaterii = await _examContext.ProfesoriMaterii.ToListAsync();
            return profesoriMaterii;
        }

        public async Task<ProfesorMaterie> PostProfesorMaterieAsync(ProfesorMaterie profesorMaterie)
        {
            _examContext.ProfesoriMaterii.Add(profesorMaterie);
            await _examContext.SaveChangesAsync();
            return profesorMaterie;
        }
    }
}
