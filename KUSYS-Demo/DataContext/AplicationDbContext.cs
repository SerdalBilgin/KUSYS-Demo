using KUSYS_Demo.Models;
using KUSYS_Demo.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Hosting;

namespace KUSYS_Demo.DataContext
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext()
        {
        }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options)
          : base(options) { }
       

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasData(
                     new Course() { CourseId = "CSI101", CourseName = "Introduction to Computer Science"},
                    
                     new Course()
                         {
                             CourseId = "CSI102",
                             CourseName = "Algorithms",
                            
                         },
                         new Course()
                         {
                             CourseId = "MAT101",
                             CourseName = "Calculus",
                            
                         },
                         new Course()
                         {
                             CourseId = "PHY101",
                             CourseName = "Physics",
                           
                         }
                     );

            modelBuilder.Entity<Student>()
                .HasData(
                     new Student() { StudentId = 1, FirstName = "Halil", LastName = "Kakut", BirthDate=Convert.ToDateTime("12/12/1998") },
                     new Student() { StudentId = 2, FirstName = "ibrahim", LastName = "yılmaz", BirthDate = Convert.ToDateTime("05/10/1993") },
                     new Student() { StudentId = 3, FirstName = "erdi", LastName = "süzen", BirthDate = Convert.ToDateTime("15/09/1995") },
                     new Student() { StudentId = 4, FirstName = "serdal", LastName = "bilgin", BirthDate = Convert.ToDateTime("12/01/1991") }
                     );

            modelBuilder.Entity<StudentCourse>()
                .HasData(
                     new StudentCourse() {   Id=1, StudentId = 1, CourseId = "PHY101" },
                     new StudentCourse() { Id = 2, StudentId = 1, CourseId = "MAT101" },
                     new StudentCourse() { Id = 3,StudentId = 3, CourseId = "MAT101" },
                     new StudentCourse() { Id = 4,StudentId = 2, CourseId = "MAT101" }
                     );
        }


    }
}
