using IJCharityDotNetFramwork.Core.Extentions;
using IJCharityDotNetFramwork.Core.ViewModels;
using IJCharityDotNetFramwork.Data.Context;
using IJCharityDotNetFramwork.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using static IJCharityDotNetFramwork.Data.Models.MyEnumTypes;

namespace IJCharityDotNetFramwork.Core.Services
{

    public class SaleReportService : ISaleReportService
    {
        private AnbarContext _anbarContext;
        private ManateghContext _manateghContext;
        public SaleReportService()
        {
            _anbarContext = new AnbarContext();
            _manateghContext = new ManateghContext();
        }

        public void Dispose()
        {
            _anbarContext.Dispose();
            _manateghContext.Dispose();
        }


        #region Get Sale Report By Noe Khanevade

        public async Task<List<ListManateghViewModel>> GetListManateghAsync()
        {
            return await _manateghContext.hamkaran_manategh.Where
                (w => w.hamkar_or_manager == 1).Select
                (s => new ListManateghViewModel
                {
                    NameModirMantaghe = s.fullname_hamkar_mantaghe,
                    ShomareMantaghe = s.mantaghe_khedmat,
                    ShomareMantagheDecimal = s.mantaghe_khedmat_decimal
                })
                .OrderBy(o => o.ShomareMantagheDecimal)
                .ToListAsync();
        }

        public async Task<List<SaleReportKolByNoeKhanevadeViewModel>> GetSaleReportKolByNoeKhanevadeAsync(string tarikhAvalString, string tarikhAkharString, int tarikh_start_forosh, int tarikh_end_forosh, int noeKhanevade)
        {
            List<int?> detailsMantaghes =
                await GetShomareParvandeByNoeKhanevade(noeKhanevade);

            return await _anbarContext.kkala.Where(k =>
                   k.kod_naghl == 4 &&
                   k.pdate1 >= tarikh_start_forosh &&
                   k.pdate1 <= tarikh_end_forosh &&
                   detailsMantaghes.Any(a => a.Value == k.kod_t)
                 )
                 .GroupBy(g => new { g.kod_kala, g.GetKala.nameKala, g.GetKala.vahed, g.forosh_ba })
                 .Select(s => new SaleReportKolByNoeKhanevadeViewModel
                 {
                     KodKala = s.Key.kod_kala,
                     NameKala = s.Key.nameKala,
                     TedadKhoroji = s.Sum(sum => sum.forosh_te),
                     Vahed = s.Key.vahed,
                     TarikhAval = tarikhAvalString,
                     TarikhAkhar = tarikhAkharString,
                     GheimatForosh = s.Key.forosh_ba,
                     _noeKhanevade = (NoeKhanevade)noeKhanevade
                 })
                 .OrderBy(o => o.TarikhAval)
                 .ThenByDescending(o => o.KodKala)
                 .ToListAsync();
        }

        public async Task<List<SaleReportKolByNoeKhanevadeViewModel>> GetSaleReportKolByNoeKhanevadeAsync(string tarikhAvalString, string tarikhAkharString, int tarikh_start_forosh, int tarikh_end_forosh, int noeKhanevade, string mantaghe)
        {
            List<int?> detailsMantaghes =
                  await GetShomareParvandeByNoeKhanevade(noeKhanevade, mantaghe);

            return await _anbarContext.kkala.Where(k =>
                   k.kod_naghl == 4 &&
                   k.pdate1 >= tarikh_start_forosh &&
                   k.pdate1 <= tarikh_end_forosh &&
                   detailsMantaghes.Any(a => a.Value == k.kod_t)
                 )
                 .GroupBy(g => new { g.kod_kala, g.GetKala.nameKala, g.GetKala.vahed, g.forosh_ba })
                 .Select(s => new SaleReportKolByNoeKhanevadeViewModel
                 {
                     KodKala = s.Key.kod_kala,
                     NameKala = s.Key.nameKala,
                     TedadKhoroji = s.Sum(sum => sum.forosh_te),
                     Vahed = s.Key.vahed,
                     TarikhAval = tarikhAvalString,
                     TarikhAkhar = tarikhAkharString,
                     GheimatForosh = s.Key.forosh_ba,
                     _noeKhanevade = (NoeKhanevade)noeKhanevade,
                     ShomareMantaghe = mantaghe
                 })
                 .OrderBy(o => o.TarikhAval)
                 .ThenByDescending(o => o.KodKala)
                 .ToListAsync();
        }

