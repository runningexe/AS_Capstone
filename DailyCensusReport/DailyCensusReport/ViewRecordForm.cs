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
    public partial class ViewRecordForm : Form
    {
        public ViewRecordForm()
        {
            InitializeComponent();
        }

        private void ViewRecordForm_Load(object sender, EventArgs e)
        {
            
            textBox1.Text = "12/01/2030";
            textBox1.Visible = false;
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            DateTime date1 = Convert.ToDateTime(txtSearchDate.Text);
            DateTime date2 = Convert.ToDateTime(textBox1.Text);

            this.HospitalDepartmentsTableAdapter.Fill(this.SE265_AJF1130DataSet2.HospitalDepartments, date1, date2);

            this.reportViewer1.RefreshReport();
        }
    }
}
