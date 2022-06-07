using Microsoft.EntityFrameworkCore;
using BaitapLeaning.Model;
namespace BaitapLeaning.Model
{
    public class DefaultConnection : DbContext
    {
        public DefaultConnection(DbContextOptions options) : base(options)
        { }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Docurment> Docurments { get; set; }

        public DbSet<Exam> Exams { get; set; }

        public DbSet<Result> Results { get; set; }

        public DbSet<Schedule> Schedules { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<TextSchedules> TextSchedules { get; set; }


    }
}
