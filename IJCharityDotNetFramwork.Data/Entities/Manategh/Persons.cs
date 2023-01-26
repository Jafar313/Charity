namespace IJCharityDotNetFramwork.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Persons
    {
        public Persons()
        { }

        [Key]
        public int ID_Person { get; set; }

        public int? shomare_parvande { get; set; }

        [StringLength(100)]
        public string first_name { get; set; }

        [StringLength(100)]
        public string last_name { get; set; }

        [StringLength(250)]
        public string full_name { get; set; }

        [StringLength(50)]
        public string name_pedar { get; set; }

        [StringLength(10)]
        public string tarikh_tavalod { get; set; }

        [Column(TypeName = "date")]
        public DateTime? tarikh_tavalod_miladi { get; set; }

        [StringLength(25)]
        public string shomare_shenasaie { get; set; }

        [StringLength(80)]
        public string vaziate_salamat { get; set; }

        [StringLength(50)]
        public string shogl { get; set; }

        public int? id_noe_khanevade { get; set; }

        public int? id_vaziate_taahol { get; set; }

        public int? size_kafsh { get; set; }

        [StringLength(50)]
        public string size_lebas { get; set; }

        public bool? jensiat_zan_ast { get; set; }

        [StringLength(300)]
        public string tozihat { get; set; }

        public bool? is_sarparast { get; set; }

        public int? id_vaziate_tahte_poshesh { get; set; }

        [StringLength(50)]
        public string zaman_sabt_person { get; set; }

        public int? id_mahal_tavalod { get; set; }

        public int? noe_madrak_shenasaie { get; set; }

        public int? id_tahsilat { get; set; }

        public bool? is_yatim { get; set; }

        public virtual Parvande Parvande { get; set; }
    }
}
