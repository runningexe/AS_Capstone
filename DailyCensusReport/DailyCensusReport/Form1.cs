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
            //Create new SaveFileDialog object which opens up the Save Dialog for the PDF.
            SaveFileDialog sfd = new SaveFileDialog();

            /*********************************************************
             *Possibly could put all of this into a for-loop.
             *It wouldn't be possible to have the same variable 
             *names that match the arguments for the AddRecord 
             *method so putting the unitID number, and the different 
             *textboxes into an array and looping through it would
             *be most efficient, and logical. (Its also why I changed
             *the naming of the textboxes to be more general.
             *********************************************************/
            int unitID = 1;
            string currentCensus = Convert.ToString(txtCurrentCensus.Text);
            string availBeds = Convert.ToString(txtAvailableBeds.Text);
            string numOfIsoPatients = Convert.ToString(txtIsoPatients.Text);
            string potentialDCs = Convert.ToString(txtDischarges.Text);
            string notes = Convert.ToString(rtbNotes.Text);
            string currentCapStat = Convert.ToString(txtCurrentCapStatus.Text);
            /***********************************************************/
            /***********************************************************/
            /***********************************************************/
            /***********************************************************/

            //AddRecord method that gets the user input and inserts it into the database.
            SubmitRecord.AddRecord(unitID,currentCensus, availBeds, numOfIsoPatients, potentialDCs, notes, currentCapStat);

            int ICUCC1 = Convert.ToInt32(txtCurrentCensus.Text);
            int ICUAB2 = Convert.ToInt32(txtAvailableBeds.Text);
            txtCurrentCapStatus.Text = "";

            if (ICUCC1 <= 5)
            {
                txtCurrentCapStatus.BackColor = Color.Green;
                txtCurrentCapStatus.Text = "GREEN";
            }

            else if (ICUCC1 > 7)
            {
                txtCurrentCapStatus.BackColor = Color.Red;
                txtCurrentCapStatus.Text = "RED";
            }

            PDFSubmit.PDFView(txtCurrentCensus);  
                   
        }

        //private bool PDFRecord()
        //{
        //    return PDFSubmit.PDFView(txtCCICU);
        //}

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
