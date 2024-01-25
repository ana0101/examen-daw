using System.Text.Json.Serialization;

namespace ExamenDAW.Entities
{
    public enum TipProfesor
    {
        Standard,
        Laborant
    }

    public class Profesor
    {
        public int Id { get; set; }
        public string Nume { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TipProfesor Tip { get; set; }

        public ICollection<ProfesorMaterie> ProfesoriMaterii { get; set; }
    }
}
