namespace Blog_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kategori")]
    public partial class Kategori
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kategori()
        {
            Makales = new HashSet<Makale>();
            SiteTakips = new HashSet<SiteTakip>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Adi { get; set; }

        public string FormatAdi(int count)
        {
            return  $"{this.Adi} ({count})";
        }

        public virtual ICollection<Makale> Makales { get; set; }

      
        public virtual ICollection<SiteTakip> SiteTakips { get; set; }
    }
}
