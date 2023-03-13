using KUSYS_Demo.Models;
using KUSYS_Demo.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasData(
                     new Course() { CourseId = "CSI101", CourseName = "Introduction to Computer Science", StudentId = 1 },
                     new Course()
                         {
                             CourseId = "CSI102",
                             CourseName = "Algorithms",
                             StudentId = 2,
                         },
                         new Course()
                         {
                             CourseId = "MAT101",
                             CourseName = "Calculus",
                             StudentId = 3,
                         },
                         new Course()
                         {
                             CourseId = "PHY101",
                             CourseName = "Physics",
                             StudentId = 4,
                         }
                     );

            modelBuilder.Entity<Student>()
                .HasData(
                     new Student() { StudentId = 1, FirstName = "Halil", LastName = "Kakut" },
                     new Student() { StudentId = 2, FirstName = "ibrahim", LastName = "yılmaz" },
                     new Student() { StudentId = 3, FirstName = "erdi", LastName = "süzen" },
                     new Student() { StudentId = 4, FirstName = "serdal", LastName = "bilgin" }
                     );
        }


    }
}
