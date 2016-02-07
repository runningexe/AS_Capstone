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
             *Possibly could put all of this into a loop.
             *It wouldn't be possible to have the same variable 
             *names that match the arguments for the AddRecord 
             *method so putting the unitID number, and the different 
             *textboxes into an array or separate arrays and looping through 
             *it/them would be most efficient, and logical. (Its also why I 
             *changed the naming of the textboxes to be more general.
             *********************************************************/
            int unitID = 1;
            string currentCensus = Convert.ToString(txtCurrentCensusICU.Text);
            string availBeds = Convert.ToString(txtAvailableBedsICU.Text);
            string numOfIsoPatients = Convert.ToString(txtIsoPatientsICU.Text);
            string potentialDCs = Convert.ToString(txtDischargesICU.Text);
            string notes = Convert.ToString(txtNotesICU.Text);
            string currentCapStat = Convert.ToString(txtCurrentCapStatusICU.Text);
            /***********************************************************/

            //AddRecord method that gets the user input and inserts it into the database.
            SubmitRecord.AddRecord(unitID, currentCensus, availBeds, numOfIsoPatients, potentialDCs, notes, currentCapStat);

            int ICUCC1 = Convert.ToInt32(txtCurrentCensusICU.Text);
            int ICUAB2 = Convert.ToInt32(txtAvailableBedsICU.Text);
            txtCurrentCapStatusICU.Text = "";

            if (ICUCC1 <= 5)
            {
                txtCurrentCapStatusICU.BackColor = Color.Green;
                txtCurrentCapStatusICU.Text = "GREEN";
            }

                else if (ICUCC1 > 7)
                {
                    txtCurrentCapStatusICU.BackColor = Color.Red;
                    txtCurrentCapStatusICU.Text = "RED";
                }

            PDFSubmit.PDFView(txtCurrentCensusICU, txtAvailableBedsICU, txtIsoPatientsICU, txtDischargesICU, txtNotesICU, txtCurrentCapStatusICU);  
       
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
