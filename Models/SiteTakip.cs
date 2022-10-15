namespace Blog_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SiteTakip")]
    public partial class SiteTakip
    {
        [Key]
        [StringLength(50)]
        public string MailAdres { get; set; }

        public Guid? YazarID { get; set; }

        public int? KategoriID { get; set; }

        public virtual Kategori Kategori { get; set; }

        public virtual Yazar Yazar { get; set; }
    }
}
