namespace IJCharityDotNetFramwork.Data.Models
{
    using System.Data.Entity;

    public partial class ManateghContext : DbContext
    {
        public ManateghContext()
            : base("name=ManateghContext")
        {
        }

        public virtual DbSet<Parvande> Parvande { get; set; }
        public virtual DbSet<hamkaran_manategh> hamkaran_manategh { get; set; }
        public virtual DbSet<Manategh> Manategh { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<FamilyFile> FamilyFiles { get; set; }
        public virtual DbSet<FamilyMember> FamilyMembers { get; set; }
        public virtual DbSet<Area> Areas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parvande>()
                .HasMany(e => e.Persons)
                .WithOptional(e => e.Parvande)
                .WillCascadeOnDelete();

            modelBuilder.Entity<hamkaran_manategh>()
                .Property(e => e.mantaghe_khedmat_decimal)
                .HasPrecision(18, 1);

            modelBuilder.Entity<Manategh>()
                .Property(e => e.shomare_mantaghe_deci)
                .HasPrecision(18, 1);

            modelBuilder.Entity<Manategh>()
                .Property(e => e.shomare_mantaghe)
                .IsUnicode(false);
        }
    }
}
