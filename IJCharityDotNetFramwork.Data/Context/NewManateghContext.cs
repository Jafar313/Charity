using IJCharityDotNetFramwork.Data.Models;
using System.Data.Entity;

namespace IJCharityDotNetFramwork.Data.Context
{
    public class NewManateghContext : DbContext
    {
        public NewManateghContext()
           : base("name=NewManateghContext")
        {
        }

        public virtual DbSet<FamilyFile> FamilyFiles { get; set; }
        public virtual DbSet<FamilyMember> FamilyMembers { get; set; }
        public virtual DbSet<Sponsor> Sponsors { get; set; }

    }
}
