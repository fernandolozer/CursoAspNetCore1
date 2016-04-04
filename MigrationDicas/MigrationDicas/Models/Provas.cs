using System.ComponentModel.DataAnnotations;

namespace MigrationDicas.Models
{
    public class Provas
    {
        [Key]
        public int ProvasId { get; set; } 
        public double Nota { get; set; } 
    }
}