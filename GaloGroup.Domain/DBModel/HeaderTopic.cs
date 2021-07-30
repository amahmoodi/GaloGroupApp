namespace GaloGroup.Domain.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HeaderTopic")]
    public partial class HeaderTopic
    {
        public int id { get; set; }

        public int TrainingCourseId { get; set; }

        [Required]
        [StringLength(100)]
        public string HeadingTopic { get; set; }
    }
}
