﻿/* Hospital Daily Census Report *
 * Created By: Anthony Fiori III & Anthony Rondini *
 * Latest Update: 3/02/2016 *
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
            lblHospDate.Text = DateTime.Today.ToLongDateString();
            lblGreeting.Text = "Hospital Daily Census Report";
        }

        //Submits Information
        private void btnSubmit_Click(object sender, EventArgs e)
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

            #region Checks Required Fields
            //Check to make sure all required fields are filled out
            if (txtIsoPatientsICU.Text == "" || txtDischargesICU.Text == "" ||
                txtIsoPatientsT2.Text == "" || txtDischargesT2.Text == "" ||
                txtIsoPatientsPEDI.Text == "" || txtDischargesPEDI.Text == "" ||
                txtIsoPatientsT4.Text == "" || txtDischargesT4.Text == "" ||
                txtIsoPatients6ACU.Text == "" || txtDischarges6ACU.Text == "" ||
                txtIsoPatientsTBC.Text == "" || txtDischargesTBC.Text == "" ||
                txtIsoPatientsBHU.Text == "" || txtDischargesBHU.Text == ""
                )
            {
                MessageBox.Show("Please Provide All Required Information", "ERROR MESSAGE");
            }
            #endregion

            else
            {
                #region CalcColor Method Call
                /***Calling the CalcColor method from the CalculationColorChanger class***/
                CalculationColorChanger.CalcColor(
                  //ICU
                  txtCurrentCensusICU, txtCurrentCapStatusICU, txtAvailableBedsICU, txtIsoPatientsICU, txtDischargesICU,

                  //T2
                  txtCurrentCensusT2, txtCurrentCapStatusT2, txtAvailableBedsT2, txtIsoPatientsT2, txtDischargesT2,

                  //PEDI
                  txtCurrentCensusPEDI, txtCurrentCapStatusPEDI, txtAvailableBedsPEDI, txtIsoPatientsPEDI, txtDischargesPEDI,

                  //T4
                  txtCurrentCensusT4, txtCurrentCapStatusT4, txtAvailableBedsT4, txtIsoPatientsT4, txtDischargesT4,

                  //6ACU
                  txtCurrentCensus6ACU, txtCurrentCapStatus6ACU, txtAvailableBeds6ACU, txtIsoPatients6ACU, txtDischarges6ACU,

                  //TBC
                  txtCurrentCensusTBC, txtCurrentCapStatusTBC, txtAvailableBedsTBC, txtIsoPatientsTBC, txtDischargesTBC,

                  //BHU
                  txtCurrentCensusBHU, txtCurrentCapStatusBHU, txtAvailableBedsBHU, txtIsoPatientsBHU, txtDischargesBHU,

                  ////Total
                  lblCCTotal, lblABTotal, lblISOTotal, lblTotalDC, txtCCSTotal
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

                //Confirmation for user if they want to save or cancel
                DialogResult result = MessageBox.Show("Are You Sure You Want To Save?", "Confirmation Message", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

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
                      txtCurrentCensusBHU, txtAvailableBedsBHU, txtIsoPatientsBHU, txtDischargesBHU, txtNotesBHU, txtCurrentCapStatusBHU,

                      //Total
                      lblCCTotal, lblABTotal, lblISOTotal, lblTotalDC, lbltotalNotes, txtCCSTotal
                      );
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
                else if (result == DialogResult.No)
                {
                    DialogResult = DialogResult.None;
                }

            }
        }

        //Brings You To The View Record Form
        private void btnViewRecord_Click(object sender, EventArgs e)
        {
            this.Show();
            ViewRecordsForm openVR = new ViewRecordsForm();
            openVR.Show();
        }

        //Brings You To The Help Form
        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Show();
            HelpForm openHelp = new HelpForm();
            openHelp.Show();
        }

        //ICU Current Census Text Change
        private void txtCurrentCensusICU_TextChanged(object sender, EventArgs e)
        {
            #region Checks Current Census ICU Field
            // Checks to see if it is over 9 patients, if it's over it will clear textbox fields
            int icuCensus = 0;
            Int32.TryParse(txtCurrentCensusICU.Text, out icuCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtCurrentCensusICU.Text))
                {
                    int icuNumCheck;
                    if (!int.TryParse(txtCurrentCensusICU.Text, out icuNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtCurrentCensusICU.Text = "";
                    }
                    else {
                        if (Convert.ToInt32(txtCurrentCensusICU.Text) > 9)
                        {
                            MessageBox.Show("ICU Current Census cannot exceed 9 patients", "ERROR MESSAGE");
                            txtAvailableBedsICU.Text = "";
                            txtCurrentCensusICU.Text = "";
                        }

                        if (icuCensus <= 9)
                        {
                            txtAvailableBedsICU.Text = Convert.ToInt32(9 - icuCensus).ToString();
                        }
                    }
                }
                if (string.IsNullOrWhiteSpace(txtCurrentCensusICU.Text))
                {
                    txtAvailableBedsICU.Text = "";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion

        }

        //ICU ISO Patient Text Change
        private void txtIsoPatientsICU_TextChanged(object sender, EventArgs e)
        {
            #region Checks ISO Patient ICU Field

            int icuIsoCensus = 0;
            Int32.TryParse(txtIsoPatientsICU.Text, out icuIsoCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtIsoPatientsICU.Text))
                {
                    int icuIsoNumCheck;
                    if (!int.TryParse(txtIsoPatientsICU.Text, out icuIsoNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtIsoPatientsICU.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion
        }

        //ICU DC Text Change
        private void txtDischargesICU_TextChanged(object sender, EventArgs e)
        {
            #region Checks DC ICU Field

            int icuDCCensus = 0;
            Int32.TryParse(txtDischargesICU.Text, out icuDCCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtDischargesICU.Text))
                {
                    int icuDCNumCheck;
                    if (!int.TryParse(txtDischargesICU.Text, out icuDCNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtDischargesICU.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion
        }
        /*************************************************************************************/


        //T2 Current Census Text Change
        private void txtCurrentCensusT2_TextChanged(object sender, EventArgs e)
        {
            #region Checks T2 Current Census Field
            try
            {
                // Checks to see if it is over 28 patients, if it's over it will clear textbox fields
                int t2Census = 0;
                Int32.TryParse(txtCurrentCensusT2.Text, out t2Census);
                if (!string.IsNullOrWhiteSpace(txtCurrentCensusT2.Text))
                {
                    int t2NumCheck;
                    if (!int.TryParse(txtCurrentCensusT2.Text, out t2NumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtCurrentCensusT2.Text = "";
                    }
                    else
                    {
                        if (Convert.ToInt32(txtCurrentCensusT2.Text) > 28)
                        {
                            MessageBox.Show("T2 Current Census cannot exceed 28 patients", "ERROR MESSAGE");
                            txtAvailableBedsT2.Text = "";
                            txtCurrentCensusT2.Text = "";
                        }

                        if (t2Census <= 28)
                        {
                            txtAvailableBedsT2.Text = Convert.ToInt32(28 - t2Census).ToString();
                        }
                    }
                }
                if (string.IsNullOrWhiteSpace(txtCurrentCensusT2.Text))
                {

                    txtAvailableBedsT2.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion
        }

        //T2 ISO Patient Text Change
        private void txtIsoPatientsT2_TextChanged(object sender, EventArgs e)
        {
            #region Checks ISO Patient T2 Field

            int t2IsoCensus = 0;
            Int32.TryParse(txtIsoPatientsT2.Text, out t2IsoCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtIsoPatientsT2.Text))
                {
                    int t2IsoNumCheck;
                    if (!int.TryParse(txtIsoPatientsT2.Text, out t2IsoNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtIsoPatientsT2.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion
        }

        // T2 DC Text Change
        private void txtDischargesT2_TextChanged(object sender, EventArgs e)
        {
            #region Checks DC T2 Field

            int t2IsoCensus = 0;
            Int32.TryParse(txtDischargesT2.Text, out t2IsoCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtDischargesT2.Text))
                {
                    int t2DcNumCheck;
                    if (!int.TryParse(txtDischargesT2.Text, out t2DcNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtDischargesT2.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion
        }

        /*******************************************************************************************/



        //PEDI Current Census Text Change
        private void txtCurrentCensusPEDI_TextChanged(object sender, EventArgs e)
        {
            #region Checks PEDI Current Census Field
            try
            {
                // Checks to see if it is over 28 patients, if it's over it will clear textbox fields
                int pediCensus = 0;
                Int32.TryParse(txtCurrentCensusPEDI.Text, out pediCensus);
                if (!string.IsNullOrWhiteSpace(txtCurrentCensusPEDI.Text))
                {
                    int pediNumCheck;
                    if (!int.TryParse(txtCurrentCensusPEDI.Text, out pediNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtCurrentCensusPEDI.Text = "";
                    }
                    else
                    {
                        if (Convert.ToInt32(txtCurrentCensusPEDI.Text) > 28)
                        {
                            MessageBox.Show("PEDI Current Census cannot exceed 28 patients", "ERROR MESSAGE");
                            txtAvailableBedsPEDI.Text = "";
                            txtCurrentCensusPEDI.Text = "";
                        }

                        if (pediCensus <= 28)
                        {
                            txtAvailableBedsPEDI.Text = Convert.ToInt32(28 - pediCensus).ToString();
                        }
                    }
                }
                if (string.IsNullOrWhiteSpace(txtCurrentCensusPEDI.Text))
                {

                    txtAvailableBedsPEDI.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion
        }

        //PEDI ISO Patient Text Change
        private void txtIsoPatientsPEDI_TextChanged(object sender, EventArgs e)
        {
            #region Checks ISO Patient PEDI Field

            int pediIsoCensus = 0;
            Int32.TryParse(txtIsoPatientsPEDI.Text, out pediIsoCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtIsoPatientsPEDI.Text))
                {
                    int pediDcNumCheck;
                    if (!int.TryParse(txtIsoPatientsPEDI.Text, out pediDcNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtIsoPatientsPEDI.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion
        }

        //PEDI DC Text Change
        private void txtDischargesPEDI_TextChanged(object sender, EventArgs e)
        {
            #region Checks DC PEDI Field

            int pediDcCensus = 0;
            Int32.TryParse(txtDischargesPEDI.Text, out pediDcCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtDischargesPEDI.Text))
                {
                    int pediDcNumCheck;
                    if (!int.TryParse(txtDischargesPEDI.Text, out pediDcNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtDischargesPEDI.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion
        }

        /*****************************************************************************************/


        //T4 Current Census Text Change
        private void txtCurrentCensusT4_TextChanged(object sender, EventArgs e)
        {
            #region Checks T4 Current Census Field
            try
            {
                // Checks to see if it is over 29 patients, if it's over it will clear textbox fields
                int t4Census = 0;
                Int32.TryParse(txtCurrentCensusT4.Text, out t4Census);
                if (!string.IsNullOrWhiteSpace(txtCurrentCensusT4.Text))
                {
                    int t4NumCheck;
                    if (!int.TryParse(txtCurrentCensusT4.Text, out t4NumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtCurrentCensusT4.Text = "";
                    }
                    else
                    {
                        if (Convert.ToInt32(txtCurrentCensusT4.Text) > 29)
                        {
                            MessageBox.Show("T4 Current Census cannot exceed 29 patients", "ERROR MESSAGE");
                            txtAvailableBedsT4.Text = "";
                            txtCurrentCensusT4.Text = "";
                        }

                        if (t4Census <= 29)
                        {
                            txtAvailableBedsT4.Text = Convert.ToInt32(29 - t4Census).ToString();
                        }
                    }
                }
                if (string.IsNullOrWhiteSpace(txtCurrentCensusT4.Text))
                {

                    txtAvailableBedsT4.Text = "";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion
        }

        // T4 ISO Patient Text Change
        private void txtIsoPatientsT4_TextChanged(object sender, EventArgs e)
        {
            #region Checks ISO Patient T4 Field

            int t4IsoCensus = 0;
            Int32.TryParse(txtIsoPatientsT4.Text, out t4IsoCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtIsoPatientsT4.Text))
                {
                    int t4IsoNumCheck;
                    if (!int.TryParse(txtIsoPatientsT4.Text, out t4IsoNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtIsoPatientsT4.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion
        }

        // T4 DC Text Change
        private void txtDischargesT4_TextChanged(object sender, EventArgs e)
        {
            #region Checks DC T4 Field

            int t4DcCensus = 0;
            Int32.TryParse(txtDischargesT4.Text, out t4DcCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtDischargesT4.Text))
                {
                    int t4DcNumCheck;
                    if (!int.TryParse(txtDischargesT4.Text, out t4DcNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtDischargesT4.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion
        }
        /****************************************************************************************/


        //6ACU Current Census Text Change
        private void txtCurrentCensus6ACU_TextChanged(object sender, EventArgs e)
        {
            #region Checks 6ACU Current Census Field
            try
            {
                // Checks to see if it is over 10 patients, if it's over it will clear textbox fields
                int acuCensus = 0;
                Int32.TryParse(txtCurrentCensus6ACU.Text, out acuCensus);
                if (!string.IsNullOrWhiteSpace(txtCurrentCensus6ACU.Text))
                {
                    int acuNumCheck;
                    if (!int.TryParse(txtCurrentCensus6ACU.Text, out acuNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtCurrentCensus6ACU.Text = "";
                    }
                    else
                    {
                        if (Convert.ToInt32(txtCurrentCensus6ACU.Text) > 10)
                        {
                            MessageBox.Show("6ACU Current Census cannot exceed 10 patients", "ERROR MESSAGE");
                            txtAvailableBeds6ACU.Text = "";
                            txtCurrentCensus6ACU.Text = "";
                        }

                        if (acuCensus <= 10)
                        {
                            txtAvailableBeds6ACU.Text = Convert.ToInt32(10 - acuCensus).ToString();
                        }
                    }
                }
                if (string.IsNullOrWhiteSpace(txtCurrentCensus6ACU.Text))
                {

                    txtAvailableBeds6ACU.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion
        }

        private void txtIsoPatients6ACU_TextChanged(object sender, EventArgs e)
        {
            #region Checks ISO Patient 6ACU Field

            int acuIsoCensus = 0;
            Int32.TryParse(txtIsoPatients6ACU.Text, out acuIsoCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtIsoPatients6ACU.Text))
                {
                    int acuIsoNumCheck;
                    if (!int.TryParse(txtIsoPatients6ACU.Text, out acuIsoNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtIsoPatients6ACU.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion
        }

        private void txtDischarges6ACU_TextChanged(object sender, EventArgs e)
        {
            #region Checks DC 6ACU Field

            int acuDcCensus = 0;
            Int32.TryParse(txtDischarges6ACU.Text, out acuDcCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtDischarges6ACU.Text))
                {
                    int acuDcNumCheck;
                    if (!int.TryParse(txtDischarges6ACU.Text, out acuDcNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtDischarges6ACU.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion
        }
        /*****************************************************************************************/


        //TBC Current Census Text Change
        private void txtCurrentCensusTBC_TextChanged(object sender, EventArgs e)
        {
            #region Checks TBC Current Census Field
            try
            {
                // Checks to see if it is over 10 patients, if it's over it will clear textbox fields
                int tbcCensus = 0;
                Int32.TryParse(txtCurrentCensusTBC.Text, out tbcCensus);
                if (!string.IsNullOrWhiteSpace(txtCurrentCensusTBC.Text))
                {
                    int tbcNumCheck;
                    if (!int.TryParse(txtCurrentCensusTBC.Text, out tbcNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtCurrentCensusTBC.Text = "";
                    }
                    else
                    {
                        if (Convert.ToInt32(txtCurrentCensusTBC.Text) > 10)
                        {
                            MessageBox.Show("TBC Current Census cannot exceed 10 patients", "ERROR MESSAGE");
                            txtAvailableBedsTBC.Text = "";
                            txtCurrentCensusTBC.Text = "";
                        }

                        if (tbcCensus <= 10)
                        {
                            txtAvailableBedsTBC.Text = Convert.ToInt32(10 - tbcCensus).ToString();
                        }
                    }
                }
                if (string.IsNullOrWhiteSpace(txtCurrentCensusTBC.Text))
                {

                    txtAvailableBedsTBC.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion
        }
        //TBC Iso Patient Text Change
        private void txtIsoPatientsTBC_TextChanged(object sender, EventArgs e)
        {
            #region Checks ISO Patient TBC Field

            int tbcIsoCensus = 0;
            Int32.TryParse(txtIsoPatientsTBC.Text, out tbcIsoCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtIsoPatientsTBC.Text))
                {
                    int tbcIsoNumCheck;
                    if (!int.TryParse(txtIsoPatientsTBC.Text, out tbcIsoNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtIsoPatientsTBC.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion
        }

        //TBC Dc Text Change
        private void txtDischargesTBC_TextChanged(object sender, EventArgs e)
        {
            #region Checks DC TBC Field

            int tbcDcCensus = 0;
            Int32.TryParse(txtDischargesTBC.Text, out tbcDcCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtDischargesTBC.Text))
                {
                    int tbcDcNumCheck;
                    if (!int.TryParse(txtDischargesTBC.Text, out tbcDcNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtDischargesTBC.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion
        }
        /*********************************************************************************************/


        //BHU Current Census Text Change
        private void txtCurrentCensusBHU_TextChanged(object sender, EventArgs e)
        {
            #region Checks BHU Current Census Field
            try
            {
                // Checks to see if it is over 15 patients, if it's over it will clear textbox fields
                int bhuCensus = 0;
                Int32.TryParse(txtCurrentCensusBHU.Text, out bhuCensus);
                if (!string.IsNullOrWhiteSpace(txtCurrentCensusBHU.Text))
                {
                    int bhuNumCheck;
                    if (!int.TryParse(txtCurrentCensusBHU.Text, out bhuNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtCurrentCensusBHU.Text = "";
                    }
                    else
                    {
                        if (Convert.ToInt32(txtCurrentCensusBHU.Text) > 15)
                        {
                            MessageBox.Show("BHU Current Census cannot exceed 15 patients", "ERROR MESSAGE");
                            txtAvailableBedsBHU.Text = "";
                            txtCurrentCensusBHU.Text = "";
                        }

                        if (bhuCensus <= 15)
                        {
                            txtAvailableBedsBHU.Text = Convert.ToInt32(15 - bhuCensus).ToString();
                        }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion
        }

        //BHU ISO Patients Text Change
        private void txtIsoPatientsBHU_TextChanged(object sender, EventArgs e)
        {
            #region Checks ISO Patient BHU Field

            int bhuIsoCensus = 0;
            Int32.TryParse(txtIsoPatientsBHU.Text, out bhuIsoCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtIsoPatientsBHU.Text))
                {
                    int bhuIsoNumCheck;
                    if (!int.TryParse(txtIsoPatientsBHU.Text, out bhuIsoNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtIsoPatientsBHU.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion
        }

        //BHU DC Text Change
        private void txtDischargesBHU_TextChanged(object sender, EventArgs e)
        {
            #region Checks DC BHU Field

            int bhuDcCensus = 0;
            Int32.TryParse(txtDischargesBHU.Text, out bhuDcCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtDischargesBHU.Text))
                {
                    int bhuDcNumCheck;
                    if (!int.TryParse(txtDischargesBHU.Text, out bhuDcNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "ERROR MESSAGE");
                        txtDischargesBHU.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            #endregion
        }

        /***************************************************************************************/

        //Closes Program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

