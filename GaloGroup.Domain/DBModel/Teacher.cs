namespace GaloGroup.Domain.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Teacher")]
    public partial class Teacher
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string TeacherFullName { get; set; }

        [StringLength(10)]
        public string NationalNo { get; set; }

        [StringLength(11)]
        public string PhoneNumber { get; set; }

        [StringLength(11)]
        public string MobileNumber { get; set; }

        [StringLength(300)]
        public string Address { get; set; }

        [StringLength(800)]
        public string Biography { get; set; }
    }
}
