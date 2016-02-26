/* Hospital Daily Census Report *
 * Created By: Anthony Fiori III & Anthony Rondini *
 * Latest Update: 2/25/2016 *
 */

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
        public TextBox[,] allTextChangeUnits { get; set; }
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
            //Arrays for each unit to hold each variable
            string[] varICU = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
            string[] varT2 = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
            string[] varPEDI = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
            string[] varT4 = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
            string[] var6ACU = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
            string[] varTBC = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
            string[] varBHU = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };

            #region CalcColor Method Call
            /***Calling the CalcColor method from the CalculationColorChanger class***/
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
            #endregion

            #region PDF Method Call
            /***Calling the PDFView method from the PDFSubmit class.***/
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
            #endregion

            #region For Loops for TextBoxes
            /***********************************************************************************************************************************************************************/
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
            /***********************************************************************************************************************************************************************/
            #endregion

            /***Calling the Insert methods from the SubmitRecord class***/
            SubmitRecord.InsertICU(unitID, varICU);
            SubmitRecord.InsertT2(unitIDT2, varT2);
            SubmitRecord.InsertPEDI(unitIDPEDI, varPEDI);
            SubmitRecord.InsertT4(unitIDT4, varT4);
            SubmitRecord.Insert6ACU(unitID6ACU, var6ACU);
            SubmitRecord.InsertTBC(unitIDTBC, varTBC);
            SubmitRecord.InsertBHU(unitIDBHU, varBHU);
        }

        //Opens the view record form
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

        private void txtCurrentCensusICU_TextChanged(object sender, EventArgs e)
        {
            int icuCensus = 0;
            Int32.TryParse(txtCurrentCensusICU.Text, out icuCensus);
            if (!string.IsNullOrWhiteSpace(txtCurrentCensusICU.Text))
            {
                if (icuCensus <= 9)
                {
                    txtAvailableBedsICU.Text = Convert.ToInt32(9 - icuCensus).ToString();
                }

            }
            else if (string.IsNullOrWhiteSpace(txtCurrentCensusICU.Text))
            {
                txtAvailableBedsICU.Text = "";
            }
        }

        private void txtCurrentCensusT2_TextChanged(object sender, EventArgs e)
        {
            int t2Census = 0;
            Int32.TryParse(txtCurrentCensusT2.Text, out t2Census);
            if (!string.IsNullOrWhiteSpace(txtCurrentCensusT2.Text))
            {
                if (t2Census <= 28)
                {
                    txtAvailableBedsT2.Text = Convert.ToInt32(28 - t2Census).ToString();
                }
            }
            else if (string.IsNullOrWhiteSpace(txtCurrentCensusT2.Text))
            {
                txtAvailableBedsT2.Text = "";
            }
        }

        private void txtCurrentCensusPEDI_TextChanged(object sender, EventArgs e)
        {
            int pediCensus = 0;
            Int32.TryParse(txtCurrentCensusPEDI.Text, out pediCensus);
            if (!string.IsNullOrWhiteSpace(txtCurrentCensusPEDI.Text))
            {
                if (pediCensus <= 28)
                {
                    txtAvailableBedsPEDI.Text = Convert.ToInt32(28 - pediCensus).ToString();
                }
            }
            else if (string.IsNullOrWhiteSpace(txtCurrentCensusPEDI.Text))
            {
                txtAvailableBedsPEDI.Text = "";
            }
        }

        private void txtCurrentCensusT4_TextChanged(object sender, EventArgs e)
        {
            int t4Census = 0;
            Int32.TryParse(txtCurrentCensusT4.Text, out t4Census);
            if (!string.IsNullOrWhiteSpace(txtCurrentCensusT4.Text))
            {
                if (t4Census <= 29)
                {
                    txtAvailableBedsT4.Text = Convert.ToInt32(29 - t4Census).ToString();
                }
            }
            else if (string.IsNullOrWhiteSpace(txtCurrentCensusT4.Text))
            {
                txtAvailableBedsT4.Text = "";
            }
        }

        private void txtCurrentCensus6ACU_TextChanged(object sender, EventArgs e)
        {

            int acuCensus = 0;
            Int32.TryParse(txtCurrentCensus6ACU.Text, out acuCensus);
            if (!string.IsNullOrWhiteSpace(txtCurrentCensus6ACU.Text))
            {
                if (acuCensus <= 10)
                {
                    txtAvailableBeds6ACU.Text = Convert.ToInt32(10 - acuCensus).ToString();
                }
            }
            else if (string.IsNullOrWhiteSpace(txtCurrentCensus6ACU.Text))
            {
                txtAvailableBeds6ACU.Text = "";
            }
        }

        private void txtCurrentCensusTBC_TextChanged(object sender, EventArgs e)
        {
            int tbcCensus = 0;
            Int32.TryParse(txtCurrentCensusTBC.Text, out tbcCensus);
            if (!string.IsNullOrWhiteSpace(txtCurrentCensusTBC.Text))
            {
                if (Convert.ToInt32(txtCurrentCensusTBC.Text) > 10)
                {
                    MessageBox.Show("TBC Current Census cannot exceed 10 patients", "Error");
                    txtAvailableBedsTBC.Text = "";
                }

                if (tbcCensus <= 10)
                {
                    txtAvailableBedsTBC.Text = Convert.ToInt32(10 - tbcCensus).ToString();
                }
            }
            else if (string.IsNullOrWhiteSpace(txtCurrentCensusTBC.Text))
            {
                txtAvailableBedsTBC.Text = "";
            }
        }

        private void txtCurrentCensusBHU_TextChanged(object sender, EventArgs e)
        {
            int bhuCensus = 0;
            Int32.TryParse(txtCurrentCensusBHU.Text, out bhuCensus);
            if (!string.IsNullOrWhiteSpace(txtCurrentCensusBHU.Text))
            {
                if (bhuCensus <= 15)
                {
                    txtAvailableBedsBHU.Text = Convert.ToInt32(15 - bhuCensus).ToString();
                }
            }
            else if (string.IsNullOrWhiteSpace(txtCurrentCensusBHU.Text))
            {
                txtAvailableBedsBHU.Text = "";
            }
        }
    }
}

