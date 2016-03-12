using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

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
            //Puts items into an array to pushes out to the combo box 
            string[] unitNames = {"Select A Unit Name...",
                "ICU", "T2", "PEDI", "T4",
                "6ACU", "TBC"};

            foreach (string unitName in unitNames)
            {
                cbUnitName.Items.Add(unitName);
            }
            cbUnitName.SelectedIndex = 0;

            //Needed to Hard code a set date
            txtSetDate.Text = "01/01/9999";
            txtSetDate.Visible = false;
            txtSearchDate.Text = Convert.ToDateTime(DateTime.Today).ToShortDateString();
            txtSearchDate.Select();
        }

        //Search by Date
        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            //Converts String to DateTime, so Report will show the data



            //DateTime Test;
            //if (DateTime.TryParseExact(txtSearchDate.Text, "M/dd/yyyy", null, DateTimeStyles.None, out Test) == true)
            //{

            //}
            //else
            //    MessageBox.Show("Date Not OK");
            
                try
                {
                    DateTime date1 = Convert.ToDateTime(txtSearchDate.Text);
                    DateTime date2 = Convert.ToDateTime(txtSetDate.Text);

                    //Populates information from the database into the Report Viewer
                    this.HospitalDepartmentsTableAdapter.FillBy(this.SE265_AJF1130DataSet2.HospitalDepartments, date1, date2);
                }
                catch
                {
                    MessageBox.Show("Incorrect date format \n\n" + "Please try using date formats such as: \n" + "'MM/dd/yyyy' \n" + "'M/d/yyyy' \n" + "'M/dd/yy' \n" + "'MM/d/yyyy' \n" + "'MM/d/yy' \n", "Error");
                    txtSearchDate.Text = "";
                }
            try
            {

                if (SE265_AJF1130DataSet2.HospitalDepartments.Rows.Count == 0)
                {
                    DialogResult result = MessageBox.Show("No Records Found For That Date", "NO RECORDS FOUND", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        DialogResult = DialogResult.None;
                        this.HospitalDepartmentsTableAdapter.ViewAllRecords(this.SE265_AJF1130DataSet2.HospitalDepartments);
                    }
                }

                this.rvViewRecords.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Search by Unit Name

        private void cbUnitName_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                this.HospitalDepartmentsTableAdapter.SearchByUnitName(this.SE265_AJF1130DataSet2.HospitalDepartments, cbUnitName.SelectedItem.ToString());

                this.rvViewRecords.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //view all records
        private void btnViewAllRecords_Click(object sender, EventArgs e)
        {
            try
            {
                this.HospitalDepartmentsTableAdapter.ViewAllRecords(this.SE265_AJF1130DataSet2.HospitalDepartments);

                this.rvViewRecords.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
