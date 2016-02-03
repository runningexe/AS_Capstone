namespace DailyCensusReport
{
    partial class ViewRecordsForm
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
            this.sE265_AJF1130DataSet = new DailyCensusReport.SE265_AJF1130DataSet();
            this.iCUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iCUTableAdapter = new DailyCensusReport.SE265_AJF1130DataSetTableAdapters.ICUTableAdapter();
            this.tableAdapterManager = new DailyCensusReport.SE265_AJF1130DataSetTableAdapters.TableAdapterManager();
            this.DPRecordDate = new System.Windows.Forms.DateTimePicker();
            this.RecordView = new System.Windows.Forms.DataGridView();
            this.lblTest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sE265_AJF1130DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordView)).BeginInit();
            this.SuspendLayout();
            // 
            // sE265_AJF1130DataSet
            // 
            this.sE265_AJF1130DataSet.DataSetName = "SE265_AJF1130DataSet";
            this.sE265_AJF1130DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iCUBindingSource
            // 
            this.iCUBindingSource.DataMember = "ICU";
            this.iCUBindingSource.DataSource = this.sE265_AJF1130DataSet;
            // 
            // iCUTableAdapter
            // 
            this.iCUTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._6ACUTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BHUTableAdapter = null;
            this.tableAdapterManager.CensusTableAdapter = null;
            this.tableAdapterManager.ICUTableAdapter = this.iCUTableAdapter;
            this.tableAdapterManager.PEDITableAdapter = null;
            this.tableAdapterManager.T2TableAdapter = null;
            this.tableAdapterManager.T4TableAdapter = null;
            this.tableAdapterManager.TBCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DailyCensusReport.SE265_AJF1130DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DPRecordDate
            // 
            this.DPRecordDate.Location = new System.Drawing.Point(269, 12);
            this.DPRecordDate.Name = "DPRecordDate";
            this.DPRecordDate.Size = new System.Drawing.Size(200, 20);
            this.DPRecordDate.TabIndex = 2;
            // 
            // RecordView
            // 
            this.RecordView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordView.Location = new System.Drawing.Point(45, 69);
            this.RecordView.Name = "RecordView";
            this.RecordView.Size = new System.Drawing.Size(770, 236);
            this.RecordView.TabIndex = 3;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(107, 18);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(35, 13);
            this.lblTest.TabIndex = 4;
            this.lblTest.Text = "label1";
            // 
            // ViewRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 345);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.RecordView);
            this.Controls.Add(this.DPRecordDate);
            this.Name = "ViewRecordsForm";
            this.Text = "ViewRecordsForm";
            this.Load += new System.EventHandler(this.ViewRecordsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sE265_AJF1130DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SE265_AJF1130DataSet sE265_AJF1130DataSet;
        private System.Windows.Forms.BindingSource iCUBindingSource;
        private SE265_AJF1130DataSetTableAdapters.ICUTableAdapter iCUTableAdapter;
        private SE265_AJF1130DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker DPRecordDate;
        private System.Windows.Forms.DataGridView RecordView;
        private System.Windows.Forms.Label lblTest;
    }
}