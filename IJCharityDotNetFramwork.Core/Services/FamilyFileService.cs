using IJCharityDotNetFramwork.Core.Services.Interfaces;
using IJCharityDotNetFramwork.Core.ViewModels;
using IJCharityDotNetFramwork.Data.Context;
using IJCharityDotNetFramwork.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJCharityDotNetFramwork.Core.Services
{
    public class FamilyFileService : IFamilyFileService
    {
        private ManateghContext _manateghContext;
        public FamilyFileService()
        {
            _manateghContext = new ManateghContext();
        }

        public async Task<bool> AddFamilyFileAsync(FamilyFile familyFile)
        {
            throw new NotImplementedException();
        }


        public async Task<List<FamilyFilesViewModel>> GetFamilyFilesAsync()
        {
            return await _manateghContext.FamilyFiles
                .Where(w => w.IsFamilyFileActive == true)
                .Select(familyFile => new FamilyFilesViewModel
                {
                    Address = familyFile.Address,
                    AreaCode = familyFile.Area.AreaCode,
                    DegreeOfPoverty = familyFile.DegreeOfPoverty,
                    FamilyFileNumber = familyFile.FamilyFileNumber,
                    FamilyIntroducer = familyFile.FamilyIntroducer,
                    FamilyType = familyFile.FamilyType,
                    Mobile1 = familyFile.Mobile1,
                    Mobile2 = familyFile.Mobile2,
                    NumberOfFamilyMemebr = familyFile.NumberOfFamilyMemebr,
                    NumberOfOrphans = familyFile.NumberOfOrphans,
                    Tel = familyFile.Tel,
                    FullNameHeadOfFamily = familyFile.GetFamilyMembers
                    .Where(familyMember => familyMember.IsActivePerson == true
                                            && familyMember.IsFamilyLeader == true)
                    .Select(name => name.FullName ).FirstOrDefault()
                })
                .Take(10)
                .ToListAsync();
        }
    }
}
