namespace GaloGroup.Domain.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EducationalCalendar")]
    public partial class EducationalCalendar
    {
        public int Id { get; set; }

        public int TrainingCourseId { get; set; }

        [StringLength(30)]
        public string CourseTitle { get; set; }

        public int? TeacherId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? StartRegisterDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime? EndRegisterDate { get; set; }

        public int? Capacity { get; set; }

        public int? duration { get; set; }

        [StringLength(10)]
        public string DayOfWeek { get; set; }

        [StringLength(5)]
        public string StartTime { get; set; }

        [StringLength(5)]
        public string EndTime { get; set; }
    }
}
