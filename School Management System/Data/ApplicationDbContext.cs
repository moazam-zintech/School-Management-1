using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using School_Management_System.Models;

namespace School_Management_System.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationDbContext>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public virtual DbSet<Student> Students { get; set; } = null;
        public virtual DbSet<Teacher> Teachers{ get; set; } = null;
        public virtual DbSet<Class> Classes { get; set; } = null;
        public virtual DbSet<Subject> Subjects { get; set; } = null;
        public virtual DbSet<Term> Terms{ get; set; } = null;
        public virtual DbSet<Grade> Grades{ get; set; } = null;

        public virtual DbSet<Register> Register { get; set; } 

        public virtual DbSet<Login> Login { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>()
             .HasMany(x => x.Classes)
             .WithMany(b => b.Students)
             .UsingEntity(y => y.ToTable("StudentClasses"));

            modelBuilder.Entity<Register>().ToTable("Register");
            modelBuilder.Entity<Login>().HasNoKey().ToTable("Login");

            modelBuilder.Entity<Class>()
            .Property(c => c.Class_id)
            .ValueGeneratedOnAdd();




            /*  modelBuilder.Entity<StudentClass>()
                 .HasOne(sc => sc.Class)
                 .WithMany()  
                 .HasForeignKey(sc => sc.Class_id);


              modelBuilder.Entity<StudentSubject>()
              .HasOne(sc => sc.Student)
              .WithMany()  
              .HasForeignKey(sc => sc.Std_id);

              modelBuilder.Entity<StudentSubject>()
                  .HasOne(sc => sc.Subject)
                  .WithMany()  
                  .HasForeignKey(sc => sc.Sbj_id);

              modelBuilder.Entity<StudentGrade>()
              .HasOne(sc => sc.Student)
              .WithMany()  
              .HasForeignKey(sc => sc.Std_id);

              modelBuilder.Entity<StudentGrade>()
                  .HasOne(sc => sc.Grade)
                  .WithMany()  
                  .HasForeignKey(sc => sc.Grd_id);

              modelBuilder.Entity<StudentTeacher>()
              .HasOne(sc => sc.Student)
              .WithMany()  
              .HasForeignKey(sc => sc.Std_id);

              modelBuilder.Entity<StudentTeacher>()
                  .HasOne(sc => sc.Teacher)
                  .WithMany()  
                  .HasForeignKey(sc => sc.T_id);

              modelBuilder.Entity<StudentTerm>()
              .HasOne(sc => sc.Student)
              .WithMany()  
              .HasForeignKey(sc => sc.Std_id);

              modelBuilder.Entity<StudentTerm>()
                  .HasOne(sc => sc.Term)
                  .WithMany()  
                  .HasForeignKey(sc => sc.Trm_id);


              modelBuilder.Entity<TeacherClass>()
              .HasOne(sc => sc.Teacher)
              .WithMany()  
              .HasForeignKey(sc => sc.T_id);

              modelBuilder.Entity<TeacherClass>()
                  .HasOne(sc => sc.Class)
                  .WithMany()  
                  .HasForeignKey(sc => sc.Class_id);

              modelBuilder.Entity<TeacherSubject>()
              .HasOne(sc => sc.Teacher)
              .WithMany()  
              .HasForeignKey(sc => sc.T_id);

              modelBuilder.Entity<TeacherSubject>()
                  .HasOne(sc => sc.Subject)
                  .WithMany()  
                  .HasForeignKey(sc => sc.Sbj_id);*/

            base.OnModelCreating(modelBuilder);

        }

        /* public DbSet<Teacher> Teachers{ get; set; }
         public DbSet<StudentClass> StudentClasses { get; set; }
         public DbSet<StudentSubject> StudentSubjects { get; set; }
         public DbSet<StudentGrade> StudentGrades { get; set; }
         public DbSet<StudentTeacher> StudentTeachers { get; set; }
         public DbSet<StudentTerm> StudentTerm { get; set; }
         public DbSet<TeacherClass> TeacherClasses { get; set; }
         public DbSet<TeacherSubject> TeacherSubjects { get; set; }

        public DbSet<Grade> Grades { get; set; }
        public DbSet<Subject> Subjects { get; set; }*/
    }
}
