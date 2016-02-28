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
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet1.HospitalCensus' table. You can move, or remove it, as needed.
            this.hospitalCensusTableAdapter.Fill(this.sE265_AJF1130DataSet1.HospitalCensus);
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet1.HospitalCensus' table. You can move, or remove it, as needed.
        }

        private void hospitalCensusDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void hospitalCensusBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hospitalCensusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sE265_AJF1130DataSet1);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.spGetHospitalCensusTableAdapter.Fill(this.sE265_AJF1130DataSet1.spGetHospitalCensus, new System.Nullable<int>(((int)(System.Convert.ChangeType(unitIDToolStripTextBox.Text, typeof(int))))), currentCensusToolStripTextBox.Text, availBedsToolStripTextBox.Text, numberISPToolStripTextBox.Text, dCToolStripTextBox.Text, notesToolStripTextBox.Text, currentCapToolStripTextBox.Text, updateDateToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    }
}
