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
        #region Unit TextBox Array
        public TextBox[] boxesICU { get; set; }
        public TextBox[,] allTextChangeUnits { get; set; }
        public TextBox[] boxesT2 { get; set; }
        public TextBox[] boxesPEDI { get; set; }
        public TextBox[] boxesT4 { get; set; }
        public TextBox[] boxes6ACU { get; set; }
        public TextBox[] boxesTBC { get; set; }
        public TextBox[] boxesBHU { get; set; }
        #endregion
        public frmDailyCensusReport()
        {
            InitializeComponent();
        }

        private void frmDailyCensusReport_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Checks to see if any information has been entered
            try
            {
               
                #region Unit Array
                //Arrays for each unit to hold each variable
                string[] varICU = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
                string[] varT2 = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
                string[] varPEDI = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
                string[] varT4 = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
                string[] var6ACU = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
                string[] varTBC = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
                string[] varBHU = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
                #endregion

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

                #region SubmitRecord Method Call
                /***Calling the Insert methods from the SubmitRecord class***/
                SubmitRecord.InsertICU(unitID, varICU);
                SubmitRecord.InsertT2(unitIDT2, varT2);
                SubmitRecord.InsertPEDI(unitIDPEDI, varPEDI);
                SubmitRecord.InsertT4(unitIDT4, varT4);
                SubmitRecord.Insert6ACU(unitID6ACU, var6ACU);
                SubmitRecord.InsertTBC(unitIDTBC, varTBC);
                SubmitRecord.InsertBHU(unitIDBHU, varBHU);

                #endregion
            }
            //If no information has been entered error message box pops up
            catch
            {
                MessageBox.Show("Please Complete All Information", "Error");
            }
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

//ICU Text Change
        private void txtCurrentCensusICU_TextChanged(object sender, EventArgs e)
        {
            // Checks to see if it is over 15 patients, if it's over it will clear textbox fields
            int icuCensus = 0;
            Int32.TryParse(txtCurrentCensusICU.Text, out icuCensus);
            if (!string.IsNullOrWhiteSpace(txtCurrentCensusICU.Text))
            {
                if (Convert.ToInt32(txtCurrentCensusICU.Text) > 9)
                {
                    MessageBox.Show("ICU Current Census cannot exceed 9 patients", "Error");
                    txtAvailableBedsICU.Text = "";
                    txtCurrentCensusICU.Text = "";
                }

                if (icuCensus <= 9)
                {
                    txtAvailableBedsICU.Text = Convert.ToInt32(9 - icuCensus).ToString();
                }
            }
            if (string.IsNullOrWhiteSpace(txtCurrentCensusICU.Text))
            {

                txtAvailableBedsICU.Text = "";
            }
        }

//T2 Text Change
        private void txtCurrentCensusT2_TextChanged(object sender, EventArgs e)
        {
            // Checks to see if it is over 28 patients, if it's over it will clear textbox fields
            int t2Census = 0;
            Int32.TryParse(txtCurrentCensusT2.Text, out t2Census);
            if (!string.IsNullOrWhiteSpace(txtCurrentCensusT2.Text))
            {
                if (Convert.ToInt32(txtCurrentCensusT2.Text) > 28)
                {
                    MessageBox.Show("T2 Current Census cannot exceed 28 patients", "Error");
                    txtAvailableBedsT2.Text = "";
                    txtCurrentCensusT2.Text = "";
                }

                if (t2Census <= 28)
                {
                    txtAvailableBedsT2.Text = Convert.ToInt32(28 - t2Census).ToString();
                }
            }
            if (string.IsNullOrWhiteSpace(txtCurrentCensusT2.Text))
            {

                txtAvailableBedsT2.Text = "";
            }
        }

//PEDI Text Change
        private void txtCurrentCensusPEDI_TextChanged(object sender, EventArgs e)
        {
            // Checks to see if it is over 28 patients, if it's over it will clear textbox fields
            int pediCensus = 0;
            Int32.TryParse(txtCurrentCensusPEDI.Text, out pediCensus);
            if (!string.IsNullOrWhiteSpace(txtCurrentCensusPEDI.Text))
            {
                if (Convert.ToInt32(txtCurrentCensusPEDI.Text) > 28)
                {
                    MessageBox.Show("PEDI Current Census cannot exceed 28 patients", "Error");
                    txtAvailableBedsPEDI.Text = "";
                    txtCurrentCensusPEDI.Text = "";
                }

                if (pediCensus <= 28)
                {
                    txtAvailableBedsPEDI.Text = Convert.ToInt32(28 - pediCensus).ToString();
                }
            }
            if (string.IsNullOrWhiteSpace(txtCurrentCensusPEDI.Text))
            {

                txtAvailableBedsPEDI.Text = "";
            }
        }

