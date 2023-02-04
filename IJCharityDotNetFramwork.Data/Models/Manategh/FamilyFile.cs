using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static IJCharityDotNetFramwork.Data.Models.MyEnumTypes;

namespace IJCharityDotNetFramwork.Data.Models
{
    public class FamilyFile
    {
        public FamilyFile()
        {
            GetFamilyMembers = new List<FamilyMember>();
            GetSponsors = new List<Sponsor>();
        }

        public Guid FamilyFileId { get; set; }
        
        public int FamilyFileNumber { get; set; }

        public NoeKhanevade FamilyType { get; set; }

        [DataType(DataType.Date)]
        public DateTime FamilyFileDate { get; set; }
        public int NumberOfFamilyMemebr { get; set; }
        public int NumberOfOrphans { get; set; }

        [MaxLength(50)]
        public string FamilyIntroducer { get; set; }

        [MaxLength(300)]
        public string Address { get; set; }

        [MaxLength(10)]
        public string Tel { get; set; }

        [MaxLength(11)]
        public string Mobile1 { get; set; }

        [MaxLength(11)]
        public string Mobile2 { get; set; }

        [Range(1,5)]
        public int DegreeOfPoverty { get; set; }

        [MaxLength(200)]
        public string Tags { get; set; }
        public bool IsFamilyFileActive { get; set; }

        #region Relations

        public virtual ICollection<Sponsor> GetSponsors { get; set; }
        public virtual ICollection<FamilyMember> GetFamilyMembers { get; set; }
        public virtual Area Area { get; set; }

        #endregion
    }
}
