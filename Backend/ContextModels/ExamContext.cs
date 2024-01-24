using Microsoft.EntityFrameworkCore;

namespace ExamenDAW.ContextModels
{
    public class ExamContext: DbContext
    {
        public ExamContext(DbContextOptions<ExamContext> options) : base(options) { }
    }
}