//T4 Text Change
        private void txtCurrentCensusT4_TextChanged(object sender, EventArgs e)
        {
            // Checks to see if it is over 29 patients, if it's over it will clear textbox fields
            int t4Census = 0;
            Int32.TryParse(txtCurrentCensusT4.Text, out t4Census);
            if (!string.IsNullOrWhiteSpace(txtCurrentCensusT4.Text))
            {
                if (Convert.ToInt32(txtCurrentCensusT4.Text) > 29)
                {
                    MessageBox.Show("T4 Current Census cannot exceed 29 patients", "Error");
                    txtAvailableBedsT4.Text = "";
                    txtCurrentCensusT4.Text = "";
                }

                if (t4Census <= 29)
                {
                    txtAvailableBedsT4.Text = Convert.ToInt32(29 - t4Census).ToString();
                }
            }
            if (string.IsNullOrWhiteSpace(txtCurrentCensusT4.Text))
            {

                txtAvailableBedsT4.Text = "";
            }
        }

//6ACU Text Change
        private void txtCurrentCensus6ACU_TextChanged(object sender, EventArgs e)
        {
            // Checks to see if it is over 10 patients, if it's over it will clear textbox fields
            int acuCensus = 0;
            Int32.TryParse(txtCurrentCensus6ACU.Text, out acuCensus);
            if (!string.IsNullOrWhiteSpace(txtCurrentCensus6ACU.Text))
            {
                if (Convert.ToInt32(txtCurrentCensus6ACU.Text) > 10)
                {
                    MessageBox.Show("6ACU Current Census cannot exceed 10 patients", "Error");
                    txtAvailableBeds6ACU.Text = "";
                    txtCurrentCensus6ACU.Text = "";
                }

                if (acuCensus <= 10)
                {
                    txtAvailableBeds6ACU.Text = Convert.ToInt32(10 - acuCensus).ToString();
                }
            }
            if (string.IsNullOrWhiteSpace(txtCurrentCensus6ACU.Text))
            {

                txtAvailableBeds6ACU.Text = "";
            }
        }

//TBC Text Change
        private void txtCurrentCensusTBC_TextChanged(object sender, EventArgs e)
        {
            // Checks to see if it is over 10 patients, if it's over it will clear textbox fields
            int tbcCensus = 0;
            Int32.TryParse(txtCurrentCensusTBC.Text, out tbcCensus);
            if (!string.IsNullOrWhiteSpace(txtCurrentCensusTBC.Text))
            {
                if (Convert.ToInt32(txtCurrentCensusTBC.Text) > 10)
                {
                    MessageBox.Show("TBC Current Census cannot exceed 10 patients", "Error");
                    txtAvailableBedsTBC.Text = "";
                    txtCurrentCensusTBC.Text = "";
                }

                if (tbcCensus <= 10)
                {
                    txtAvailableBedsTBC.Text = Convert.ToInt32(10 - tbcCensus).ToString();
                }
            }
            if (string.IsNullOrWhiteSpace(txtCurrentCensusTBC.Text))
            {

                txtAvailableBedsTBC.Text = "";
            }
        }

//BHU Text Change
        private void txtCurrentCensusBHU_TextChanged(object sender, EventArgs e)
        {
            // Checks to see if it is over 15 patients, if it's over it will clear textbox fields
            int bhuCensus = 0;
            Int32.TryParse(txtCurrentCensusBHU.Text, out bhuCensus);
            if (!string.IsNullOrWhiteSpace(txtCurrentCensusBHU.Text))
            {
                if (Convert.ToInt32(txtCurrentCensusBHU.Text) > 15)
                {
                    MessageBox.Show("BHU Current Census cannot exceed 15 patients", "Error");
                    txtAvailableBedsBHU.Text = "";
                    txtCurrentCensusBHU.Text = "";
                }

                if (bhuCensus <= 15)
                {
                    txtAvailableBedsBHU.Text = Convert.ToInt32(15 - bhuCensus).ToString();
                }
            }
            if (string.IsNullOrWhiteSpace(txtCurrentCensusBHU.Text))
            {
                if (bhuCensus <= 15)
                {
                    txtAvailableBedsBHU.Text = "";
                }
            }
        }
    }
}

