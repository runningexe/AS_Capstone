﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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
            //Needed to Hard code a set date
            txtSetDate.Text = "1/01/9999";
            txtSetDate.Visible = false;
            txtSearchDate.Text = Convert.ToDateTime(DateTime.Today).ToShortDateString();
            txtSearchDate.Select();
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            //Converts String to DateTime, so Report will show the data
            DateTime date1 = Convert.ToDateTime(txtSearchDate.Text);
            DateTime date2 = Convert.ToDateTime(txtSetDate.Text);

            //Populates information from the database into the Report Viewer
            this.HospitalDepartmentsTableAdapter.Fill(this.SE265_AJF1130DataSet2.HospitalDepartments, date1, date2);
            this.rvViewRecords.RefreshReport();
            
        }
    }
}