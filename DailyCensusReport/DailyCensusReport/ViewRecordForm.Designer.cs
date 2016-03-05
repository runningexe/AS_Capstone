namespace DailyCensusReport
{
    partial class ViewRecordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.lblSearchDate = new System.Windows.Forms.Label();
            this.txtSetDate = new System.Windows.Forms.TextBox();
            this.txtSearchDate = new System.Windows.Forms.TextBox();
            this.rvViewRecords = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HospitalDepartmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SE265_AJF1130DataSet2 = new DailyCensusReport.SE265_AJF1130DataSet2();
            this.HospitalDepartmentsTableAdapter = new DailyCensusReport.SE265_AJF1130DataSet2TableAdapters.HospitalDepartmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDepartmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE265_AJF1130DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Location = new System.Drawing.Point(514, 12);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(162, 21);
            this.btnSearchDate.TabIndex = 0;
            this.btnSearchDate.Text = "Search";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // lblSearchDate
            // 
            this.lblSearchDate.AutoSize = true;
            this.lblSearchDate.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDate.Location = new System.Drawing.Point(230, 9);
            this.lblSearchDate.Name = "lblSearchDate";
            this.lblSearchDate.Size = new System.Drawing.Size(122, 24);
            this.lblSearchDate.TabIndex = 1;
            this.lblSearchDate.Text = "Search By Date:";
            // 
            // txtSetDate
            // 
            this.txtSetDate.Location = new System.Drawing.Point(358, 12);
            this.txtSetDate.Name = "txtSetDate";
            this.txtSetDate.Size = new System.Drawing.Size(150, 20);
            this.txtSetDate.TabIndex = 2;
            // 
            // txtSearchDate
            // 
            this.txtSearchDate.Location = new System.Drawing.Point(358, 12);
            this.txtSearchDate.Name = "txtSearchDate";
            this.txtSearchDate.Size = new System.Drawing.Size(150, 20);
            this.txtSearchDate.TabIndex = 3;
            // 
            // rvViewRecords
            // 
            reportDataSource2.Name = "DateSearchViewer";
            reportDataSource2.Value = this.HospitalDepartmentsBindingSource;
            this.rvViewRecords.LocalReport.DataSources.Add(reportDataSource2);
            this.rvViewRecords.LocalReport.ReportEmbeddedResource = "DailyCensusReport.Report2.rdlc";
            this.rvViewRecords.Location = new System.Drawing.Point(12, 90);
            this.rvViewRecords.Name = "reportViewer1";
            this.rvViewRecords.Size = new System.Drawing.Size(1017, 338);
            this.rvViewRecords.TabIndex = 4;
            // 
            // HospitalDepartmentsBindingSource
            // 
            this.HospitalDepartmentsBindingSource.DataMember = "HospitalDepartments";
            this.HospitalDepartmentsBindingSource.DataSource = this.SE265_AJF1130DataSet2;
            // 
            // SE265_AJF1130DataSet2
            // 
            this.SE265_AJF1130DataSet2.DataSetName = "SE265_AJF1130DataSet2";
            this.SE265_AJF1130DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HospitalDepartmentsTableAdapter
            // 
            this.HospitalDepartmentsTableAdapter.ClearBeforeFill = true;
            // 
            // ViewRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 448);
            this.Controls.Add(this.rvViewRecords);
            this.Controls.Add(this.txtSearchDate);
            this.Controls.Add(this.txtSetDate);
            this.Controls.Add(this.lblSearchDate);
            this.Controls.Add(this.btnSearchDate);
            this.Name = "ViewRecordForm";
            this.Text = "ViewRecordForm";
            this.Load += new System.EventHandler(this.ViewRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDepartmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE265_AJF1130DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Label lblSearchDate;
        private System.Windows.Forms.TextBox txtSetDate;
        private System.Windows.Forms.TextBox txtSearchDate;
        private System.Windows.Forms.BindingSource HospitalDepartmentsBindingSource;
        private SE265_AJF1130DataSet2 SE265_AJF1130DataSet2;
        private SE265_AJF1130DataSet2TableAdapters.HospitalDepartmentsTableAdapter HospitalDepartmentsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rvViewRecords;
    }
}