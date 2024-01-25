using ExamenDAW.ContextModels;
using ExamenDAW.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExamenDAW.Repositories
{
    public class MateriiRepository : IMateriiRepository
    {
        private readonly ExamContext _examContext;

        public MateriiRepository(ExamContext examContext)
        {
            _examContext = examContext;
        }

        public async Task<IEnumerable<Materie>> GetMateriiAsync()
        {
            var materii = await _examContext.Materii.ToListAsync();
            return materii;
        }

        public async Task<Materie> PostMaterieAsync(Materie materie)
        {
            _examContext.Materii.Add(materie);
            await _examContext.SaveChangesAsync();
            return materie;
        }
    }
}
