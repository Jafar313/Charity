using IJCharityDotNetFramwork.Core.Extentions;
using IJCharityDotNetFramwork.Core.Services;
using IJCharityDotNetFramwork.Core.Services.Interfaces;
using IJCharityDotNetFramwork.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static IJCharityDotNetFramwork.Data.Models.MyEnumTypes;


namespace IJCharityDotNetFramwork.App.AnbarForms
{
    public partial class SaleReportGroupByNoeKhanevade : Form
    {
        #region Public Variables

        private int startReportdate, endReportdate;
        private int noeKhanevade;
        private string shomareMantaghe = string.Empty;
        List<ListManateghViewModel> listManategh;

        #endregion

        public SaleReportGroupByNoeKhanevade()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            startReportdate = txtStartDate.Text.RemoveDateChar();
            endReportdate = txtEndDate.Text.RemoveDateChar();

            ReportDataGrid.AutoGenerateColumns = false;
            dataGridGhayebin.AutoGenerateColumns = false;

            if (startReportdate <= endReportdate)
            {
                CheckCurrentRadioBtnState();

                using (ISaleReportService saleReportService = new SaleReportService())
                {
                    decimal kod_kala = 0;

                    if (!String.IsNullOrWhiteSpace(txtKodKala.Text))
                    {
                        kod_kala = Convert.ToDecimal(txtKodKala.Text);
                    }

                    if (radioHazerin.Checked)
                    {
                        if (!String.IsNullOrWhiteSpace(txtKodKala.Text) ||
                            !String.IsNullOrWhiteSpace(txtNameKhanevade.Text))
                        {
                            ReportDataGrid.DataSource = await saleReportService.GetSaleReportDetailsByNoeKhanevadeAsync(
                                                    startReportdate,
                                                    endReportdate,
                                                    shomareMantaghe,
                                                    noeKhanevade,
                                                    kod_kala,
                                                    txtNameKhanevade.Text
                                                    );
                        }
                        else
                        {
                            ReportDataGrid.DataSource = await saleReportService.GetSaleReportDetailsByNoeKhanevadeAsync(
                                                   startReportdate,
                                                   endReportdate,
                                                   shomareMantaghe,
                                                   noeKhanevade
                                                   );
                        }
                    }

                    else
                    {
                        if (!String.IsNullOrWhiteSpace(txtNameKhanevade.Text))
                        {
                            dataGridGhayebin.DataSource = await saleReportService.GetListGhayebinAsync
                                (startReportdate, endReportdate, shomareMantaghe, noeKhanevade, kod_kala, txtNameKhanevade.Text);
                        }
                        else
                        {
                            dataGridGhayebin.DataSource = await saleReportService.GetListGhayebinAsync
                               (startReportdate, endReportdate, shomareMantaghe, kod_kala, noeKhanevade);
                        }
                    }

                }

                if (ReportDataGrid.RowCount > 0)
                {
                    btnPrintReport.Enabled = true;
                    btnOpenReportDesinger.Enabled = true;
                    btnExportToExcel.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("تاریخ بصورت صحیح وارده نشده است");
            }
        }

        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.PerformClick();
            }
        }

        private void tabControlSaleReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlSaleReport.SelectedIndex == 0)
            {
                txtStartDateKol.Focus();
            }
            else
            {
                txtStartDate.Focus();
            }
        }

        private async void btnSubmitKol_Click(object sender, EventArgs e)
        {
            int startReportdate = txtStartDateKol.Text.RemoveDateChar();
            int endReportdate = txtEndDateKol.Text.RemoveDateChar();

            ReportDataGridKol.AutoGenerateColumns = false;

            if (startReportdate <= endReportdate)
            {
                CheckCurrentRadioBtnState();
                using (ISaleReportService saleReportService = new SaleReportService())
                {
                    if (comboListManateghKol.Enabled)
                    {
                        string mantaghe = comboListManateghKol.SelectedValue.ToString();

                        ReportDataGridKol.DataSource = await saleReportService
                                        .GetSaleReportKolByNoeKhanevadeAsync
                                        (
                                        txtStartDateKol.Text,
                                        txtEndDateKol.Text,
                                        startReportdate,
                                        endReportdate,
                                        noeKhanevade,
                                        mantaghe
                                        );
                    }
                    else
                    {
                        ReportDataGridKol.DataSource = await saleReportService
                        .GetSaleReportKolByNoeKhanevadeAsync
                        (
                        txtStartDateKol.Text,
                        txtEndDateKol.Text,
                        startReportdate,
                        endReportdate,
                        noeKhanevade
                        );
                    }
                }
                if (ReportDataGridKol.Rows.Count > 0)
                {
                    btnPrintKol.Enabled = true;
                    btnExportToExcelKol.Enabled = true;
                    btnDesignReport.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("تاریخ بصورت صحیح وارده نشده است");
            }
        }

        private void CheckCurrentRadioBtnState()
        {
            RadioButton radioBtn;

            if (tabControlSaleReport.SelectedTab.Name == "tabPageSaleReport")
            {
                radioBtn = this.HeaderGroup.Controls.OfType<RadioButton>()
                                      .Where(x => x.Checked).FirstOrDefault();

                ReportDataGrid.DataSource = String.Empty;

                if (radioBtn != null)
                {
                    switch (radioBtn.Name)
                    {
                        case "radioKol2":
                            noeKhanevade = 0;

                            break;

                        case "radioSadat2":
                            noeKhanevade = 1;
                            break;

                        case "radioAam2":
                            noeKhanevade = 2;
                            break;

                        case "radioVije2":
                            noeKhanevade = 3;
                            break;

                    }

                }

            }
            else
            {
                radioBtn = this.HeaderGroupKol.Controls.OfType<RadioButton>()
                                      .Where(x => x.Checked).FirstOrDefault();

                ReportDataGridKol.DataSource = String.Empty;
                btnPrintKol.Enabled = false;
                btnDesignReport.Enabled = false;

                if (radioBtn != null)
                {
                    switch (radioBtn.Name)
                    {
                        case "radioSadat":

                            groupBoxDataGridKol.Text = "گزارش کل خروجی ها به تفکیک نوع خانواده = سـادات";
                            noeKhanevade = 1;
                            break;

                        case "radioAam":

                            groupBoxDataGridKol.Text = "گزارش کل خروجی ها به تفکیک نوع خانواده = عـام";
                            noeKhanevade = 2;
                            break;

                        case "radioVije":

                            groupBoxDataGridKol.Text = "گزارش کل خروجی ها به تفکیک نوع خانواده = ویـژه";
                            noeKhanevade = 3;
                            break;

                        case "radioKol":

                            groupBoxDataGridKol.Text = "گزارش کل خروجی ها به تفکیک نوع خانواده = بدون تفکیک";
                            noeKhanevade = 0;
                            break;
                    }
                }
            }

        }

        private void txtStartDateKol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmitKol.PerformClick();
            }
        }

        private async void checkSelectMantagheKol_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSelectMantagheKol.Checked)
            {
                if (comboListManateghKol.Items.Count == 0)
                {
                    using (ISaleReportService saleReportService = new SaleReportService())
                    {
                        comboListManateghKol.DataSource = await saleReportService.GetListManateghAsync();
                        comboListManateghKol.DisplayMember = "FullNameMantaghe";
                        comboListManateghKol.ValueMember = "ShomareMantaghe";
                    }
                }
                comboListManateghKol.Enabled = true;
                shomareMantaghe = comboListManateghKol.SelectedValue.ToString();
            }
            else
            {
                comboListManateghKol.Enabled = false;
                shomareMantaghe = String.Empty;
            }
        }

        private async void checkSelectMantaghe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSelectMantaghe.Checked)
            {
                if (comboListManategh.Items.Count == 0)
                {
                    using (ISaleReportService saleReportService = new SaleReportService())
                    {
                        comboListManategh.DataSource = await saleReportService.GetListManateghAsync();
                        comboListManategh.DisplayMember = "FullNameMantaghe";
                        comboListManategh.ValueMember = "ShomareMantaghe";
                    }
                }
                comboListManategh.Enabled = true;
                shomareMantaghe = comboListManategh.SelectedValue.ToString();
            }
            else
            {
                comboListManategh.Enabled = false;
                shomareMantaghe = String.Empty;
            }
        }

        private void comboListManateghKol_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportDataGridKol.DataSource = "";
            if (checkSelectMantagheKol.Checked)
            {
                shomareMantaghe = comboListManateghKol.SelectedValue.ToString();
            }

        }

        private void ReportDataGridKol_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControlSaleReport.SelectedTab = tabPageSaleReport;

            txtStartDate.Text = txtStartDateKol.Text;
            txtEndDate.Text = txtEndDateKol.Text;

            if (checkSelectMantagheKol.Checked)
            {
                comboListManategh.SelectedValue = comboListManateghKol.SelectedValue;
                checkSelectMantaghe.Checked = true;
            }

            txtKodKala.Text = ReportDataGridKol.SelectedRows[0].Cells["kodKalaDataGridKol"].Value.ToString();
            txtNameKhanevade.Text = "";

            switch (noeKhanevade)
            {
                case 1:
                    radioSadat2.Checked = true;
                    break;
                case 2:
                    radioAam2.Checked = true;
                    break;
                case 3:
                    radioVije2.Checked = true;
                    break;
                default:
                    radioKol2.Checked = true;
                    break;
            }

            btnSubmit.PerformClick();
        }

        private void comboListManategh_SelectedValueChanged(object sender, EventArgs e)
        {
            ReportDataGrid.DataSource = "";
            if (checkSelectMantaghe.Checked)
            {
                shomareMantaghe = comboListManategh.SelectedValue.ToString();
            }
        }

        private void radioHazerin_CheckedChanged(object sender, EventArgs e)
        {
            ReportDataGrid.DataSource = "";
            dataGridGhayebin.DataSource = "";

            if (radioHazerin.Checked)
            {
                ReportDataGrid.BringToFront();
            }
            else
            {
                dataGridGhayebin.BringToFront();
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = "xlsx",
                Filter = "Excel files(*.xlsx) | *.xlsx"
            };
            saveFileDialog.ShowDialog();

            if (!String.IsNullOrWhiteSpace(saveFileDialog.FileName))
            {
                string path = saveFileDialog.FileName;

                IExportService exportTo = new ExportService();
                DataTable datatable = new DataTable();

                if (sender.Equals(btnExportToExcelKol))
                {
                    datatable = exportTo.GenericListToDataTable((List<SaleReportKolByNoeKhanevadeViewModel>)ReportDataGridKol.DataSource);
                    exportTo.ExportToExcel(datatable, path, "لیست کل خروجی کالا");
                }
                else
                {
                    if (radioHazerin.Checked)
                    {
                        datatable = exportTo.GenericListToDataTable((List<SaleReportDetailByNoeKhanevadeViewModel>)ReportDataGrid.DataSource);
                        exportTo.ExportToExcel(datatable, path, "لیست جزئیات خروجی کالا");
                    }
                    else
                    {
                        datatable = exportTo.GenericListToDataTable((List<ListGhayebinViewModel>)dataGridGhayebin.DataSource);
                        exportTo.ExportToExcel(datatable, path, "لیست غایبین توزیع");
                    }
                }

            }
        }

        private void btnPrintKol_Click(object sender, EventArgs e)
        {
            IPrintService printService = new PrintService();


            if (tabControlSaleReport.SelectedIndex == 0)
            {
                var reportTitle = new List<SaleTitleReports>()
                {
                    new SaleTitleReports()
                    {
                        FullNameMantaghe = comboListManateghKol.Text,
                        MantagheCheckState = checkSelectMantagheKol.Checked,
                        _enumNoeKhanevade = (NoeKhanevade)noeKhanevade,
                        TarikhAval = txtStartDateKol.Text,
                        TarikhAkhar = txtEndDateKol.Text
                    }
                };

                string reportName = "SalesReportKol.frx";

                var reportDataSource1 = (List<SaleReportKolByNoeKhanevadeViewModel>)ReportDataGridKol.DataSource;

                var reportData = Tuple.Create(reportTitle, reportDataSource1);

                string reportDirectory = GeneratePrintFileDirectory(reportName);


                if (sender.Equals(btnDesignReport))
                {
                    printService.ShowDesigner(reportData.ToValueTuple(), reportDirectory);
                }
                else
                {
                    printService.PrintPreview(reportData.ToValueTuple(), reportDirectory);
                }
            }
            else
            {
                string reportName = "DetailsSaleReport.frx";

                var reportTitle = new List<SaleTitleReports>()
                {
                    new SaleTitleReports()
                    {
                        FullNameMantaghe = comboListManategh.Text,
                        MantagheCheckState = checkSelectMantaghe.Checked,
                        _enumNoeKhanevade = (NoeKhanevade)noeKhanevade,
                        TarikhAval = txtStartDate.Text,
                        TarikhAkhar = txtEndDate.Text
                    }
                };

                var reportDataSource2 = (List<SaleReportDetailByNoeKhanevadeViewModel>)ReportDataGrid.DataSource;

                var reportDataSource1 = reportDataSource2.GroupBy(g => new { g.FullNameKhanevade, g.KodTafzili }).Select(s => new NameShomareParvandeViewModel() { FullNameKhanevade = s.Key.FullNameKhanevade, ShomareParvande = s.Key.KodTafzili }).ToList();

                var reportData = Tuple.Create(reportTitle, reportDataSource1, reportDataSource2);

                string reportDirectory = GeneratePrintFileDirectory(reportName);

                if (sender.Equals(btnOpenReportDesinger))
                {
                    printService.ShowDesigner(reportData.ToValueTuple(), reportDirectory);
                }
                else
                {
                    printService.PrintPreview(reportData.ToValueTuple(), reportDirectory);
                }
            }

        }

        private static string GeneratePrintFileDirectory(string reportName)
        {
            var reportDirectory = Path.Combine(Application.StartupPath, "PrintFiles", reportName);
            if (!File.Exists(reportDirectory))
            {
                File.Create(reportDirectory).Close();
                byte[] reportFile = null;

                switch (reportName)
                {
                    case "SaleReportKol.frx":
                        reportFile = Properties.Resources.SalesReportKol;
                        break;
                    case "DetailsSaleReport.frx":
                        reportFile = Properties.Resources.DetailsSaleReport;
                        break;
                    default:
                        break;
                }

                File.WriteAllBytes(reportDirectory, reportFile);
            }
            return reportDirectory;
        }

        private void radioSadat_CheckedChanged(object sender, EventArgs e)
        {
            CheckCurrentRadioBtnState();
        }

        private async void SaleReportGroupByNoeKhanevade_Load(object sender, EventArgs e)
        {
            try
            {
                using (ISaleReportService saleReportService = new SaleReportService())
                {
                    string today = DateTime.Today.ToShortDateString();

                    txtStartDate.Text = today;
                    txtEndDate.Text = today;
                    txtEndDateKol.Text = today;
                    txtStartDateKol.Text = today;

                    listManategh = await saleReportService.GetListManateghAsync();

                    comboListManateghKol.DataSource = listManategh;
                    comboListManategh.DataSource = listManategh;

                    comboListManateghKol.DisplayMember = "FullNameMantaghe";
                    comboListManateghKol.ValueMember = "ShomareMantaghe";

                    comboListManategh.DisplayMember = "FullNameMantaghe";
                    comboListManategh.ValueMember = "ShomareMantaghe";

                    lblDbNameAnbar.Text += saleReportService.GetDbName("Anbar");
                    lblDbNameManategh.Text += saleReportService.GetDbName("Manategh");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("لطفا از منوی تنظیمات، قسمت تنظیمات بانک اطلاعاتی را بررسی نمایید", "خطا در اتصال به بانک اطلاعاتی", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(Close));
            }

        }

    }
}
