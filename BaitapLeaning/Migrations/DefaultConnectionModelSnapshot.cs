// <auto-generated />
using System;
using BaitapLeaning.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaitapLeaning.Migrations
{
    [DbContext(typeof(DefaultConnection))]
    partial class DefaultConnectionModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BaitapLeaning.Model.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"), 1L, 1);

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ClassId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("BaitapLeaning.Model.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"), 1L, 1);

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<float>("Time")
                        .HasColumnType("real");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("BaitapLeaning.Model.DetailCourse", b =>
                {
                    b.Property<int>("DetailCourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetailCourseId"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("DetailCourseId");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("DetailCourse");
                });

            modelBuilder.Entity("BaitapLeaning.Model.DetailSubject", b =>
                {
                    b.Property<int>("DetailSubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetailSubjectId"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("DetailSubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("DetailSubjectId");

                    b.HasIndex("CourseId");

                    b.HasIndex("SubjectId");

                    b.ToTable("DetailSubject");
                });

            modelBuilder.Entity("BaitapLeaning.Model.Docurment", b =>
                {
                    b.Property<string>("DocurmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("DocurmentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Docurments");
                });

            modelBuilder.Entity("BaitapLeaning.Model.Exam", b =>
                {
                    b.Property<string>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ContentExam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateData")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExamName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamWork")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResultId")
                        .HasColumnType("int");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubjectId1")
                        .HasColumnType("int");

                    b.Property<int?>("TextSchedulesSchedulesID")
                        .HasColumnType("int");

                    b.Property<float>("Time")
                        .HasColumnType("real");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ExamId");

                    b.HasIndex("ResultId")
                        .IsUnique();

                    b.HasIndex("SubjectId1");

                    b.HasIndex("TextSchedulesSchedulesID");

                    b.HasIndex("UserId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("BaitapLeaning.Model.Result", b =>
                {
                    b.Property<int>("ResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResultId"), 1L, 1);

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<float>("Mark")
                        .HasColumnType("real");

                    b.HasKey("ResultId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("BaitapLeaning.Model.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScheduleId"), 1L, 1);

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<int>("DetailSubjectId")
                        .HasColumnType("int");

                    b.Property<string>("ScheduleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("ScheduleId");

                    b.HasIndex("DetailSubjectId")
                        .IsUnique();

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("BaitapLeaning.Model.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"), 1L, 1);

                    b.Property<int>("NumberOfPeried")
                        .HasColumnType("int");

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("BaitapLeaning.Model.TextSchedules", b =>
                {
                    b.Property<int>("SchedulesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SchedulesID"), 1L, 1);

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("SchedulesID");

                    b.ToTable("TextSchedules");
                });

            modelBuilder.Entity("BaitapLeaning.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int?>("ClassId1")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Roles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("ClassId1");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BaitapLeaning.Model.DetailCourse", b =>
                {
                    b.HasOne("BaitapLeaning.Model.Course", "Course")
                        .WithMany("DetailCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaitapLeaning.Model.User", "User")
                        .WithMany("DetailCourses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BaitapLeaning.Model.DetailSubject", b =>
                {
                    b.HasOne("BaitapLeaning.Model.Course", "Course")
                        .WithMany("DetailSubjects")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaitapLeaning.Model.Subject", "Subject")
                        .WithMany("DetailSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("BaitapLeaning.Model.Docurment", b =>
                {
                    b.HasOne("BaitapLeaning.Model.Subject", "Subject")
                        .WithMany("Docurments")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("BaitapLeaning.Model.Exam", b =>
                {
                    b.HasOne("BaitapLeaning.Model.Result", "Result")
                        .WithOne("Exam")
                        .HasForeignKey("BaitapLeaning.Model.Exam", "ResultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaitapLeaning.Model.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId1");

                    b.HasOne("BaitapLeaning.Model.TextSchedules", null)
                        .WithMany("Exams")
                        .HasForeignKey("TextSchedulesSchedulesID");

                    b.HasOne("BaitapLeaning.Model.User", "User")
                        .WithMany("Exams")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Result");

                    b.Navigation("Subject");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BaitapLeaning.Model.Schedule", b =>
                {
                    b.HasOne("BaitapLeaning.Model.DetailSubject", "DetailSubject")
                        .WithOne("Schedule")
                        .HasForeignKey("BaitapLeaning.Model.Schedule", "DetailSubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DetailSubject");
                });

            modelBuilder.Entity("BaitapLeaning.Model.User", b =>
                {
                    b.HasOne("BaitapLeaning.Model.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId1");

                    b.Navigation("Class");
                });

            modelBuilder.Entity("BaitapLeaning.Model.Course", b =>
                {
                    b.Navigation("DetailCourses");

                    b.Navigation("DetailSubjects");
                });

            modelBuilder.Entity("BaitapLeaning.Model.DetailSubject", b =>
                {
                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("BaitapLeaning.Model.Result", b =>
                {
                    b.Navigation("Exam");
                });

            modelBuilder.Entity("BaitapLeaning.Model.Subject", b =>
                {
                    b.Navigation("DetailSubjects");

                    b.Navigation("Docurments");
                });

            modelBuilder.Entity("BaitapLeaning.Model.TextSchedules", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("BaitapLeaning.Model.User", b =>
                {
                    b.Navigation("DetailCourses");

                    b.Navigation("Exams");
                });
#pragma warning restore 612, 618
        }
    }
}
