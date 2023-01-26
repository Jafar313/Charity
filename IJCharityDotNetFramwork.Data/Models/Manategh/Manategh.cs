namespace IJCharityDotNetFramwork.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Manategh")]
    public partial class Manategh
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name_mantaghe { get; set; }

        public decimal? shomare_mantaghe_deci { get; set; }

        [StringLength(5)]
        public string shomare_mantaghe { get; set; }

    }
}
