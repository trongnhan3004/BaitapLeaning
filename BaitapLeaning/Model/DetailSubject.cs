using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BaitapLeaning.Model
{
    public class DetailSubject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetailSubjectId { get; set; }

        public string? DetailSubjectName { get; set; }
        public int SubjectId { get; set; }

        public Subject? Subject { get; set; }

        public int CourseId { get; set; }

        public Course? Course { get; set; }

        public Schedule? Schedule { get; set; }
    }
}
