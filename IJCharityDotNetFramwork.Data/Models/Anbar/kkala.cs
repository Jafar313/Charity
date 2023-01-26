namespace IJCharityDotNetFramwork.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("kkala")]
    public partial class kkala
    {
        public kkala()
        {

        }

        [Column(TypeName = "numeric")]
        public decimal kod_kala { get; set; }

        public short kod_foroshgah { get; set; }

        public short kod_ghorfeh { get; set; }

        public int kod_naghl { get; set; }

        public int shom_san { get; set; }

        public short rad { get; set; }

        public int pdate1 { get; set; }

        [StringLength(30)]
        public string sharh { get; set; }

        public double kharid_te { get; set; }

        public double kharid_ba { get; set; }

        public double forosh_te { get; set; }

        public double forosh_ba { get; set; }

        public int kod_kar { get; set; }

        public double mab_por { get; set; }

        [StringLength(90)]
        public string name_k { get; set; }

        public double te1 { get; set; }

        public double takh { get; set; }

        public short kod_z { get; set; }

        public int? mo_gar { get; set; }

        public short? kod_user { get; set; }

        public int? shom_toz { get; set; }

        public int? pdate1_toz { get; set; }

        [StringLength(20)]
        public string shom_ser { get; set; }

        public short? kod_k { get; set; }

        public int? kod_m { get; set; }

        public double? kod_t { get; set; }

        public int? kod_toz { get; set; }

        [StringLength(1)]
        public string eb_ser { get; set; }

        [StringLength(20)]
        public string model { get; set; }

        [StringLength(1)]
        public string moghayerat { get; set; }

        [Key]
        public int ser_rad { get; set; }

        public double? dar_dara { get; set; }

        public double? dar_shahr { get; set; }

        #region Relations
        public virtual b_d_taf GetB_D_Taf { get; set; }
        public virtual kala GetKala { get; set; }
        public virtual f_forosh GetF_Forosh { get; set; }
        public virtual Parvande GetParvande { get; set; }
        #endregion

    }
}
