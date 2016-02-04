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
            System.Windows.Forms.Label theDateLabel;
            this.sE265_AJF1130DataSet = new DailyCensusReport.SE265_AJF1130DataSet();
            this.censusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.censusTableAdapter = new DailyCensusReport.SE265_AJF1130DataSetTableAdapters.CensusTableAdapter();
            this.tableAdapterManager = new DailyCensusReport.SE265_AJF1130DataSetTableAdapters.TableAdapterManager();
            this.sE265_AJF1130DataSet1 = new DailyCensusReport.SE265_AJF1130DataSet1();
            this.censusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.censusTableAdapter1 = new DailyCensusReport.SE265_AJF1130DataSet1TableAdapters.CensusTableAdapter();
            this.tableAdapterManager1 = new DailyCensusReport.SE265_AJF1130DataSet1TableAdapters.TableAdapterManager();
            this.censusDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPRecordDate = new System.Windows.Forms.DateTimePicker();
            this.get_DateToolStrip = new System.Windows.Forms.ToolStrip();
            this.theDateToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.theDateToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.get_DateToolStripButton = new System.Windows.Forms.ToolStripButton();
            theDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sE265_AJF1130DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.censusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sE265_AJF1130DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.censusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.censusDataGridView)).BeginInit();
            this.get_DateToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // theDateLabel
            // 
            theDateLabel.AutoSize = true;
            theDateLabel.Location = new System.Drawing.Point(187, 68);
            theDateLabel.Name = "theDateLabel";
            theDateLabel.Size = new System.Drawing.Size(51, 13);
            theDateLabel.TabIndex = 1;
            theDateLabel.Text = "the Date:";
            // 
            // sE265_AJF1130DataSet
            // 
            this.sE265_AJF1130DataSet.DataSetName = "SE265_AJF1130DataSet";
            this.sE265_AJF1130DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // censusBindingSource
            // 
            this.censusBindingSource.DataMember = "Census";
            this.censusBindingSource.DataSource = this.sE265_AJF1130DataSet;
            // 
            // censusTableAdapter
            // 
            this.censusTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._6ACUTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BHUTableAdapter = null;
            this.tableAdapterManager.CensusTableAdapter = this.censusTableAdapter;
            this.tableAdapterManager.ICUTableAdapter = null;
            this.tableAdapterManager.PEDITableAdapter = null;
            this.tableAdapterManager.T2TableAdapter = null;
            this.tableAdapterManager.T4TableAdapter = null;
            this.tableAdapterManager.TBCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DailyCensusReport.SE265_AJF1130DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sE265_AJF1130DataSet1
            // 
            this.sE265_AJF1130DataSet1.DataSetName = "SE265_AJF1130DataSet1";
            this.sE265_AJF1130DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // censusBindingSource1
            // 
            this.censusBindingSource1.DataMember = "Census";
            this.censusBindingSource1.DataSource = this.sE265_AJF1130DataSet1;
            // 
            // censusTableAdapter1
            // 
            this.censusTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1._6ACUTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BHUTableAdapter = null;
            this.tableAdapterManager1.CensusRecordsTableAdapter = null;
            this.tableAdapterManager1.CensusTableAdapter = this.censusTableAdapter1;
            this.tableAdapterManager1.ICUTableAdapter = null;
            this.tableAdapterManager1.PEDITableAdapter = null;
            this.tableAdapterManager1.T2TableAdapter = null;
            this.tableAdapterManager1.T4TableAdapter = null;
            this.tableAdapterManager1.TBCTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = DailyCensusReport.SE265_AJF1130DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // censusDataGridView
            // 
            this.censusDataGridView.AutoGenerateColumns = false;
            this.censusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.censusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.censusDataGridView.DataSource = this.censusBindingSource1;
            this.censusDataGridView.Location = new System.Drawing.Point(147, 123);
            this.censusDataGridView.Name = "censusDataGridView";
            this.censusDataGridView.Size = new System.Drawing.Size(383, 220);
            this.censusDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "unitID";
            this.dataGridViewTextBoxColumn1.HeaderText = "unitID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "theDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "theDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "censusID";
            this.dataGridViewTextBoxColumn3.HeaderText = "censusID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // DPRecordDate
            // 
            this.DPRecordDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.censusBindingSource1, "theDate", true));
            this.DPRecordDate.Location = new System.Drawing.Point(244, 64);
            this.DPRecordDate.Name = "DPRecordDate";
            this.DPRecordDate.Size = new System.Drawing.Size(200, 20);
            this.DPRecordDate.TabIndex = 2;
            // 
            // get_DateToolStrip
            // 
            this.get_DateToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theDateToolStripLabel,
            this.theDateToolStripTextBox,
            this.get_DateToolStripButton});
            this.get_DateToolStrip.Location = new System.Drawing.Point(0, 0);
            this.get_DateToolStrip.Name = "get_DateToolStrip";
            this.get_DateToolStrip.Size = new System.Drawing.Size(928, 25);
            this.get_DateToolStrip.TabIndex = 3;
            this.get_DateToolStrip.Text = "get_DateToolStrip";
            // 
            // theDateToolStripLabel
            // 
            this.theDateToolStripLabel.Name = "theDateToolStripLabel";
            this.theDateToolStripLabel.Size = new System.Drawing.Size(51, 22);
            this.theDateToolStripLabel.Text = "theDate:";
            // 
            // theDateToolStripTextBox
            // 
            this.theDateToolStripTextBox.Name = "theDateToolStripTextBox";
            this.theDateToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // get_DateToolStripButton
            // 
            this.get_DateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.get_DateToolStripButton.Name = "get_DateToolStripButton";
            this.get_DateToolStripButton.Size = new System.Drawing.Size(58, 19);
            this.get_DateToolStripButton.Text = "Get_Date";
            this.get_DateToolStripButton.Click += new System.EventHandler(this.get_DateToolStripButton_Click);
            // 
            // ViewRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 483);
            this.Controls.Add(this.get_DateToolStrip);
            this.Controls.Add(theDateLabel);
            this.Controls.Add(this.DPRecordDate);
            this.Controls.Add(this.censusDataGridView);
            this.Name = "ViewRecordsForm";
            this.Text = "ViewRecordsForm";
            this.Load += new System.EventHandler(this.ViewRecordsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sE265_AJF1130DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.censusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sE265_AJF1130DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.censusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.censusDataGridView)).EndInit();
            this.get_DateToolStrip.ResumeLayout(false);
            this.get_DateToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SE265_AJF1130DataSet sE265_AJF1130DataSet;
        private System.Windows.Forms.BindingSource censusBindingSource;
        private SE265_AJF1130DataSetTableAdapters.CensusTableAdapter censusTableAdapter;
        private SE265_AJF1130DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private SE265_AJF1130DataSet1 sE265_AJF1130DataSet1;
        private System.Windows.Forms.BindingSource censusBindingSource1;
        private SE265_AJF1130DataSet1TableAdapters.CensusTableAdapter censusTableAdapter1;
        private SE265_AJF1130DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView censusDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DateTimePicker DPRecordDate;
        private System.Windows.Forms.ToolStrip get_DateToolStrip;
        private System.Windows.Forms.ToolStripLabel theDateToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox theDateToolStripTextBox;
        private System.Windows.Forms.ToolStripButton get_DateToolStripButton;
    }
}