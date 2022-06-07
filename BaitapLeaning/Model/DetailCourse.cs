using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BaitapLeaning.Model
{
    public class DetailCourse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetailCourseId { get; set; }

        public int UserId { get; set; }

        public User? User { get; set; }

        public int CourseId { get; set; }
        public Course? Course { get; set; }

    }
}
