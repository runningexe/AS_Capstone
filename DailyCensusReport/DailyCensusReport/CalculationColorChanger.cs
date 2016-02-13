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
            int T2CC1 = Convert.ToInt32(txtCurrentCensusT2.Text);
            int T2AB2 = Convert.ToInt32(txtAvailableBedsT2.Text);
            txtCurrentCapStatusT2.Text = "";
    //T2
            if (T2CC1 <= 5)
            {
                txtCurrentCapStatusT2.BackColor = Color.Green;
                txtCurrentCapStatusT2.Text = "GREEN";
            }

            else if (T2CC1 >= 6)
            {
                txtCurrentCapStatusT2.BackColor = Color.Red;
                txtCurrentCapStatusT2.Text = "RED";
            }
            return true;
        } 
    }
}
