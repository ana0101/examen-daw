using System.Text.Json.Serialization;

namespace ExamenDAW.Entities
{
    public class Materie
    {
        public int Id { get; set; }
        public string Denumire { get; set; }

        [JsonIgnore]
        public ICollection<ProfesorMaterie> ProfesoriMaterii { get; set; }
    }
}
