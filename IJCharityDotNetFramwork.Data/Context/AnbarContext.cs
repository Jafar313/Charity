namespace IJCharityDotNetFramwork.Data.Context
{
    using IJCharityDotNetFramwork.Data.Models;
    using System.Data.Entity;

    public partial class AnbarContext : DbContext
    {
        public AnbarContext()
            : base("name=AnbarContext")
        {
        }

        public virtual DbSet<b_d_taf> b_d_taf { get; set; }
        public virtual DbSet<kala> kala { get; set; }
        public virtual DbSet<kkala> kkala { get; set; }
        public virtual DbSet<f_forosh> f_forosh { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<b_d_taf>()
                .Property(e => e.kod_t_m)
                .IsUnicode(false);

            modelBuilder.Entity<b_d_taf>()
                .Property(e => e.no_he)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<b_d_taf>()
                .Property(e => e.hclose)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<b_d_taf>()
                .Property(e => e.baz_bas)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<b_d_taf>()
                .Property(e => e.mar_haz_ej)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<b_d_taf>()
                .Property(e => e.kod_t_moj)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<kala>()
                .Property(e => e.kod_kala)
                .HasPrecision(18, 0);

            modelBuilder.Entity<kala>()
                .Property(e => e.no_kala)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<kala>()
                .Property(e => e.kod_f)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<kala>()
                .Property(e => e.shom_fan)
                .IsUnicode(false);

            modelBuilder.Entity<kala>()
                .Property(e => e.jadid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<kala>()
                .Property(e => e.jayezeh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<kala>()
                .Property(e => e.mo_keyfiyat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<kkala>()
                .Property(e => e.kod_kala)
                .HasPrecision(18, 0);

            modelBuilder.Entity<kkala>()
                .Property(e => e.eb_ser)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<kkala>()
                .Property(e => e.moghayerat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<f_forosh>()
               .Property(e => e.pdate)
               .IsUnicode(false);

            modelBuilder.Entity<f_forosh>()
                .Property(e => e.pdate_to)
                .IsUnicode(false);

            modelBuilder.Entity<f_forosh>()
                .Property(e => e.kod_mar_haz)
                .IsUnicode(false);

            modelBuilder.Entity<f_forosh>()
                .Property(e => e.ch_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<f_forosh>()
                .Property(e => e.ch_code_2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<f_forosh>()
                .Property(e => e.ch_code_3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<kala>()
                .HasKey(e => e.kod_sar)
                .HasKey(e => e.kod_kala);

            modelBuilder.Entity<f_forosh>()
                .HasKey(e => e.shom_san)
                .HasMany(e => e.GetKkalas);

            modelBuilder.Entity<kkala>()
                .HasOptional(e => e.GetParvande);
        }
    }
}
