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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSearchDate = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SE265_AJF1130DataSet2 = new DailyCensusReport.SE265_AJF1130DataSet2();
            this.HospitalDepartmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalDepartmentsTableAdapter = new DailyCensusReport.SE265_AJF1130DataSet2TableAdapters.HospitalDepartmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SE265_AJF1130DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDepartmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Location = new System.Drawing.Point(448, 50);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDate.TabIndex = 0;
            this.btnSearchDate.Text = "Search";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By Date:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(439, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // txtSearchDate
            // 
            this.txtSearchDate.Location = new System.Drawing.Point(439, 24);
            this.txtSearchDate.Name = "txtSearchDate";
            this.txtSearchDate.Size = new System.Drawing.Size(100, 20);
            this.txtSearchDate.TabIndex = 3;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DateSearchViewer";
            reportDataSource1.Value = this.HospitalDepartmentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DailyCensusReport.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 96);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1017, 338);
            this.reportViewer1.TabIndex = 4;
            // 
            // SE265_AJF1130DataSet2
            // 
            this.SE265_AJF1130DataSet2.DataSetName = "SE265_AJF1130DataSet2";
            this.SE265_AJF1130DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HospitalDepartmentsBindingSource
            // 
            this.HospitalDepartmentsBindingSource.DataMember = "HospitalDepartments";
            this.HospitalDepartmentsBindingSource.DataSource = this.SE265_AJF1130DataSet2;
            // 
            // HospitalDepartmentsTableAdapter
            // 
            this.HospitalDepartmentsTableAdapter.ClearBeforeFill = true;
            // 
            // ViewRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 436);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.txtSearchDate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchDate);
            this.Name = "ViewRecordForm";
            this.Text = "ViewRecordForm";
            this.Load += new System.EventHandler(this.ViewRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SE265_AJF1130DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDepartmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSearchDate;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HospitalDepartmentsBindingSource;
        private SE265_AJF1130DataSet2 SE265_AJF1130DataSet2;
        private SE265_AJF1130DataSet2TableAdapters.HospitalDepartmentsTableAdapter HospitalDepartmentsTableAdapter;
    }
}