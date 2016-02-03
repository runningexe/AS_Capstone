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
        SaveFileDialog sfd = new SaveFileDialog();

        public frmDailyCensusReport()
        {
            InitializeComponent();
        }

        private void frmDailyCensusReport_Load(object sender, EventArgs e)
        {
         
        }

/*Submit's entered Data into database
 Calculates Current Census & Avail Beds to determine Capactiy Status color
 Prints entered data into a PDF and saves to Desktop*/
        private void btnSubmit_Click(object sender, EventArgs e)
        {

//Submits into database
            int unitID = 1;
            string currentCensus = Convert.ToString(txtCCICU.Text);
            string availBeds = Convert.ToString(txtABICU.Text);
            string numOfIsoPatients = Convert.ToString(txtISOICU.Text);
            string potentialDCs = Convert.ToString(txtICUDC.Text);
            string notes = Convert.ToString(rtbICUNotes.Text);
            string currentCapStat = Convert.ToString(txtCCSICU.Text);

            //SubmitRecord sr = new SubmitRecord();
            SubmitRecord.AddRecord(unitID,currentCensus, availBeds, numOfIsoPatients, potentialDCs, notes, currentCapStat);

//To save PDF to desktop
//path to save to your desktop
            sfd.Title = "Save As PDF";
            sfd.Filter = "PDF|.PDF";
            sfd.InitialDirectory = @"C:\Users\RunningEXE\Desktop";

            sfd.InitialDirectory = @"C:\Users\Anthony J. Fiori\Desktop";


//pops up the dialog box to actually save
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
//pushes out notification when PDF is created
                MessageBox.Show("PDF Saved to " + wri);

                MessageBox.Show("PDF Created");
//Open Document to write
                doc.Open();
//write some content
                Paragraph paragraph = new Paragraph(txtInfo.Text + " " + "This is my firest line using paragraph. ");
//now add the above created text using different class object to our pdf document
                doc.Add(paragraph);
//close document
                doc.Close();
            }
           
        }
//Redirects to the ViewRecord Form
        private void btnViewRecord_Click(object sender, EventArgs e)
        {
            this.Show();
            ViewRecordsForm openVR = new ViewRecordsForm();
            openVR.Show(); 
        }
    }
}
