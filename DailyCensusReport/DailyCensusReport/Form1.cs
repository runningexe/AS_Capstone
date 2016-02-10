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
        public TextBox[] boxesICU { get; set; }
        public TextBox[] boxesT2 { get; set; }
        public TextBox[] boxesPEDI { get; set; }
        public TextBox[] boxesT4 { get; set; }
        public TextBox[] boxes6ACU{ get; set; }
        public TextBox[] boxesTBC { get; set; }
        public TextBox[] boxesBHU { get; set; }
        public List<TextBox[]> boxesAll { get; set; }
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

            reBindText();

            List<TextBox[]> boxes = boxesAll;
            SubmitRecord.AddRecord(boxes);

            txtCurrentCapStatusICU.Text = "Green";
            txtCurrentCapStatusT2.Text = "Green";
            txtCurrentCapStatusPEDI.Text = "Green";
            txtCurrentCapStatusT4.Text = "Green";
            txtCurrentCapStatus6ACU.Text = "Green";
            txtCurrentCapStatusTBC.Text = "Green";
            txtCurrentCapStatusBHU.Text = "Green";

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

        private void reBindText()
        {
            boxesICU = new TextBox[] { txtCurrentCensusICU, txtAvailableBedsICU, txtIsoPatientsICU, txtDischargesICU, txtNotesICU, txtCurrentCapStatusICU };
            boxesT2 = new TextBox[] { txtCurrentCensusT2, txtAvailableBedsT2, txtIsoPatientsT2, txtDischargesT2, txtNotesT2, txtCurrentCapStatusT2 };
            boxesPEDI = new TextBox[] { txtCurrentCensusPEDI, txtAvailableBedsPEDI, txtIsoPatientsPEDI, txtDischargesPEDI, txtNotesPEDI, txtCurrentCapStatusPEDI };
            boxesT4 = new TextBox[] { txtCurrentCensusT4, txtAvailableBedsT4, txtIsoPatientsT4, txtDischargesT4, txtNotesT4, txtCurrentCapStatusT4 };
            boxes6ACU = new TextBox[] { txtCurrentCensus6ACU, txtAvailableBeds6ACU, txtIsoPatients6ACU, txtDischarges6ACU, txtNotes6ACU, txtCurrentCapStatus6ACU };
            boxesTBC = new TextBox[] { txtCurrentCensusTBC, txtAvailableBedsTBC, txtIsoPatientsTBC, txtDischargesTBC, txtNotesTBC, txtCurrentCapStatusTBC };
            boxesBHU = new TextBox[] { txtCurrentCensusBHU, txtAvailableBedsBHU, txtIsoPatientsBHU, txtDischargesBHU, txtNotesBHU, txtCurrentCapStatusBHU };
            boxesAll = new List<TextBox[]> { boxesICU, boxesT2, boxesPEDI, boxesT4, boxes6ACU, boxesTBC, boxesBHU };
        }
    }
}
