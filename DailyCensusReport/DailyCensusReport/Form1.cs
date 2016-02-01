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
            int unitID = 
            string currentCensus = Convert.ToString(txtCCICU.Text);
            string availBeds = Convert.ToString(txtABICU.Text);
            string numOfIsoPatients = Convert.ToString(txtISOICU.Text);
            string potentialDCs = Convert.ToString(txtICUDC.Text);
            string notes = Convert.ToString(rtbICUNotes.Text);
            string currentCapStat = Convert.ToString(txtCCSICU.Text);

            //SubmitRecord sr = new SubmitRecord();
            SubmitRecord.AddRecord(unitID, currentCensus, availBeds, numOfIsoPatients, potentialDCs, notes, currentCapStat);
            
           
        }
    }
}
