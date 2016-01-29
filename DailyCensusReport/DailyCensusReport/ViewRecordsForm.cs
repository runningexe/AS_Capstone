using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyCensusReport
{
    public partial class ViewRecordsForm : Form
    {
        public ViewRecordsForm()
        {
            InitializeComponent();
        }

        private void iCUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iCUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sE265_AJF1130DataSet);

        }

        private void ViewRecordsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet.Census' table. You can move, or remove it, as needed.
            this.censusTableAdapter.Fill(this.sE265_AJF1130DataSet.Census);
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet.Census' table. You can move, or remove it, as needed.
            this.censusTableAdapter.Fill(this.sE265_AJF1130DataSet.Census);
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet.PEDI' table. You can move, or remove it, as needed.
            this.pEDITableAdapter.Fill(this.sE265_AJF1130DataSet.PEDI);
            // TODO: This line of code loads data into the 'sE265_AJF1130DataSet.ICU' table. You can move, or remove it, as needed.
            this.iCUTableAdapter.Fill(this.sE265_AJF1130DataSet.ICU);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.spCensusTableAdapter.Fill(this.sE265_AJF1130DataSet.spCensus, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void censusBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.censusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sE265_AJF1130DataSet);

        }
    }
}
