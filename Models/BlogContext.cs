using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Blog_.Models
{
    public class BlogContext : DbContext

    {
        static BlogContext()
        {
            Database.SetInitializer<BlogContext>(null);
        }
        public BlogContext() : base("Name=BlogData")
        {

        }
        public DbSet<Etiket> Etikets { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet <Makale> Makales { get; set; }
        public DbSet<MakaleTip> MakaleTips { get; set; }
        public DbSet<Resim> Resims { get; set; }
        public DbSet<SiteTakip> SiteTakips { get; set; }

        public DbSet<Yazar> Yazars { get; set; }
        public DbSet<Yorum> Yorums { get; set; }
        public DbSet<ZiyaretciIPLog> ZiyaretciIPLogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Etiket>()
                .HasMany(e => e.Makales)
                .WithMany(e => e.Etikets)
                .Map(m => m.ToTable("MakaleEtiket").MapLeftKey("EtiketID").MapRightKey("MakaleID"));

            modelBuilder.Entity<Kategori>()
                .HasMany(e => e.Makales)
                .WithRequired(e => e.Kategori)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Makale>()
                .HasMany(e => e.Resims)
                .WithMany(e => e.Makales1)
                .Map(m => m.ToTable("MakaleResim").MapLeftKey("MakaleID").MapRightKey("ResimID"));

            modelBuilder.Entity<MakaleTip>()
                .Property(e => e.Adi)
                .IsFixedLength();

            modelBuilder.Entity<MakaleTip>()
                .HasMany(e => e.Makales)
                .WithRequired(e => e.MakaleTip)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resim>()
                .HasMany(e => e.Makales)
                .WithRequired(e => e.Resim)
                .HasForeignKey(e => e.KapakResimID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resim>()
                .HasMany(e => e.Yazars)
                .WithRequired(e => e.Resim)
                .HasForeignKey(e => e.ResimID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yazar>()
                .HasMany(e => e.Makales)
                .WithRequired(e => e.Yazar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yazar>()
                .HasMany(e => e.Resims)
                .WithRequired(e => e.Yazar)
                .HasForeignKey(e => e.EkleyenID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yorum>()
                .Property(e => e.Aktif)
                .IsFixedLength();

            modelBuilder.Entity<ZiyaretciIPLog>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);
        }

    }
}