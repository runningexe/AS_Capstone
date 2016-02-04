using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DailyCensusReport
{
    public partial class ViewRecordsForm : Form
    {
        public ViewRecordsForm()
        {
            InitializeComponent();
        }


        private void ViewRecordsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet1.Census' table. You can move, or remove it, as needed.
            this.censusTableAdapter1.Fill(this.sE265_AJF1130DataSet1.Census);

        }

        private void DPRecordDate_ValueChanged(object sender, EventArgs e)
        {
            DPRecordDate.CustomFormat = "yyyy-MM-dd";
            ViewRecord getRecord = new ViewRecord();
            getRecord.RecordDate = DPRecordDate.Value;
            DateTime date = default(DateTime);
            ViewRecord.ViewRecordID(date);
           

        }

        private void get_DateToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.censusTableAdapter1.Get_Date(this.sE265_AJF1130DataSet1.Census, DPRecordDate.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        //DateTime Picker

    }
}
