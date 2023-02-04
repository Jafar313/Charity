using IJCharityDotNetFramwork.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IJCharityDotNetFramwork.Core.Services
{
    public interface ISaleReportService : IDisposable
    {

        #region Get Sale Report Group by Noe Khanevade and Mantaghe

        Task<List<SaleReportKolByNoeKhanevadeViewModel>> GetSaleReportKolByNoeKhanevadeAsync(string tarikhAvalString, string tarikhAkharString,
            int tarikh_start_forosh,
            int tarikh_end_forosh,
            int noeKhanevade
            );

        Task<List<SaleReportKolByNoeKhanevadeViewModel>> GetSaleReportKolByNoeKhanevadeAsync
            (
            string tarikhAvalString,
            string tarikhAkharString,
            int tarikh_start_forosh,
            int tarikh_end_forosh,
            int noeKhanevade,
            string mantaghe
            );

        Task<List<SaleReportDetailByNoeKhanevadeViewModel>> GetSaleReportDetailsByNoeKhanevadeAsync
            (
            int tarikh_start_forosh,
            int tarikh_end_forosh,
            string shomareMantaghe,
            int noeKhanevade
            );

        Task<List<SaleReportDetailByNoeKhanevadeViewModel>> GetSaleReportDetailsByNoeKhanevadeAsync
            (
            int tarikh_start_forosh,
            int tarikh_end_forosh,
            string shomareMantaghe,
            int noeKhanevade,
            decimal kodKala,
            string nameKhanevade
            );

        Task<List<ListGhayebinViewModel>> GetListGhayebinAsync
            (
            int tarikh_start_forosh,
            int tarikh_end_forosh,
            string shomareMantaghe,
            decimal kodKala,
            int noeKhanevade);

        Task<List<ListGhayebinViewModel>> GetListGhayebinAsync
            (
            int tarikh_start_forosh,
            int tarikh_end_forosh,
            string shomareMantaghe,
            int noeKhanevade,
            decimal kodKala,
            string nameKhanevade);

        Task<List<ListManateghViewModel>> GetListManateghAsync();

        Task<string> GetMaxDateAsync();
        Task<string> GetMinDateAsync();
        string GetDbName(string ContextName);
        #endregion

    }
}