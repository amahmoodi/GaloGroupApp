namespace GaloGroup.Domain.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrainingCategory")]
    public partial class TrainingCategory
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string CategoryTitle { get; set; }
    }
}
