using IJCharityDotNetFramwork.App.AnbarForms;
using IJCharityDotNetFramwork.App.ManateghForms;
using IJCharityDotNetFramwork.App.SettingsForm;
using System;
using System.Windows.Forms;

namespace IJCharityDotNetFramwork.App
{
    public partial class MainForm : Form
    {
        #region Forms Show Management

        private SaleReportGroupByNoeKhanevade _saleReportGroupByNoeKhanevade;
        private DbConnectionsForm _dbConnectionsForm;
        private FamilyFilesForm _familyFilesForm;

        public SaleReportGroupByNoeKhanevade SaleReportGroupByNoeKhanevade
        {
            get
            {
                if (_saleReportGroupByNoeKhanevade == null || _saleReportGroupByNoeKhanevade.IsDisposed)
                {
                    _saleReportGroupByNoeKhanevade = new SaleReportGroupByNoeKhanevade();
                    _saleReportGroupByNoeKhanevade.MdiParent = this;
                    _saleReportGroupByNoeKhanevade.Dock = DockStyle.Fill;
                }
                _saleReportGroupByNoeKhanevade.BringToFront();
                return _saleReportGroupByNoeKhanevade;
            }
        }
        public DbConnectionsForm DbConnectionsForm
        {
            get
            {
                if (_dbConnectionsForm == null || _dbConnectionsForm.IsDisposed)
                {
                    _dbConnectionsForm = new DbConnectionsForm();
                    _dbConnectionsForm.MdiParent = this;
                    _dbConnectionsForm.Dock = DockStyle.Fill;
                }
                _dbConnectionsForm.BringToFront();
                return _dbConnectionsForm;
            }
        }

        public FamilyFilesForm FamilyFilesForm
        {
            get
            {
                if (_familyFilesForm == null || _familyFilesForm.IsDisposed)
                {
                    _familyFilesForm = new FamilyFilesForm();
                    _familyFilesForm.MdiParent = this;
                    _familyFilesForm.Dock = DockStyle.Fill;
                }
                _familyFilesForm.BringToFront();
                return _familyFilesForm;
            }
        }

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }


        private void saleReportbyNoeKhanevadeMenu_Click(object sender, EventArgs e)
        {
            SaleReportGroupByNoeKhanevade.Show();
        }

        private void connectionStringsMenu_Click(object sender, EventArgs e)
        {
            DbConnectionsForm.Show();
        }

        private void FamilyFilesMenu_Click(object sender, EventArgs e)
        {
            FamilyFilesForm.Show();
        }
    }
}
