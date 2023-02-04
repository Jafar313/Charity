using FastReport;
using System.Collections;

namespace IJCharityDotNetFramwork.Core.Services.Interfaces
{
    public class PrintService : IPrintService
    {
        private readonly Report _report;
        public PrintService()
        {
            _report = new Report();
        }

        public void PrintPreview<T1, T2, T3>((T1 reportTitle, T2 dataSource1, T3 dataSource2) dataSource, string reportDirectory)
        {
            if (dataSource.reportTitle != null)
            {
                var reportTitle = (IEnumerable)dataSource.reportTitle;
                _report.RegisterData(reportTitle, "Title");
            }

            if (dataSource.dataSource1 != null)
            {
                var dataSorce1 = (IEnumerable)dataSource.dataSource1;
                _report.RegisterData(dataSorce1, "DataSource1");
            }

            if (dataSource.dataSource2 != null)
            {
                var dataSource2 = (IEnumerable)dataSource.dataSource2;
                _report.RegisterData(dataSource2, "DataSource2");
            }
            _report.Load(reportDirectory);
            _report.Show();
        }

        public void PrintPreview<T1, T2>((T1 reportTitle, T2 dataSource1) dataSource, string reportDirectory)
        {
            if (dataSource.reportTitle != null)
            {
                var reportTitle = (IEnumerable)dataSource.reportTitle;
                _report.RegisterData(reportTitle, "Title");
            }

            if (dataSource.dataSource1 != null)
            {
                var dataSorce1 = (IEnumerable)dataSource.dataSource1;
                _report.RegisterData(dataSorce1, "DataSource1");
            }

            _report.Load(reportDirectory);
            _report.Show();
        }

        public void PrintPreview<T1, T2, T3, T4>((T1 reportTitle, T2 dataSource1, T3 dataSource2, T4 dataSource3) dataSource, string reportDirectory)
        {
            if (dataSource.reportTitle != null)
            {
                var reportTitle = (IEnumerable)dataSource.reportTitle;
                _report.RegisterData(reportTitle, "Title");
            }

            if (dataSource.dataSource1 != null)
            {
                var dataSorce1 = (IEnumerable)dataSource.dataSource1;
                _report.RegisterData(dataSorce1, "DataSource1");
            }

            if (dataSource.dataSource2 != null)
            {
                var dataSource2 = (IEnumerable)dataSource.dataSource2;
                _report.RegisterData(dataSource2, "DataSource2");
            }
            if (dataSource.dataSource3 != null)
            {
                var dataSource3 = (IEnumerable)dataSource.dataSource3;
                _report.RegisterData(dataSource3, "DataSource3");
            }
            _report.Load(reportDirectory);
            _report.Show();
        }

        public void ShowDesigner<T1, T2, T3>((T1 reportTitle, T2 dataSource1, T3 dataSource2) dataSource, string reportDirectory)
        {
            if (dataSource.reportTitle != null)
            {
                var reportTitle = (IEnumerable)dataSource.reportTitle;
                _report.RegisterData(reportTitle, "Title");
            }

            if (dataSource.dataSource1 != null)
            {
                var dataSorce1 = (IEnumerable)dataSource.dataSource1;
                _report.RegisterData(dataSorce1, "DataSource1");
            }

            if (dataSource.dataSource2 != null)
            {
                var dataSource2 = (IEnumerable)dataSource.dataSource2;
                _report.RegisterData(dataSource2, "DataSource2");
            }
            _report.Load(reportDirectory);
            _report.Design();
        }

        public void ShowDesigner<T1, T2>((T1 reportTitle, T2 dataSource1) dataSource, string reportDirectory)
        {
            if (dataSource.reportTitle != null)
            {
                var reportTitle = (IEnumerable)dataSource.reportTitle;
                _report.RegisterData(reportTitle, "Title");
            }

            if (dataSource.dataSource1 != null)
            {
                var dataSorce1 = (IEnumerable)dataSource.dataSource1;
                _report.RegisterData(dataSorce1, "DataSource1");
            }

            _report.Load(reportDirectory);
            _report.Design();
        }

        public void ShowDesigner<T1, T2, T3, T4>((T1 reportTitle, T2 dataSource1, T3 dataSource2, T4 dataSource3) dataSource, string reportDirectory)
        {
            if (dataSource.reportTitle != null)
            {
                var reportTitle = (IEnumerable)dataSource.reportTitle;
                _report.RegisterData(reportTitle, "Title");
            }

            if (dataSource.dataSource1 != null)
            {
                var dataSorce1 = (IEnumerable)dataSource.dataSource1;
                _report.RegisterData(dataSorce1, "DataSource1");
            }

            if (dataSource.dataSource2 != null)
            {
                var dataSource2 = (IEnumerable)dataSource.dataSource2;
                _report.RegisterData(dataSource2, "DataSource2");
            }
            if (dataSource.dataSource3 != null)
            {
                var dataSource3 = (IEnumerable)dataSource.dataSource3;
                _report.RegisterData(dataSource3, "DataSource3");
            }
            _report.Load(reportDirectory);
            _report.Design();
        }
    }
}

