namespace Blog_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Makale")]
    public partial class Makale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Makale()
        {
            Etikets = new HashSet<Etiket>();
            Resims = new HashSet<Resim>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Baslik { get; set; }

        [Required]
        public string Icerik { get; set; }

        public DateTime YayinlamaTarihi { get; set; }

        public int MakaleTipID { get; set; }

        public int KategoriID { get; set; }

        public Guid YazarID { get; set; }

        public int KapakResimID { get; set; }

        public int Goruntulenme { get; set; }

        public int Begeni { get; set; }

        public bool Aktif { get; set; }

        public virtual Kategori Kategori { get; set; }

        public virtual MakaleTip MakaleTip { get; set; }

        public virtual Resim Resim { get; set; }

        public virtual Yazar Yazar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Etiket> Etikets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resim> Resims { get; set; }
    }
}
