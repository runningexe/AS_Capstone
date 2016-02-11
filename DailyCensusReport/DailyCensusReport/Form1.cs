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
        //public TextBox[] boxesICU { get; set; }
        //public TextBox[] boxesT2 { get; set; }
        //public TextBox[] boxesPEDI { get; set; }
        //public TextBox[] boxesT4 { get; set; }
        //public TextBox[] boxes6ACU { get; set; }
        //public TextBox[] boxesTBC { get; set; }
        //public TextBox[] boxesBHU { get; set; }
        //public List<TextBox[]> boxesAll { get; set; }
        //public TextBox[] boxesAllCurrentCensus { get; set; }
        //public TextBox[] boxesAllAvailBeds { get; set; }

        public frmDailyCensusReport()
        {
            InitializeComponent();           
        }

        private void frmDailyCensusReport_Load(object sender, EventArgs e)
        {
        
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           //reBindText();

            CalculationColorChanger.CalcColor(
//ICU
              txtCurrentCensusICU, txtAvailableBedsICU, txtIsoPatientsICU, txtDischargesICU, txtNotesICU, txtCurrentCapStatusICU,
//T2
              txtCurrentCensusT2, txtAvailableBedsT2, txtIsoPatientsT2, txtDischargesT2, txtNotesT2, txtCurrentCapStatusT2
              );


//Populates information into the PDF
            PDFSubmit.PDFView(
//ICU
              txtCurrentCensusICU,txtAvailableBedsICU, txtIsoPatientsICU, txtDischargesICU, txtNotesICU, txtCurrentCapStatusICU,
//T2
              txtCurrentCensusT2,txtAvailableBedsT2,txtIsoPatientsT2,txtDischargesT2,txtNotesT2,txtCurrentCapStatusT2
              );
//ICU
            int unitID = 1;
            string currentCensus = Convert.ToString(txtCurrentCensusICU.Text);
            string availBeds = Convert.ToString(txtAvailableBedsICU.Text);
            string numOfIsoPatients = Convert.ToString(txtIsoPatientsICU.Text);
            string potentialDCs = Convert.ToString(txtDischargesICU.Text);
            string notes = Convert.ToString(txtNotesICU.Text);
            string currentCapStat = Convert.ToString(txtCurrentCapStatusICU.Text);
//T2
            int unitIDT2 = 2;
            string currentCensusT2 = Convert.ToString(txtCurrentCensusT2.Text);
            string availBedsT2 = Convert.ToString(txtAvailableBedsT2.Text);
            string numOfIsoPatientsT2 = Convert.ToString(txtIsoPatientsT2.Text);
            string potentialDCsT2 = Convert.ToString(txtDischargesT2.Text);
            string notesT2 = Convert.ToString(txtNotesT2.Text);
            string currentCapStatT2 = Convert.ToString(txtCurrentCapStatusT2.Text);

           

            //List<TextBox[]> boxes = boxesAll;

 //AddRecord method that gets the user input and inserts it into the database.
/****************************************************************************************************************/
//ICU
            SubmitRecord.InsertICU(unitID, currentCensus, availBeds, numOfIsoPatients, potentialDCs, notes, currentCapStat);
/****************************************************************************************************************/
//T2
            SubmitRecord.InsertT2(unitIDT2, currentCensusT2, availBedsT2, numOfIsoPatientsT2, potentialDCsT2, notesT2, currentCapStatT2);
            
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

        //    boxesICU = new TextBox[] { txtCurrentCensusICU, txtAvailableBedsICU, txtIsoPatientsICU, txtDischargesICU, txtNotesICU, txtCurrentCapStatusICU };
            
        //    boxesT2 = new TextBox[] { txtCurrentCensusT2, txtAvailableBedsT2, txtIsoPatientsT2, txtDischargesT2, txtNotesT2, txtCurrentCapStatusT2 };
            
        //    boxesPEDI = new TextBox[] { txtCurrentCensusPEDI, txtAvailableBedsPEDI, txtIsoPatientsPEDI, txtDischargesPEDI, txtNotesPEDI, txtCurrentCapStatusPEDI };
            
        //    boxesT4 = new TextBox[] { txtCurrentCensusT4, txtAvailableBedsT4, txtIsoPatientsT4, txtDischargesT4, txtNotesT4, txtCurrentCapStatusT4 };
            
        //    boxes6ACU = new TextBox[] { txtCurrentCensus6ACU, txtAvailableBeds6ACU, txtIsoPatients6ACU, txtDischarges6ACU, txtNotes6ACU, txtCurrentCapStatus6ACU };
            
        //    boxesTBC = new TextBox[] { txtCurrentCensusTBC, txtAvailableBedsTBC, txtIsoPatientsTBC, txtDischargesTBC, txtNotesTBC, txtCurrentCapStatusTBC };
            
        //    boxesBHU = new TextBox[] { txtCurrentCensusBHU, txtAvailableBedsBHU, txtIsoPatientsBHU, txtDischargesBHU, txtNotesBHU, txtCurrentCapStatusBHU };
            
        //    boxesAll = new List<TextBox[]> { boxesICU, boxesT2, boxesPEDI, boxesT4, boxes6ACU, boxesTBC, boxesBHU };

        //    boxesAllCurrentCensus = new TextBox[] { txtCurrentCensusICU, txtCurrentCensusT2 };

        //    boxesAllAvailBeds = new TextBox[] { txtAvailableBedsICU, txtAvailableBedsT2 };
        }
    }
}
