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
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet2.vw_GetRecords' table. You can move, or remove it, as needed.
            this.vw_GetRecordsTableAdapter.Fill(this.sE265_AJF1130DataSet2.vw_GetRecords);
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet1.HospitalCensus' table. You can move, or remove it, as needed.
            this.hospitalCensusTableAdapter.Fill(this.sE265_AJF1130DataSet1.HospitalCensus);
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet1.HospitalCensus' table. You can move, or remove it, as needed.
        }

        private void hospitalCensusDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.spGetRecordsTableAdapter.Fill(this.sE265_AJF1130DataSet.spGetRecords);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void searchRecordsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.hospitalCensusTableAdapter.SearchRecords(this.sE265_AJF1130DataSet1.HospitalCensus);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.spGetRecordsTableAdapter.FillBy(this.sE265_AJF1130DataSet.spGetRecords);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.spGetRecordsTableAdapter.Fill(this.sE265_AJF1130DataSet.spGetRecords);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.spGetRecordsTableAdapter.FillBy(this.sE265_AJF1130DataSet.spGetRecords);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.spGetRecordsTableAdapter.Fill(this.sE265_AJF1130DataSet.spGetRecords);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    }
}
