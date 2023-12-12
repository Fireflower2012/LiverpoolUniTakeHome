using Azure;
using LiverpoolUnitTakeHome.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Data.Common;
using System.Reflection.Metadata;

namespace LiverpoolUnitTakeHome.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<CourseNames>().ToTable("Subject");
           modelBuilder.Entity<StudentSubject>().ToTable("StudentIsStudying");

        //    modelBuilder.Entity<Student>()
        //.HasMany(e => e.StudentSubject)
        //.WithOne(e => e.Student)
        //.HasForeignKey(e => e.StudentID)
        //.IsRequired();


        }



    }
}
