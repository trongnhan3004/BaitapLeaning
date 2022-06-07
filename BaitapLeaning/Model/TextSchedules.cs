using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BaitapLeaning.Model
{
    public class TextSchedules
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SchedulesID { get; set; }

        public DayOfWeek DayOfWeek { get; set; }
        public DateTime Time { get; set; }

        public List<Exam>? Exams { get; set; }
    }
}
