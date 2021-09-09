namespace GaloGroup.Domain.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Family { get; set; }

        [StringLength(10)]
        public string NationalNo { get; set; }

        [StringLength(11)]
        public string Tel { get; set; }

        [StringLength(11)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(300)]
        public string Address { get; set; }
    }
}
