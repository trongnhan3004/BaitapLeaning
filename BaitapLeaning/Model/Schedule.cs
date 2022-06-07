using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BaitapLeaning.Model
{
    public class Schedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScheduleId { get; set; }

        public string? ScheduleName { get; set; }

        public DateTime Time { get; set; }

        public DayOfWeek DayOfWeek { get; set; }


        public int DetailSubjectId { get; set; }

        public DetailSubject? DetailSubject { get; set; }
    }
}
