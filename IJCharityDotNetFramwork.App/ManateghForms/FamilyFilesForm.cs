using IJCharityDotNetFramwork.Core.Services;
using IJCharityDotNetFramwork.Core.Services.Interfaces;
using System.Windows.Forms;

namespace IJCharityDotNetFramwork.App.ManateghForms
{
    public partial class FamilyFilesForm : Form
    {
        public FamilyFilesForm()
        {
            InitializeComponent();
        }

        private async void FamilyFilesForm_Load(object sender, System.EventArgs e)
        {
            IFamilyFileService familyFileService = new FamilyFileService();
            ReportDataGridKol.AutoGenerateColumns = false;
            ReportDataGridKol.DataSource = await familyFileService.GetFamilyFilesAsync();

        }
    }
}
