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
            this.iCUDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPRecordDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.sE265_AJF1130DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCUDataGridView)).BeginInit();
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
            // iCUDataGridView
            // 
            this.iCUDataGridView.AutoGenerateColumns = false;
            this.iCUDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iCUDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.iCUDataGridView.DataSource = this.iCUBindingSource;
            this.iCUDataGridView.Location = new System.Drawing.Point(36, 53);
            this.iCUDataGridView.Name = "iCUDataGridView";
            this.iCUDataGridView.Size = new System.Drawing.Size(844, 280);
            this.iCUDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "icuID";
            this.dataGridViewTextBoxColumn1.HeaderText = "icuID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "unitID";
            this.dataGridViewTextBoxColumn2.HeaderText = "unitID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "currentCensus";
            this.dataGridViewTextBoxColumn3.HeaderText = "currentCensus";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "availBeds";
            this.dataGridViewTextBoxColumn4.HeaderText = "availBeds";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "numberISP";
            this.dataGridViewTextBoxColumn5.HeaderText = "numberISP";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DC";
            this.dataGridViewTextBoxColumn6.HeaderText = "DC";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "notes";
            this.dataGridViewTextBoxColumn7.HeaderText = "notes";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "currentCap";
            this.dataGridViewTextBoxColumn8.HeaderText = "currentCap";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // DPRecordDate
            // 
            this.DPRecordDate.Location = new System.Drawing.Point(269, 12);
            this.DPRecordDate.Name = "DPRecordDate";
            this.DPRecordDate.Size = new System.Drawing.Size(200, 20);
            this.DPRecordDate.TabIndex = 2;
            this.DPRecordDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ViewRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 345);
            this.Controls.Add(this.DPRecordDate);
            this.Controls.Add(this.iCUDataGridView);
            this.Name = "ViewRecordsForm";
            this.Text = "ViewRecordsForm";
            this.Load += new System.EventHandler(this.ViewRecordsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sE265_AJF1130DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCUDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SE265_AJF1130DataSet sE265_AJF1130DataSet;
        private System.Windows.Forms.BindingSource iCUBindingSource;
        private SE265_AJF1130DataSetTableAdapters.ICUTableAdapter iCUTableAdapter;
        private SE265_AJF1130DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView iCUDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DateTimePicker DPRecordDate;
    }
}