using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ExamenDAW.Entities
{
    public class ProfesorMaterie
    {
        [Key]
        [Column(Order = 0)]
        public int ProfesorId {  get; set; }

        [Key]
        [Column(Order = 1)]
        public int MaterieId { get; set; }

        [JsonIgnore]
        public Profesor? Profesor { get; set; }

        [JsonIgnore]
        public Materie? Materie { get; set; }
    }
}
