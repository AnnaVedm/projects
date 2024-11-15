using data.DAO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace data
{
    public class RemoteDatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Password=1234;Username=postgres;Database=presence");
        }

        public virtual DbSet<DAO.Group> Groups { get; set; } //"DAO.Group" из-за неоднозначной ссылки - ключевое слово Group
        public virtual DbSet<Student> Students { get; set; } 
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<GroupSubject> GroupSubjects { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<AttendanceMark> AttendanceMarks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(it => it.Id);
            modelBuilder.Entity<Subject>().HasKey(it => it.Id);
            modelBuilder.Entity<Attendance>().HasKey(it => it.Id);
            modelBuilder.Entity<AttendanceMark>().HasKey(it => it.Id);
            modelBuilder.Entity<GroupSubject>().HasKey(it => it.Id);
            modelBuilder.Entity<DAO.Group>().HasKey(it => it.Id);

            modelBuilder.Entity<Student>().Property(it => it.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Subject>().Property(it => it.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Attendance>().Property(it => it.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<AttendanceMark>().Property(it => it.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<GroupSubject>().Property(it => it.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<DAO.Group>().Property(it => it.Id).ValueGeneratedOnAdd();
        }
    }
}
