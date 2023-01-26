using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static IJCharityDotNetFramwork.Data.Models.MyEnumTypes;

namespace IJCharityDotNetFramwork.Data.Models
{
    public class FamilyMember
    {
        public FamilyMember()
        {

        }

        public Guid FamilyMemberId { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "")]
        public string LastName { get; set; }

       
        [MaxLength(51, ErrorMessage = "")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
            set { }
        }

        [Required]
        [MaxLength(25, ErrorMessage = "")]
        public string FatherName { get; set; }

        [Required]
        public bool IsFatherAlive { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
        public string Age
        {
            get
            {
                var currnetAge = BirthDay - DateTime.Today;
                var totalDays = currnetAge.TotalDays;
                var month = totalDays / 30;

                if (month < 12)
                {
                    return ($"{month} ماهه");
                }
                return ($"{month / 12} ساله");
            }
        }

        [MaxLength(25, ErrorMessage = "")]
        public string BirthPlace { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "")]
        public string HealthStatus { get; set; }

        [Required]
        public IdCardType IdCardType { get; set; }

        [MaxLength(11)]
        public string IdCardNumber { get; set; }

        [MaxLength(9)]
        public string FamilyIdCardNumber { get; set; }

        [MaxLength(9)]
        public string PassportNumber { get; set; }

        [MaxLength(12)]
        public string DedicatedNumber { get; set; }

        public EduGrade EducationGrade { get; set; }
        public EduStatus EducationalStatus { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "")]
        public string CurrentJob { get; set; }


        [MaxLength(300, ErrorMessage = "")]
        public string Skills { get; set; }

        public bool IsActivePerson { get; set; }

        public bool IsFamilyLeader { get; set; }

        public NoeKhanevade FamilyType { get; set; }

        #region Relations

        public int FamilyFileNumber { get; set; }
        public virtual FamilyFile FamilyFile { get; set; }

        #endregion
    }
}
