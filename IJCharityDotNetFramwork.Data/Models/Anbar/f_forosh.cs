namespace IJCharityDotNetFramwork.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class f_forosh
    {
        [Key]
        public int shom_san { get; set; }

        public int shom_fak { get; set; }

        [StringLength(40)]
        public string name_mo { get; set; }

        public double kod_mo { get; set; }

        public int kod_egh { get; set; }

        [StringLength(30)]
        public string tavasot { get; set; }

        [StringLength(300)]
        public string address { get; set; }

        public double takh_d { get; set; }

        public int takh { get; set; }

        public short kod_f { get; set; }

        [StringLength(10)]
        public string pdate { get; set; }

        [StringLength(400)]
        public string t_chap { get; set; }

        public int pdate1 { get; set; }

        public int bar { get; set; }

        public double nagh { get; set; }

        public double chek { get; set; }

        public int shom_san_h { get; set; }

        public short kod_k { get; set; }

        public int kod_m { get; set; }

        public short kod_ghorfeh { get; set; }

        public int shom_san_gh { get; set; }

        [StringLength(10)]
        public string pdate_to { get; set; }

        public int pdate1_to { get; set; }

        public short? count_print { get; set; }

        public int no_factore { get; set; }

        [Required]
        [StringLength(9)]
        public string kod_mar_haz { get; set; }

        public short kod_k_bes { get; set; }

        public int kod_m_bes { get; set; }

        public double kod_t_bes { get; set; }

        public short kod_k_takh { get; set; }

        public int kod_m_takh { get; set; }

        public double kod_t_takh { get; set; }

        [StringLength(50)]
        public string tozehat_sanad { get; set; }

        public int kod_m_zar { get; set; }

        [Required]
        [StringLength(1)]
        public string ch_code { get; set; }

        [Required]
        [StringLength(1)]
        public string ch_code_2 { get; set; }

        [Required]
        [StringLength(1)]
        public string ch_code_3 { get; set; }

        public short kod_naghl { get; set; }

        [StringLength(50)]
        public string tozehat_mah { get; set; }

        public double kod_viz_far { get; set; }

        public virtual List<kkala> GetKkalas { get; set; }
    }
}
