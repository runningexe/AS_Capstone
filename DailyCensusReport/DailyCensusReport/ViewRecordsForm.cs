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
        frmDailyCensusReport fofo = new frmDailyCensusReport();

        public ViewRecordsForm()
        {
            InitializeComponent();
        }

        private void ViewRecordsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet.HospitalDepartments' table. You can move, or remove it, as needed.
            this.hospitalDepartmentsTableAdapter.Fill(this.sE265_AJF1130DataSet.HospitalDepartments);
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet2.vw_GetRecords' table. You can move, or remove it, as needed.
            this.vw_GetRecordsTableAdapter.Fill(this.sE265_AJF1130DataSet2.vw_GetRecords);
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet1.HospitalCensus' table. You can move, or remove it, as needed.
            this.hospitalCensusTableAdapter.Fill(this.sE265_AJF1130DataSet1.HospitalCensus);
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet1.HospitalCensus' table. You can move, or remove it, as needed.
        }

        private void hospitalCensusDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{

            //    gets a collection that contains all the rows
            //    DataGridViewRow row = this.vw_GetRecordsDataGridView.Rows[e.RowIndex];
            //    populate the textbox from specific value of the coordinates of column and row.
            //    for (int i = 0; i < 7; i++)
            //    {
            //        fofo.boxesICU[i].Text = row.Cells[0].Value.ToString();
            //    }


            //}
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

        private void cboUnitNameSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connect = DBConnect.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM HospitalDepartments JOIN HospitalCensus ON HospitalDepartments.unitID = HospitalCensus.unitID WHERE unitName LIKE '" + cboUnitNameSearch.SelectedValue + "'";
            cmd.Connection = connect;

            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataSet);

            vw_GetRecordsDataGridView.DataSource = dataSet.Tables[0];
        }

        private void LoadGridData(DateTime updateDate)
        {
            SqlConnection connect = DBConnect.GetConnection();
            String query = "SELECT * FROM HospitalCensus WHERE updateDate LIKE '" + dtpSearchDate.Value + "'";
            SqlCommand command = new SqlCommand(query, connect);
            command.Parameters.AddWithValue("@updateDate", dtpSearchDate.Value);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);
            vw_GetRecordsBindingSource.DataSource = ds.Tables[0];
        }

        private void dtpSearchDate_ValueChanged(object sender, EventArgs e)
        {
            LoadGridData(dtpSearchDate.Value);
        }
    }
}
