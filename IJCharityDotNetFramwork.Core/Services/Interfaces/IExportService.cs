using System.Collections.Generic;
using System.Data;

namespace IJCharityDotNetFramwork.Core.Services
{
    public interface IExportService
    {
        void ExportToExcel(DataTable dataGrid, string path, string sheetName);

        DataTable GenericListToDataTable<T>(List<T> items);
    }
}
