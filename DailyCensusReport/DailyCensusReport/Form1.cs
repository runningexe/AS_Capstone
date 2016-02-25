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
        public TextBox[] boxes6ACU { get; set; }
        public TextBox[] boxesTBC { get; set; }
        public TextBox[] boxesBHU { get; set; }
        

        public frmDailyCensusReport()
        {
            InitializeComponent();
        }

        private void frmDailyCensusReport_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //An array that holds generic variables that will be used for each unit/table.

            //ICU
            string[] varICU = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
            //T2
            string[] varT2 = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };

            //PEDI
            string[] varPEDI = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };

            //T4
            string[] varT4 = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };

            //6ACU
            string[] var6ACU = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };

            //TBC
            string[] varTBC = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };

            //BHU
            string[] varBHU = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };

/********************************************************************/
//Calculation Class
            CalculationColorChanger.CalcColor(
            //ICU
              txtCurrentCensusICU, txtCurrentCapStatusICU, 

            //T2
              txtCurrentCensusT2, txtCurrentCapStatusT2,

            //PEDI
              txtCurrentCensusPEDI, txtCurrentCapStatusPEDI,
              
             //T4
             txtCurrentCensusT4, txtCurrentCapStatusT4,
             
             //6ACU
             txtCurrentCensus6ACU, txtCurrentCapStatus6ACU,
            
             //TBC
             txtCurrentCensusTBC, txtCurrentCapStatusTBC,
            
             //BHU
             txtCurrentCensusBHU, txtCurrentCapStatusBHU);

/********************************************************************/
//PDF Class
//Populates information into the PDF based on the user's input.
            PDFSubmit.PDFView(
              //ICU
              txtCurrentCensusICU, txtAvailableBedsICU, txtIsoPatientsICU, txtDischargesICU, txtNotesICU, txtCurrentCapStatusICU,

              //T2
              txtCurrentCensusT2, txtAvailableBedsT2, txtIsoPatientsT2, txtDischargesT2, txtNotesT2, txtCurrentCapStatusT2,

              //PEDI
              txtCurrentCensusPEDI, txtAvailableBedsPEDI, txtIsoPatientsPEDI, txtDischargesPEDI, txtNotesPEDI, txtCurrentCapStatusPEDI,

              //T4
              txtCurrentCensusT4, txtAvailableBedsT4, txtIsoPatientsT4, txtDischargesT4, txtNotesT4, txtCurrentCapStatusT4,

              //6ACU
              txtCurrentCensus6ACU, txtAvailableBeds6ACU, txtIsoPatients6ACU, txtDischarges6ACU, txtNotes6ACU, txtCurrentCapStatus6ACU,

               //TBC
              txtCurrentCensusTBC, txtAvailableBedsTBC, txtIsoPatientsTBC, txtDischargesTBC, txtNotesTBC, txtCurrentCapStatusTBC,

               //BHU
              txtCurrentCensusBHU, txtAvailableBedsBHU, txtIsoPatientsBHU, txtDischargesBHU, txtNotesBHU, txtCurrentCapStatusBHU
              );

/********************************************************************/
/***Gives a unitID for each table***/
                
                //ICU
                int unitID = 1;
                boxesICU = new TextBox[] { txtCurrentCensusICU, txtAvailableBedsICU, txtIsoPatientsICU, txtDischargesICU, txtNotesICU, txtCurrentCapStatusICU };
                for (int i = 0; i < boxesICU.Length; i++)
                {
                    varICU[i] = Convert.ToString(boxesICU[i].Text);
                }

                //T2
                int unitIDT2 = 2;
                boxesT2 = new TextBox[] { txtCurrentCensusT2, txtAvailableBedsT2, txtIsoPatientsT2, txtDischargesT2, txtNotesT2, txtCurrentCapStatusT2 };
                for (int i = 0; i < boxesT2.Length; i++)
                {
                    varT2[i] = Convert.ToString(boxesT2[i].Text);
                }

                //PEDI
                int unitIDPEDI = 3;
                boxesPEDI = new TextBox[] { txtCurrentCensusPEDI, txtAvailableBedsPEDI, txtIsoPatientsPEDI, txtDischargesPEDI, txtNotesPEDI, txtCurrentCapStatusPEDI };
                for (int i = 0; i < boxesPEDI.Length; i++)
                {
                    varPEDI[i] = Convert.ToString(boxesPEDI[i].Text);
                }

                //T4
                int unitIDT4 = 4;
                boxesPEDI = new TextBox[] { txtCurrentCensusT4, txtAvailableBedsT4, txtIsoPatientsT4, txtDischargesT4, txtNotesT4, txtCurrentCapStatusT4 };
                for (int i = 0; i < boxesPEDI.Length; i++)
                {
                    varT4[i] = Convert.ToString(boxesPEDI[i].Text);
                }

                //6ACU
                int unitID6ACU = 5;
                boxes6ACU = new TextBox[] { txtCurrentCensus6ACU, txtAvailableBeds6ACU, txtIsoPatients6ACU, txtDischarges6ACU, txtNotes6ACU, txtCurrentCapStatus6ACU };
                for (int i = 0; i < boxes6ACU.Length; i++)
                {
                    var6ACU[i] = Convert.ToString(boxes6ACU[i].Text);
                }

                //TBC
                int unitIDTBC = 6;
                boxesTBC = new TextBox[] { txtCurrentCensusTBC, txtAvailableBedsTBC, txtIsoPatientsTBC, txtDischargesTBC, txtNotesTBC, txtCurrentCapStatusTBC };
                for (int i = 0; i < boxesTBC.Length; i++)
                {
                    varTBC[i] = Convert.ToString(boxesTBC[i].Text);
                }

                //BHU
                int unitIDBHU = 7;
                boxesBHU = new TextBox[] { txtCurrentCensusBHU, txtAvailableBedsBHU, txtIsoPatientsBHU, txtDischargesBHU, txtNotesBHU, txtCurrentCapStatusBHU };
                for (int i = 0; i < boxesBHU.Length; i++)
                {
                    varBHU[i] = Convert.ToString(boxesBHU[i].Text);
                }

/********************************************************************/
/**SubmitRecord Class**/
            //ICU
            SubmitRecord.InsertICU(unitID, varICU);
            //T2
            SubmitRecord.InsertT2(unitIDT2, varT2);
            //PEDI
            SubmitRecord.InsertPEDI(unitIDPEDI, varPEDI);
            //T4
            SubmitRecord.InsertT4(unitIDT4, varT4);
            //6ACU
            SubmitRecord.Insert6ACU(unitID6ACU, var6ACU);
            //TBC
            SubmitRecord.InsertTBC(unitIDTBC, varTBC);
            //BHU
            SubmitRecord.InsertBHU(unitIDBHU, varBHU);
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
