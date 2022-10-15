namespace Blog_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Resim")]
    public partial class Resim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Resim()
        {
            Makales = new HashSet<Makale>();
            Yazars = new HashSet<Yazar>();
            Makales1 = new HashSet<Makale>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Adi { get; set; }

        [StringLength(500)]
        public string KucukResimYol { get; set; }

        [StringLength(500)]
        public string OrtaResimYol { get; set; }

        [StringLength(500)]
        public string BuyukResimYol { get; set; }

        [StringLength(50)]
        public string VideoYol { get; set; }

        public Guid EkleyenID { get; set; }

        public DateTime EklenmeTarihi { get; set; }

        public int Goruntulenme { get; set; }

        public int Begeni { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Makale> Makales { get; set; }

        public virtual Yazar Yazar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yazar> Yazars { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Makale> Makales1 { get; set; }
    }
}
