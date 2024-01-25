using ExamenDAW.Entities;

namespace ExamenDAW.Repositories
{
    public interface IProfesoriMateriiRepository
    {
        public Task<IEnumerable<ProfesorMaterie>> GetProfesoriMateriiAsync();
        public Task<ProfesorMaterie> PostProfesorMaterieAsync(ProfesorMaterie profesorMaterie);
    }
}
