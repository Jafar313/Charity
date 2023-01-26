namespace IJCharityDotNetFramwork.Core.Services.Interfaces
{
    public interface IPrintService
    {
        void PrintPreview<T1, T2>((T1 reportTitle, T2 dataSource1) dataSource, string reportDirectory);

        void PrintPreview<T1, T2, T3>((T1 reportTitle, T2 dataSource1, T3 dataSource2) dataSource, string reportDirectory);

        void PrintPreview<T1, T2, T3, T4>((T1 reportTitle, T2 dataSource1, T3 dataSource2, T4 dataSource3) dataSource, string reportDirectory);

        void ShowDesigner<T1, T2>((T1 reportTitle, T2 dataSource1) dataSource, string reportDirectory);

        void ShowDesigner<T1, T2, T3>((T1 reportTitle, T2 dataSource1, T3 dataSource2) dataSource, string reportDirectory);

        void ShowDesigner<T1, T2, T3, T4>((T1 reportTitle, T2 dataSource1, T3 dataSource2, T4 dataSource3) dataSource, string reportDirectory);
    }
}
