using ExamenDAW.Entities;

namespace ExamenDAW.Repositories
{
    public interface IProfesoriRepository
    {
        public Task<IEnumerable<Profesor>> GetProfesoriAsync();
        public Task<IEnumerable<Profesor>> GetProfesoriCuMateriiAsync();
        public Task<Profesor> PostProfesorAsync(Profesor profesor);
    }
}
