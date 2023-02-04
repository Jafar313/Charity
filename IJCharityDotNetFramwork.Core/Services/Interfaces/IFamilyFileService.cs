using IJCharityDotNetFramwork.Core.ViewModels;
using IJCharityDotNetFramwork.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJCharityDotNetFramwork.Core.Services.Interfaces
{
    public interface IFamilyFileService 
    {
        Task<List<FamilyFilesViewModel>> GetFamilyFilesAsync();
        Task <bool> AddFamilyFileAsync(FamilyFile familyFile);
    }
}
