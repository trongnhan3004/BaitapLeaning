using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BaitapLeaning.Model
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }

        public string? CourseName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool Status { get; set; }
        public float Time { get; set; }

        public string? Unit { get; set; }

        public List<DetailCourse>? DetailCourses { get; set; }
        public List<DetailSubject>? DetailSubjects { get; set; }

    }
}
