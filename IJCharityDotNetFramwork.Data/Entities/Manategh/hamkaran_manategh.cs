namespace IJCharityDotNetFramwork.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class hamkaran_manategh
    {
        [Key]
        public int id_hamkaran_mantaghe { get; set; }

        public int? hamkar_or_manager { get; set; }

        public string name_hamkar_mantaghe { get; set; }

        public string family_hamkar_mantaghe { get; set; }

        public string fullname_hamkar_mantaghe { get; set; }

        public string mantaghe_khedmat { get; set; }

        public decimal? mantaghe_khedmat_decimal { get; set; }

        public string shomare_card_pass_hamkar { get; set; }

        public string tarikh_tavalod_hamkar_mantaghe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? tarikh_tavalod_hamkar_mantaghe_date { get; set; }

        public string vaziate_taahol_hamkar_mantaghe { get; set; }

        public string tahsilate_hamkar_mantaghe { get; set; }

        public string savabegh_emdadi_hamkar_mantaghe { get; set; }

        public string savabegh_siasi_hamkar_mantaghe { get; set; }

        public string moarref_hamkar_mantaghe { get; set; }

        public string address_manzel_hamkar_mantaghe { get; set; }

        public string address_kar_hamkar_mantaghe { get; set; }

        public string tel_manzel_hamkar_mantaghe { get; set; }

        public string tel_kar_hamkar_mantaghe { get; set; }

        public string mobile_hamkar_mantaghe { get; set; }

        [Column(TypeName = "image")]
        public byte[] picture_hamkar_mantaghe { get; set; }

        public virtual ICollection<Parvande> GetParvandes { get; set; }
    }
}
