namespace IJCharityDotNetFramwork.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("kala")]
    public partial class kala
    {
        public kala()
        {

        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short kod_sar { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal kod_kala { get; set; }

        [StringLength(60)]
        [Column("name")]
        public string nameKala { get; set; }

        public double tedad { get; set; }

        public double kharid { get; set; }

        public double forosh { get; set; }

        public double tedad_to { get; set; }

        public double mab_por { get; set; }

        public double marz { get; set; }

        [StringLength(10)]
        public string vahed { get; set; }

        public double dar_ta { get; set; }

        [StringLength(10)]
        public string vahed2 { get; set; }

        public double? te2 { get; set; }

        [StringLength(1)]
        public string no_kala { get; set; }

        public short? mo_gar { get; set; }

        [StringLength(70)]
        public string name_l { get; set; }

        [StringLength(1)]
        public string kod_f { get; set; }

        public double? forosh_2 { get; set; }

        public double? mab_por_2 { get; set; }

        public double? forosh_mas { get; set; }

        [StringLength(20)]
        public string shom_fan { get; set; }

        public double? te_sef { get; set; }

        public double? te_resid { get; set; }

        public double? te_rah { get; set; }

        public double? count_f { get; set; }

        public double? count_n { get; set; }

        public double? count_l { get; set; }

        public int? kod_prose { get; set; }

        [StringLength(20)]
        public string model { get; set; }

        [Required]
        [StringLength(1)]
        public string jadid { get; set; }

        [Required]
        [StringLength(1)]
        public string jayezeh { get; set; }

        [StringLength(100)]
        public string tozehat { get; set; }

        public int? date_sabt { get; set; }

        [StringLength(20)]
        public string code_meli { get; set; }

        public double? marz_max { get; set; }

        public double? max_sef_kh { get; set; }

        public short? time_kh { get; set; }

        public double? nerkh_es { get; set; }

        public short? kod_k { get; set; }

        public int? kod_m { get; set; }

        public double? kod_t { get; set; }

        [StringLength(1)]
        public string mo_keyfiyat { get; set; }

        [StringLength(20)]
        public string ghaf { get; set; }

        [StringLength(15)]
        public string tabagheh { get; set; }

        [StringLength(15)]
        public string palt { get; set; }

        public double? forosh_3 { get; set; }

        public double? forosh_4 { get; set; }

        public double? forosh_5 { get; set; }

        public double? forosh_6 { get; set; }

        public double? dar_dara { get; set; }

        public double? dar_shahr { get; set; }
    }
}
