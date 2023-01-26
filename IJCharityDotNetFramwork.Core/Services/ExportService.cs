using ClosedXML.Excel;
using FastMember;
using System.Collections.Generic;
using System.Data;

namespace IJCharityDotNetFramwork.Core.Services
{
    public class ExportService : IExportService
    {
        public void ExportToExcel(DataTable dataGrid, string path, string sheetName)
        {
            using (XLWorkbook workbook = new XLWorkbook())
            {
                var worksheet = workbook.AddWorksheet(dataGrid, sheetName); ;
                worksheet.Columns().AdjustToContents();
                worksheet.RightToLeft = true;
                worksheet.Style.Font.FontCharSet = XLFontCharSet.Arabic;
                worksheet.Style.Font.FontName = "B Yekan";
                worksheet.Style.Font.FontSize = 16;

                workbook.SaveAs(path);
            }
        }

        public DataTable GenericListToDataTable<T>(List<T> items)
        {

            DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(items))
            {
                table.Load(reader);
            }

            //System.Data.DataTable dataTable = new System.Data.DataTable(typeof(T).Name);
            ////Get all the properties by using reflection   
            //PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            //foreach (PropertyInfo prop in Props)
            //{
            //    //Setting column names as Property names  
            //    dataTable.Columns.Add(prop.Name);
            //}
            //foreach (T item in items)
            //{
            //    var values = new object[Props.Length];
            //    for (int i = 0; i < Props.Length; i++)
            //    {
            //        values[i] = Props[i].GetValue(item, null);
            //    }
            //    dataTable.Rows.Add(values);
            //}

            return table;
        }
    }
}




