using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJCharityDotNetFramwork.Data.Models
{
    public class Area
    {
        public Area()
        {
            GetFamilyFiles = new List<FamilyFile>();
        }
        public Guid AreaId { get; set; }

        [MaxLength(10)]
        public string AreaName { get; set; }
        
        [MaxLength(5)]
        public string AreaCode { get; set; }
        
        [MaxLength(30)]
        public string AreaChairman { get; set; }

        #region Relations

        public virtual IEnumerable<FamilyFile> GetFamilyFiles { get; set; }

        #endregion
    }
}
