using ExamenDAW.Entities;

namespace ExamenDAW.Repositories
{
    public interface IMateriiRepository
    {
        public Task<IEnumerable<Materie>> GetMateriiAsync();
        public Task<Materie> PostMaterieAsync(Materie materie);
    }
}
