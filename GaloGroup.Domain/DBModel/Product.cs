namespace GaloGroup.Domain.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string ProductTitle { get; set; }

        public int CategoryId { get; set; }

        public int Count { get; set; }

        public decimal Price { get; set; }

        [StringLength(50)]
        public string MadeIn { get; set; }

        public bool Availble { get; set; }
    }
}
