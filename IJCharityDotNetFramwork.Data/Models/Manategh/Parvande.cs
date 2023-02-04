namespace IJCharityDotNetFramwork.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Parvande")]
    public partial class Parvande
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parvande()
        {
            Persons = new HashSet<Persons>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_parvande { get; set; }

        public int? id_moarref { get; set; }

        [StringLength(10)]
        public string tarikh_parvande { get; set; }

        [Column(TypeName = "date")]
        public DateTime? tarikh_parvande_miladi { get; set; }

        [StringLength(50)]
        public string zaman_sabt_parvande { get; set; }

        public int? id_ellate_paziresh { get; set; }

        public int? id_location { get; set; }

        public int? id_last_user_edit { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int shomare_parvande { get; set; }

        [StringLength(10)]
        public string mantaghe { get; set; }

        [StringLength(25)]
        public string shomare_khanevar { get; set; }

        public int? tedad_nafar { get; set; }

        public int? tedad_kol_afrad { get; set; }

        public int? tedad_yatim { get; set; }

        public string ellate_fote_pedar { get; set; }

        public string address { get; set; }

        [StringLength(25)]
        public string tel { get; set; }

        [StringLength(25)]
        public string mobile1 { get; set; }

        public string Tozihat_parvande { get; set; }

        public string Tozihat_systemi { get; set; }

        public int? radif_nobat_mantaghe { get; set; }

        public bool? kart_kheirie_darad { get; set; }

        public bool? parvande_pic_darad { get; set; }

        [StringLength(50)]
        public string zaman_akharin_eslah { get; set; }

        public int? id_noe_komak { get; set; }

        public int? id_vaziate_parvande { get; set; }

        [Column(TypeName = "date")]
        public DateTime? expire_date { get; set; }

        public virtual ICollection<Persons> Persons { get; set; }
        public virtual ICollection<hamkaran_manategh> GetHamkaranMantaghe { get; set; }
    }
}
