using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BaitapLeaning.Model
{
    public class Exam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? ExamId { get; set; }
        public string? ExamName { get; set; }

        public DateTime CreateData { get; set; }

        public string? ContentExam { get; set; }

        public float Time { get; set; }

        public string? Unit { get; set; }

        public string? ExamWork { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }

        public int ResultId { get; set; }

        public Result? Result { get; set; }

        public string? SubjectId { get; set; }

        public Subject? Subject { get; set; }
    }
}
