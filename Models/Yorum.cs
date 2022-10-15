namespace Blog_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yorum")]
    public partial class Yorum
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Baslik { get; set; }

        [Required]
        [StringLength(500)]
        public string Icerik { get; set; }

        public int MakaleID { get; set; }

        public DateTime EklenmeTarihi { get; set; }

        [Required]
        [StringLength(10)]
        public string Aktif { get; set; }
    }
}
