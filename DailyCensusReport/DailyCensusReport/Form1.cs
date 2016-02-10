using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Outlook = Microsoft.Office.Interop.Outlook;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
//using System.Reflection;

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

    //ICU
            int ICUCC1 = Convert.ToInt32(txtCurrentCensusICU.Text);
            int ICUAB2 = Convert.ToInt32(txtAvailableBedsICU.Text);
            txtCurrentCapStatusICU.Text = "";

    //T2
            int T2CC1 = Convert.ToInt32(txtCurrentCensusT2.Text);
            int T2AB2 = Convert.ToInt32(txtAvailableBedsT2.Text);
            txtCurrentCapStatusT2.Text = "";

        //ICU
            if (ICUCC1 <= 5)
            {
                txtCurrentCapStatusICU.BackColor = Color.Green;
                txtCurrentCapStatusICU.Text = "GREEN";
            }

                else if (ICUCC1 > 6)
                {
                    txtCurrentCapStatusICU.BackColor = Color.Red;
                    txtCurrentCapStatusICU.Text = "RED";
                }

        //T2
            if (T2CC1 <= 5)
            {
                txtCurrentCapStatusT2.BackColor = Color.Green;
                txtCurrentCapStatusT2.Text = "GREEN";
            }

            else if (T2CC1 > 6)
            {
                txtCurrentCapStatusT2.BackColor = Color.Red;
                txtCurrentCapStatusT2.Text = "RED";
            }


//Populates information into the PDF
            PDFSubmit.PDFView(
            //ICU
              txtCurrentCensusICU,txtAvailableBedsICU, txtIsoPatientsICU, txtDischargesICU, txtNotesICU, txtCurrentCapStatusICU,
            //T2
              txtCurrentCensusT2,txtAvailableBedsT2,txtIsoPatientsT2,txtDischargesT2,txtNotesT2,txtCurrentCapStatusT2
              );

            int unitID = 1;
            string currentCensus = Convert.ToString(txtCurrentCensusICU.Text);
            string availBeds = Convert.ToString(txtAvailableBedsICU.Text);
            string numOfIsoPatients = Convert.ToString(txtIsoPatientsICU.Text);
            string potentialDCs = Convert.ToString(txtDischargesICU.Text);
            string notes = Convert.ToString(txtNotesICU.Text);
            string currentCapStat = Convert.ToString(txtCurrentCapStatusICU.Text);

 //AddRecord method that gets the user input and inserts it into the database.
            SubmitRecord.AddRecord(unitID, currentCensus, availBeds, numOfIsoPatients, potentialDCs, notes, currentCapStat);
        }

        //Redirects to the ViewRecord Form
        private void btnViewRecord_Click(object sender, EventArgs e)
        {
            this.Show();
            ViewRecordsForm openVR = new ViewRecordsForm();
            openVR.Show(); 
        }

        //Closes Program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
