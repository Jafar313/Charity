namespace IJCharityDotNetFramwork.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class b_d_taf
    {
        public b_d_taf()
        {

        }

        [Key]
        public double kod_t { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(60)]
        public string name_l { get; set; }

        public short mo_he { get; set; }

        [StringLength(30)]
        public string n_mo_he { get; set; }

        [StringLength(50)]
        public string kod_t_m { get; set; }

        [Required]
        [StringLength(1)]
        public string no_he { get; set; }

        public short no_kh { get; set; }

        public double zarib { get; set; }

        [StringLength(1)]
        public string hclose { get; set; }

        public short? kod_ghorfeh { get; set; }

        [Required]
        [StringLength(1)]
        public string baz_bas { get; set; }

        public int? date_sabt { get; set; }

        [Required]
        [StringLength(1)]
        public string mar_haz_ej { get; set; }

        [StringLength(1)]
        public string kod_t_moj { get; set; }

        public short kod_t_new { get; set; }

        public double saghf_viz { get; set; }
    }
}
