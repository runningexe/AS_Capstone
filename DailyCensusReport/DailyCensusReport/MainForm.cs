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
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMainAddRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDailyCensusReport openFromMain = new frmDailyCensusReport();
            openFromMain.Show();                
        }

        private void btnMainViewRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewRecordsForm openVR = new ViewRecordsForm();
            openVR.Show(); 
        }
    }

}
