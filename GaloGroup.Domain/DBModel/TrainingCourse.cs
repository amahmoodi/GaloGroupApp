namespace GaloGroup.Domain.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrainingCourse")]
    public partial class TrainingCourse
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string TrainingCourseTitle { get; set; }

        public int? CategoryId { get; set; }
    }
}
