using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace DailyCensusReport
{
    class CalculationColorChanger
    {

        //public TextBox[] colorICUboxes { get; set; }

        public static bool CalcColor(

            TextBox txtCurrentCensusICU, TextBox txtCurrentCapStatusICU,
            TextBox txtCurrentCensusT2, TextBox txtCurrentCapStatusT2,
            TextBox txtCurrentCensusPEDI, TextBox txtCurrentCapStatusPEDI,
            TextBox txtCurrentCensusT4, TextBox txtCurrentCapStatusT4,
            TextBox txtCurrentCensus6ACU, TextBox txtCurrentCapStatus6ACU,
            TextBox txtCurrentCensusTBC, TextBox txtCurrentCapStatusTBC,
            TextBox txtCurrentCensusBHU, TextBox txtCurrentCapStatusBHU)
        {

            #region ICU Calculation
            /*****ICU****/
            //Determine the ICU Current Capacity Status
            int totalICUBeds = 9;
            totalICUBeds = Convert.ToInt32(txtCurrentCensusICU.Text);
            //txtCurrentCapStatusICU.Text = "";

            if (totalICUBeds <= 2)
            {
                txtCurrentCapStatusICU.BackColor = Color.Green;
                txtCurrentCapStatusICU.Text = "GREEN";
            }
            else if (totalICUBeds <= 4)
            {
                txtCurrentCapStatusICU.BackColor = Color.Yellow;
                txtCurrentCapStatusICU.Text = "YELLOW";
            }
            else if (totalICUBeds <= 5)
            {
                txtCurrentCapStatusICU.BackColor = Color.Orange;
                txtCurrentCapStatusICU.Text = "ORANGE";
            }
            else if (totalICUBeds >= 6 && totalICUBeds <= 9)
            {
                txtCurrentCapStatusICU.BackColor = Color.Red;
                txtCurrentCapStatusICU.Text = "RED";
            }
            #endregion

            #region T2 Calculation
            /*****T2****/
            //Determine the T2 Current Capacity Status
            int totalT2Beds = 28;
            totalT2Beds = Convert.ToInt32(txtCurrentCensusT2.Text);
            //txtCurrentCapStatusT2.Text = "";

            if (totalT2Beds <= 14)
            {
                txtCurrentCapStatusT2.BackColor = Color.Green;
                txtCurrentCapStatusT2.Text = "GREEN";
            }
            else if (totalT2Beds <= 17)
            {
                txtCurrentCapStatusT2.BackColor = Color.Yellow;
                txtCurrentCapStatusT2.Text = "YELLOW";
            }
            else if (totalT2Beds <= 20)
            {
                txtCurrentCapStatusT2.BackColor = Color.Orange;
                txtCurrentCapStatusT2.Text = "ORANGE";
            }

            else if (totalT2Beds >= 20 && totalT2Beds <= 28)
            {
                txtCurrentCapStatusT2.BackColor = Color.Red;
                txtCurrentCapStatusT2.Text = "RED";
            }
            #endregion

            #region PEDI Calculation
            /*****PEDI****/
            //Determine the PEDI Current Capacity Status
            int totalPEDIBeds = 28;
            totalPEDIBeds = Convert.ToInt32(txtCurrentCensusPEDI.Text);
            //txtCurrentCapStatusPEDI.Text = "";

            if (totalPEDIBeds <= 14)
            {
                txtCurrentCapStatusPEDI.BackColor = Color.Green;
                txtCurrentCapStatusPEDI.Text = "GREEN";
            }
            else if (totalPEDIBeds <= 17)
            {
                txtCurrentCapStatusPEDI.BackColor = Color.Yellow;
                txtCurrentCapStatusPEDI.Text = "YELLOW";
            }
            else if (totalPEDIBeds <= 20)
            {
                txtCurrentCapStatusPEDI.BackColor = Color.Orange;
                txtCurrentCapStatusPEDI.Text = "ORANGE";
            }

            else if (totalPEDIBeds >= 20 && totalPEDIBeds <= 28)
            {
                txtCurrentCapStatusPEDI.BackColor = Color.Red;
                txtCurrentCapStatusPEDI.Text = "RED";
            }
            #endregion

            #region T4 Calculation
            /*****T4****/
            //Determine the T4 Current Capacity Status
            int totalT4Beds = 29;
            totalT4Beds = Convert.ToInt32(txtCurrentCensusT4.Text);
            //txtCurrentCapStatusT4.Text = "";

            if (totalT4Beds <= 14)
            {
                txtCurrentCapStatusT4.BackColor = Color.Green;
                txtCurrentCapStatusT4.Text = "GREEN";
            }
            else if (totalT4Beds <= 17)
            {
                txtCurrentCapStatusT4.BackColor = Color.Yellow;
                txtCurrentCapStatusT4.Text = "YELLOW";
            }
            else if (totalT4Beds <= 20)
            {
                txtCurrentCapStatusT4.BackColor = Color.Orange;
                txtCurrentCapStatusT4.Text = "ORANGE";
            }

            else if (totalT4Beds >= 20 && totalT4Beds <= 29)
            {
                txtCurrentCapStatusT4.BackColor = Color.Red;
                txtCurrentCapStatusT4.Text = "RED";
            }
            #endregion

            #region 6ACU Calculation

            /*****6ACU****/
            //Determine the 6ACU Current Capacity Status
            int total6ACUBeds = 10;
            total6ACUBeds = Convert.ToInt32(txtCurrentCensus6ACU.Text);

            if (total6ACUBeds <= 3)
            {
                txtCurrentCapStatus6ACU.BackColor = Color.Green;
                txtCurrentCapStatus6ACU.Text = "GREEN";
            }
            else if (total6ACUBeds <= 5)
            {
                txtCurrentCapStatus6ACU.BackColor = Color.Yellow;
                txtCurrentCapStatus6ACU.Text = "YELLOW";
            }
            else if (total6ACUBeds <= 6)
            {
                txtCurrentCapStatus6ACU.BackColor = Color.Orange;
                txtCurrentCapStatus6ACU.Text = "ORANGE";
            }
            else if (total6ACUBeds >= 7 && total6ACUBeds <= 10)
            {
                txtCurrentCapStatus6ACU.BackColor = Color.Red;
                txtCurrentCapStatus6ACU.Text = "RED";
            }

            #endregion

            #region TBC Calculation

            /*****TBC****/
            //Determine the TBC Current Capacity Status
            int totalTBCBeds = 10;
            totalTBCBeds = Convert.ToInt32(txtCurrentCensusTBC.Text);

            if (totalTBCBeds <= 3)
            {
                txtCurrentCapStatusTBC.BackColor = Color.Green;
                txtCurrentCapStatusTBC.Text = "GREEN";
            }
            else if (totalTBCBeds <= 5)
            {
                txtCurrentCapStatusTBC.BackColor = Color.Yellow;
                txtCurrentCapStatusTBC.Text = "YELLOW";
            }
            else if (totalTBCBeds <= 6)
            {
                txtCurrentCapStatusTBC.BackColor = Color.Orange;
                txtCurrentCapStatusTBC.Text = "ORANGE";
            }
            else if (totalTBCBeds >= 7 && totalTBCBeds <= 10)
            {
                txtCurrentCapStatusTBC.BackColor = Color.Red;
                txtCurrentCapStatusTBC.Text = "RED";
            }
            #endregion

            #region BHU Calculation

            /*****BHU****/
            //Determine the BHU Current Capacity Status
            int totalBHUBeds = 15;
            totalBHUBeds = Convert.ToInt32(txtCurrentCensusBHU.Text);

            if (totalBHUBeds <= 8)
            {
                txtCurrentCapStatusBHU.BackColor = Color.Green;
                txtCurrentCapStatusBHU.Text = "GREEN";
            }
            else if (totalBHUBeds <= 10)
            {
                txtCurrentCapStatusBHU.BackColor = Color.Yellow;
                txtCurrentCapStatusBHU.Text = "YELLOW";
            }
            else if (totalBHUBeds <= 11)
            {
                txtCurrentCapStatusBHU.BackColor = Color.Orange;
                txtCurrentCapStatusBHU.Text = "ORANGE";
            }
            else if (totalBHUBeds >= 12 && totalBHUBeds <= 15)
            {
                txtCurrentCapStatusBHU.BackColor = Color.Red;
                txtCurrentCapStatusBHU.Text = "RED";
            }
            #endregion

            return true;
        }
    }
}
