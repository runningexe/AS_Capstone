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
            iCUDataGridView.Show();
            t2DataGridView.Hide();
            pEDIDataGridView.Hide();
            t4DataGridView.Hide();
            _6ACUDataGridView.Hide();
            tBCDataGridView.Hide();
            bHUDataGridView.Hide();

            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet.BHU' table. You can move, or remove it, as needed.
            this.bHUTableAdapter.Fill(this.sE265_AJF1130DataSet.BHU);
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet.TBC' table. You can move, or remove it, as needed.
            this.tBCTableAdapter.Fill(this.sE265_AJF1130DataSet.TBC);
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet._6ACU' table. You can move, or remove it, as needed.
            this._6ACUTableAdapter.Fill(this.sE265_AJF1130DataSet._6ACU);
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet.T4' table. You can move, or remove it, as needed.
            this.t4TableAdapter.Fill(this.sE265_AJF1130DataSet.T4);
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet.PEDI' table. You can move, or remove it, as needed.
            this.pEDITableAdapter.Fill(this.sE265_AJF1130DataSet.PEDI);
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet.T2' table. You can move, or remove it, as needed.
            this.t2TableAdapter.Fill(this.sE265_AJF1130DataSet.T2);
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet.ICU' table. You can move, or remove it, as needed.
            this.iCUTableAdapter.Fill(this.sE265_AJF1130DataSet.ICU);
        }

        private void btnICU_Click(object sender, EventArgs e)
        {
            iCUDataGridView.Show();
            t2DataGridView.Hide();
            pEDIDataGridView.Hide();
            t4DataGridView.Hide();
            _6ACUDataGridView.Hide();
            tBCDataGridView.Hide();
            bHUDataGridView.Hide();
        }

        private void btnT2_Click(object sender, EventArgs e)
        {
            iCUDataGridView.Hide();
            t2DataGridView.Show();
            pEDIDataGridView.Hide();
            t4DataGridView.Hide();
            _6ACUDataGridView.Hide();
            tBCDataGridView.Hide();
            bHUDataGridView.Hide();
        }

        private void btnPEDI_Click(object sender, EventArgs e)
        {

        }

        private void btnT4_Click(object sender, EventArgs e)
        {

        }

        private void btn6ACU_Click(object sender, EventArgs e)
        {

        }

        private void btnTBC_Click(object sender, EventArgs e)
        {

        }

        private void btnBHU_Click(object sender, EventArgs e)
        {

        }
    }
}