        public async Task<List<SaleReportDetailByNoeKhanevadeViewModel>> GetSaleReportDetailsByNoeKhanevadeAsync(int tarikh_start_forosh, int tarikh_end_forosh, string shomareMantaghe, int noeKhanevade, decimal kodKala, string nameKhanevade)
        {
            List<int?> listShomareParvande = new List<int?>();
            nameKhanevade = nameKhanevade.ReplaceToKeDb().ReplaceToYeDb();
            string nameKhanevade2 = nameKhanevade.ReplaceToKeFarsi().ReplaceToYeFarsi();

            if (!String.IsNullOrEmpty(shomareMantaghe))
            {
                listShomareParvande = await GetShomareParvandeByNoeKhanevade(noeKhanevade, shomareMantaghe);
            }
            else
            {
                listShomareParvande = await GetShomareParvandeByNoeKhanevade(noeKhanevade);
            }

            if (kodKala == 0)
            {
                return await QueryListKhanevadeByNoeKhanevade(

                       listShomareParvande,
                       shomareMantaghe,
                       tarikh_start_forosh,
                       tarikh_end_forosh,
                       noeKhanevade)
                       .Where(
                            w => w.FullNameKhanevade.Contains(nameKhanevade) ||
                            w.FullNameKhanevade.Contains(nameKhanevade2))
                       .ToListAsync();
            }
            return await QueryListKhanevadeByNoeKhanevade(

                listShomareParvande,
                shomareMantaghe,
                tarikh_start_forosh,
                tarikh_end_forosh,
                noeKhanevade)
                .Where(w => w.KodKala == kodKala &&
                           (w.FullNameKhanevade.Contains(nameKhanevade) ||
                            w.FullNameKhanevade.Contains(nameKhanevade2))
                ).ToListAsync();
        }

        public async Task<List<SaleReportDetailByNoeKhanevadeViewModel>> GetSaleReportDetailsByNoeKhanevadeAsync(int tarikh_start_forosh, int tarikh_end_forosh, string shomareMantaghe, int noeKhanevade)
        {
            List<int?> listShomareParvande = new List<int?>();

            if (!String.IsNullOrEmpty(shomareMantaghe))
            {
                listShomareParvande = await GetShomareParvandeByNoeKhanevade(noeKhanevade, shomareMantaghe);
            }
            else
            {
                listShomareParvande = await GetShomareParvandeByNoeKhanevade(noeKhanevade);
            }

            return await QueryListKhanevadeByNoeKhanevade(

                   listShomareParvande,
                   shomareMantaghe,
                   tarikh_start_forosh,
                   tarikh_end_forosh,
                   noeKhanevade).ToListAsync();
        }

        public async Task<List<ListGhayebinViewModel>> GetListGhayebinAsync(int tarikh_start_forosh, int tarikh_end_forosh, string shomareMantaghe, decimal kodKala, int noeKhanevade)
        {
            List<int?> listShomareParvande = new List<int?>();

            if (!String.IsNullOrEmpty(shomareMantaghe))
            {
                listShomareParvande = await GetShomareParvandeByNoeKhanevade(noeKhanevade, shomareMantaghe);
            }
            else
            {
                listShomareParvande = await GetShomareParvandeByNoeKhanevade(noeKhanevade);
            }

            return await QueryListGhayebin(
                listShomareParvande,
                shomareMantaghe,
                tarikh_start_forosh,
                tarikh_end_forosh,
                kodKala,
                noeKhanevade).ToListAsync();

        }

        public async Task<List<ListGhayebinViewModel>> GetListGhayebinAsync(int tarikh_start_forosh, int tarikh_end_forosh, string shomareMantaghe, int noeKhanevade, decimal kodKala, string nameKhanevade)
        {
            List<int?> listShomareParvande = new List<int?>();

            if (!String.IsNullOrEmpty(shomareMantaghe))
            {
                listShomareParvande = await GetShomareParvandeByNoeKhanevade(noeKhanevade, shomareMantaghe);
            }
            else
            {
                listShomareParvande = await GetShomareParvandeByNoeKhanevade(noeKhanevade);
            }

            return await QueryListGhayebin(
                listShomareParvande,
                shomareMantaghe,
                tarikh_start_forosh,
                tarikh_end_forosh,
                kodKala,
                noeKhanevade)
                .Where(w => w.FullNameKhanevade.Contains(nameKhanevade))
                .ToListAsync();
        }

        public async Task<string> GetMaxDateAsync()
        {
            int maxValue = await _anbarContext.kkala.MaxAsync(m => m.pdate1);
            return maxValue.ToString();
        }

        public async Task<string> GetMinDateAsync()
        {
            int minValue = await _anbarContext.kkala.MinAsync(m => m.pdate1);
            return minValue.ToString();
        }

        public string GetDbName(string ContextName)
        {
            string dbName = "";
            switch (ContextName)
            {
                case "Anbar":
                    dbName = _anbarContext.Database.Connection.Database;
                    break;
                case "Manategh":
                    dbName = _manateghContext.Database.Connection.Database;
                    break;
            }
            return dbName;

        }

        #endregion

