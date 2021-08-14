namespace Entities.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_BestSellingProducts
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string URUN { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string NUMARA { get; set; }

        public int? ADET { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TOPLAM { get; set; }
    }
}
