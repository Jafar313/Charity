using IJCharityDotNetFramwork.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IJCharityDotNetFramwork.Data.Models.MyEnumTypes;

namespace IJCharityDotNetFramwork.Core.ViewModels
{
    public class FamilyFilesViewModel
    {
        public int FamilyFileNumber { get; set; }

        public int NumberOfFamilyMemebr { get; set; }

        public int NumberOfOrphans { get; set; }

        public string FamilyIntroducer { get; set; }

        public string Address { get; set; }

        public string Tel { get; set; }

        public string Mobile1 { get; set; }

        public string Mobile2 { get; set; }

        public int DegreeOfPoverty { get; set; }

        public NoeKhanevade FamilyType { get; set; }

        public string AreaCode { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullNameHeadOfFamily { get; set; }

    }
}
