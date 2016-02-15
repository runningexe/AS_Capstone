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
        public static bool CalcColor(
/**ICU**/
            TextBox txtCurrentCensusICU, TextBox txtAvailableBedsICU, TextBox txtIsoPatientsICU, TextBox txtDischargesICU, TextBox txtNotesICU, TextBox txtCurrentCapStatusICU,
/**T2**/
            TextBox txtCurrentCensusT2, TextBox txtAvailableBedsT2, TextBox txtIsoPatientsT2, TextBox txtDischargesT2, TextBox txtNotesT2, TextBox txtCurrentCapStatusT2)
        {

        //ICU
            int totalICUBeds = 9;
            totalICUBeds = Convert.ToInt32(txtCurrentCensusICU.Text);
            txtCurrentCapStatusICU.Text = "";
        
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

            else if (totalICUBeds >= 6 && totalICUBeds <=9)
                {
                txtCurrentCapStatusICU.BackColor = Color.Red;
                txtCurrentCapStatusICU.Text = "RED";
                 }

           
     //T2
            int totalT2Beds = 28;
            totalT2Beds = Convert.ToInt32(txtCurrentCensusT2.Text);
            txtCurrentCapStatusT2.Text = "";
    //T2
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
            return true;
        } 
    }
}
