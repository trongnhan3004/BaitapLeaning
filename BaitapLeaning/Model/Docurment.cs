using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BaitapLeaning.Model
{
    public class Docurment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? DocurmentId { get; set; }
        public string? Link { get; set; }
        public int SubjectId { get; set; }
        public Subject? Subject { get; set; }
    }
}
