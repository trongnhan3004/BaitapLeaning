using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BaitapLeaning.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Image { get; set; }

        public string? Address { get; set; }

        public string? Phone { get; set; }

        public string? Roles { get; set; }
        public List<DetailCourse>? DetailCourses { get; set; }

        public List<Exam>? Exams { get; set; }

        public int ClassId { get; set; }

        public Class? Class { get; set; }
    }
}
