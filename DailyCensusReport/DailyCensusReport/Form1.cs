using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyCensusReport
{
    public partial class frmDailyCensusReport : Form
    {
        public frmDailyCensusReport()
        {
            InitializeComponent();
        }

        private void iCUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iCUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sE265_AJF1130DataSet);

        }

        private void frmDailyCensusReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet.ICU' table. You can move, or remove it, as needed.
            this.iCUTableAdapter.Fill(this.sE265_AJF1130DataSet.ICU);

        }
    }
}
