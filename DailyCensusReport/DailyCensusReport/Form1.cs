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

        private SubmitRecord addRecord = new SubmitRecord();

        private void frmDailyCensusReport_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.spICUTableAdapter.Fill(this.sE265_AJF1130DataSet.spICU, new System.Nullable<int>(((int)(System.Convert.ChangeType(unitIDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