        #region Private Methods
        private async Task<List<int?>> GetShomareParvandeByNoeKhanevade(int noeKhanevade)
        {
            if (noeKhanevade == 0)
            {
                return await _manateghContext.Persons.Where(p =>
                                   p.is_sarparast == true &&
                                   p.id_vaziate_tahte_poshesh == 2 &&
                                   (p.Parvande.id_noe_komak == 1 || p.Parvande.id_noe_komak == 6)
                                   ).Select(s => s.shomare_parvande).ToListAsync();
            }
            return await _manateghContext.Persons.Where(p =>
                                    p.is_sarparast == true &&
                                    p.id_noe_khanevade == noeKhanevade &&
                                    p.id_vaziate_tahte_poshesh == 2 &&
                                    (p.Parvande.id_noe_komak == 1 || p.Parvande.id_noe_komak == 6)
                                    ).Select(s => s.shomare_parvande).ToListAsync(); ;
        }
        private async Task<List<int?>> GetShomareParvandeByNoeKhanevade(int noeKhanevade, string mantaghe)
        {
            if (noeKhanevade == 0)
            {
                return await _manateghContext.Persons.Where(p =>
                                   p.is_sarparast == true &&
                                   p.id_vaziate_tahte_poshesh == 2 &&
                                   p.Parvande.mantaghe == mantaghe &&
                                   (p.Parvande.id_noe_komak == 1 || p.Parvande.id_noe_komak == 6)
                                   ).Select(s => s.shomare_parvande).ToListAsync();
            }
            return await _manateghContext.Persons.Where(p =>
                                    p.is_sarparast == true &&
                                    p.id_noe_khanevade == noeKhanevade &&
                                    p.Parvande.mantaghe == mantaghe &&
                                    p.id_vaziate_tahte_poshesh == 2 &&
                                    (p.Parvande.id_noe_komak == 1 || p.Parvande.id_noe_komak == 6)
                                    ).Select(s => s.shomare_parvande).ToListAsync(); ;
        }

        private IQueryable<SaleReportDetailByNoeKhanevadeViewModel> QueryListKhanevadeByNoeKhanevade(List<int?> listShomareParvande, string shomareMantaghe, int tarikh_start_forosh, int tarikh_end_forosh, int noeKhanevade)
        {
            return _anbarContext.kkala.Where(k =>
            k.kod_naghl == 4 &&
            k.pdate1 >= tarikh_start_forosh &&
            k.pdate1 <= tarikh_end_forosh &&
            listShomareParvande.Any(a => a == k.kod_t)
             )
             .GroupBy(g => new
             {
                 g.kod_t,
                 g.forosh_te,
                 g.forosh_ba,
                 g.GetB_D_Taf.name,
                 g.GetF_Forosh.tozehat_sanad,
                 g.kod_kala,
                 g.name_k,
                 g.GetKala.vahed,
                 g.pdate1
             })
             .Select(s => new SaleReportDetailByNoeKhanevadeViewModel
             {
                 KodTafzili = s.Key.kod_t,
                 GheimatForosh = s.Key.forosh_ba,
                 Mantaghe = shomareMantaghe,
                 FullNameKhanevade = s.Key.name,
                 KodKala = s.Key.kod_kala,
                 NameKala = s.Key.name_k,
                 TozihatFaktor = s.Key.tozehat_sanad,
                 TedadKhoroji = s.Key.forosh_te,
                 _enumNoeKhanevade = (NoeKhanevade)noeKhanevade,
                 Vahed = s.Key.vahed,
                 TarikhKhoroj = s.Key.pdate1
             })
             .OrderBy(o => o.TarikhKhoroj)
             .ThenBy(o => o.KodTafzili)
             .ThenByDescending(o => o.TedadKhoroji);
        }

        private IQueryable<ListGhayebinViewModel> QueryListGhayebin(List<int?> listShomareParvande, string shomareMantaghe, int tarikh_start_forosh, int tarikh_end_forosh, decimal kodKala, int noeKhanevade)
        {
            List<double?> ListParvandeHazerin;

            if (kodKala > 0)
            {
                ListParvandeHazerin = QueryListKhanevadeByNoeKhanevade(
                listShomareParvande,
                shomareMantaghe,
                tarikh_start_forosh,
                tarikh_end_forosh,
                noeKhanevade).Where(w => w.KodKala == kodKala).Select(s => s.KodTafzili).ToList();
            }
            else
            {
                ListParvandeHazerin = QueryListKhanevadeByNoeKhanevade(
                listShomareParvande,
                shomareMantaghe,
                tarikh_start_forosh,
                tarikh_end_forosh,
                noeKhanevade).Select(s => s.KodTafzili).ToList();
            }

            var listParvandeHazerin2 = ListParvandeHazerin.ConvertAll(c => Convert.ToInt32(c.Value)).Cast<int?>().ToList();

            var listGhayebin = listShomareParvande.Except(listParvandeHazerin2);

            return _manateghContext.Persons.Where(
                k => k.is_sarparast == true &&
                k.id_vaziate_tahte_poshesh == 2 &&
                listGhayebin.Any(a => a == k.shomare_parvande))
                .Select(s => new ListGhayebinViewModel
                {
                    Mantaghe = shomareMantaghe,
                    _enumNoeKhanevade = (NoeKhanevade)noeKhanevade,
                    ShomareParvande = s.shomare_parvande,
                    FullNameKhanevade = s.full_name,
                    Tel = s.Parvande.tel,
                    Mobile = s.Parvande.mobile1,
                    Address = s.Parvande.address
                })
                .OrderBy(o => o.ShomareParvande);
        }
    }
    #endregion

}


