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

            int ICUCC1 = Convert.ToInt32(txtCurrentCensusICU.Text);
            int ICUAB2 = Convert.ToInt32(txtAvailableBedsICU.Text);
            txtCurrentCapStatusICU.Text = "";

        ////T2
        //    int T2CC1 = Convert.ToInt32(txtCurrentCensusT2.Text);
        //    int T2AB2 = Convert.ToInt32(txtAvailableBedsT2.Text);
        //    txtCurrentCapStatusT2.Text = "";

            int totalICUBeds = 9;
            int totalCensusColor = (ICUCC1 / ICUAB2) * 125;
        //ICU
            if (totalCensusColor <= 50)
            {
                txtCurrentCapStatusICU.BackColor = Color.Green;
                txtCurrentCapStatusICU.Text = "GREEN";
            }

            else if (totalCensusColor >= 90)
                {
                    txtCurrentCapStatusICU.BackColor = Color.Yellow;
                    txtCurrentCapStatusICU.Text = "YELLOW";
                }
            else if (totalCensusColor >= 120)
            {
                txtCurrentCapStatusICU.BackColor = Color.Orange;
                txtCurrentCapStatusICU.Text = "ORANGE";
            }

            else if (totalCensusColor >= 121)
            {
                txtCurrentCapStatusICU.BackColor = Color.Red;
                txtCurrentCapStatusICU.Text = "RED";
            }

        ////T2
        //    if (T2CC1 <= 5)
        //    {
        //        txtCurrentCapStatusT2.BackColor = Color.Green;
        //        txtCurrentCapStatusT2.Text = "GREEN";
        //    }

        //    else if (T2CC1 >= 6)
        //    {
        //        txtCurrentCapStatusT2.BackColor = Color.Red;
        //        txtCurrentCapStatusT2.Text = "RED";
        //    }
            return true;
        } 
    }
}
