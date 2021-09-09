using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GaloGroup.Domain.DBModel
{
    public partial class GaloGroupDB : DbContext
    {
        public GaloGroupDB()
            : base("name=GaloGroupDB")
        {
        }

        public virtual DbSet<EducationalCalendar> EducationalCalendars { get; set; }
        public virtual DbSet<HeaderTopic> HeaderTopics { get; set; }
        public virtual DbSet<TrainingCategory> TrainingCategories { get; set; }
        public virtual DbSet<TrainingCourse> TrainingCourses { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Student> Students { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EducationalCalendar>()
                .Property(e => e.StartTime)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EducationalCalendar>()
                .Property(e => e.EndTime)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TrainingCourse>()
                .Property(e => e.TrainingCourseTitle)
                .IsFixedLength();

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.ProductCategoryName)
                .IsFixedLength();

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Id);

            modelBuilder.Entity<Product>()
                .Property(e => e.Id);

            modelBuilder.Entity<Student>()
                .Property(e => e.Id);
        }
    }
}
