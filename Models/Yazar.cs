namespace Blog_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yazar")]
    public partial class Yazar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Yazar()
        {
            Makales = new HashSet<Makale>();
            Resims = new HashSet<Resim>();
            SiteTakips = new HashSet<SiteTakip>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Adi { get; set; }

        [Required]
        [StringLength(50)]
        public string Soyadi { get; set; }

        [Required]
        [StringLength(50)]
        public string Mail { get; set; }

        public DateTime KayitTarihi { get; set; }

        [Required]
        [StringLength(50)]
        public string Nick { get; set; }

        public int ResimID { get; set; }

        public bool Aktif { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Makale> Makales { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resim> Resims { get; set; }

        public virtual Resim Resim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SiteTakip> SiteTakips { get; set; }
    }
}
