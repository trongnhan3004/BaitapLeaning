using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BaitapLeaning.Model
{
    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectId { get; set; }

        public string? SubjectName { get; set; }

        public int NumberOfPeried { get; set; }

        public List<DetailSubject>? DetailSubjects { get; set; }

        public List<Docurment>? Docurments { get; set; }
    }
}
