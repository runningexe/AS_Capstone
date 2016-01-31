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
       


        private void frmDailyCensusReport_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitRecord addRecord = new SubmitRecord(0, txtCCICU.Text, txtABICU.Text, txtISOICU.Text, txtICUDC.Text, rtbICUNotes.Text);
        }
    }
}
