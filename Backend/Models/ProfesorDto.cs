using ExamenDAW.Entities;
using System.Text.Json.Serialization;

namespace ExamenDAW.Models
{
    public enum TipProfesor
    {
        Standard,
        Laborant
    }

    public class ProfesorDto
    {
        public string Nume { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TipProfesor Tip { get; set; }
    }
}
