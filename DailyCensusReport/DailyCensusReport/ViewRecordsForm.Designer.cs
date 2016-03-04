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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRecordsForm));
            this.hospitalCensusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sE265_AJF1130DataSet1 = new DailyCensusReport.SE265_AJF1130DataSet1();
            this.hospitalCensusTableAdapter = new DailyCensusReport.SE265_AJF1130DataSet1TableAdapters.HospitalCensusTableAdapter();
            this.tableAdapterManager = new DailyCensusReport.SE265_AJF1130DataSet1TableAdapters.TableAdapterManager();
            this.spGetHospitalCensusTableAdapter = new DailyCensusReport.SE265_AJF1130DataSet1TableAdapters.spGetHospitalCensusTableAdapter();
            this.sE265_AJF1130DataSet = new DailyCensusReport.SE265_AJF1130DataSet();
            this.spGetRecordsTableAdapter = new DailyCensusReport.SE265_AJF1130DataSetTableAdapters.spGetRecordsTableAdapter();
            this.tableAdapterManager1 = new DailyCensusReport.SE265_AJF1130DataSetTableAdapters.TableAdapterManager();
            this.spGetRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetRecordsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sE265_AJF1130DataSet2 = new DailyCensusReport.SE265_AJF1130DataSet2();
            this.vw_GetRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_GetRecordsTableAdapter = new DailyCensusReport.SE265_AJF1130DataSet2TableAdapters.vw_GetRecordsTableAdapter();
            this.tableAdapterManager2 = new DailyCensusReport.SE265_AJF1130DataSet2TableAdapters.TableAdapterManager();
            this.vw_GetRecordsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearchByUnitName = new System.Windows.Forms.Label();
            this.cboUnitNameSearch = new System.Windows.Forms.ComboBox();
            this.hospitalDepartmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sE265AJF1130DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDepartmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDepartmentsTableAdapter = new DailyCensusReport.SE265_AJF1130DataSetTableAdapters.HospitalDepartmentsTableAdapter();
            this.txttest = new System.Windows.Forms.TextBox();
            this.txttest3 = new System.Windows.Forms.TextBox();
            this.txttest2 = new System.Windows.Forms.TextBox();
            this.lblSearchByDate = new System.Windows.Forms.Label();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalCensusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sE265_AJF1130DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sE265_AJF1130DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetRecordsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sE265_AJF1130DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_GetRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_GetRecordsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDepartmentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sE265AJF1130DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDepartmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hospitalCensusBindingSource
            // 
            this.hospitalCensusBindingSource.DataMember = "HospitalCensus";
            this.hospitalCensusBindingSource.DataSource = this.sE265_AJF1130DataSet1;
            // 
            // sE265_AJF1130DataSet1
            // 
            this.sE265_AJF1130DataSet1.DataSetName = "SE265_AJF1130DataSet1";
            this.sE265_AJF1130DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalCensusTableAdapter
            // 
            this.hospitalCensusTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._6ACUTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BHUTableAdapter = null;
            this.tableAdapterManager.CensusTableAdapter = null;
            this.tableAdapterManager.HospitalCensusTableAdapter = this.hospitalCensusTableAdapter;
            this.tableAdapterManager.HospitalDepartmentsTableAdapter = null;
            this.tableAdapterManager.ICUTableAdapter = null;
            this.tableAdapterManager.PEDITableAdapter = null;
            this.tableAdapterManager.T2TableAdapter = null;
            this.tableAdapterManager.T4TableAdapter = null;
            this.tableAdapterManager.TBCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DailyCensusReport.SE265_AJF1130DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // spGetHospitalCensusTableAdapter
            // 
            this.spGetHospitalCensusTableAdapter.ClearBeforeFill = true;
            // 
            // sE265_AJF1130DataSet
            // 
            this.sE265_AJF1130DataSet.DataSetName = "SE265_AJF1130DataSet";
            this.sE265_AJF1130DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spGetRecordsTableAdapter
            // 
            this.spGetRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1._6ACUTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BHUTableAdapter = null;
            this.tableAdapterManager1.CensusTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.HospitalCensusTableAdapter = null;
            this.tableAdapterManager1.HospitalDepartmentsTableAdapter = null;
            this.tableAdapterManager1.ICUTableAdapter = null;
            this.tableAdapterManager1.PEDITableAdapter = null;
            this.tableAdapterManager1.T2TableAdapter = null;
            this.tableAdapterManager1.T4TableAdapter = null;
            this.tableAdapterManager1.TBCTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = DailyCensusReport.SE265_AJF1130DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // spGetRecordsBindingSource
            // 
            this.spGetRecordsBindingSource.DataMember = "spGetRecords";
            this.spGetRecordsBindingSource.DataSource = this.sE265_AJF1130DataSet;
            // 
            // spGetRecordsBindingSource1
            // 
            this.spGetRecordsBindingSource1.DataMember = "spGetRecords";
            this.spGetRecordsBindingSource1.DataSource = this.sE265_AJF1130DataSet;
            // 
            // sE265_AJF1130DataSet2
            // 
            this.sE265_AJF1130DataSet2.DataSetName = "SE265_AJF1130DataSet2";
            this.sE265_AJF1130DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_GetRecordsBindingSource
            // 
            this.vw_GetRecordsBindingSource.DataMember = "vw_GetRecords";
            this.vw_GetRecordsBindingSource.DataSource = this.sE265_AJF1130DataSet2;
            // 
            // vw_GetRecordsTableAdapter
            // 
            this.vw_GetRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2._6ACUTableAdapter = null;
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.BHUTableAdapter = null;
            this.tableAdapterManager2.CensusTableAdapter = null;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.HospitalCensusTableAdapter = null;
            this.tableAdapterManager2.HospitalDepartmentsTableAdapter = null;
            this.tableAdapterManager2.ICUTableAdapter = null;
            this.tableAdapterManager2.PEDITableAdapter = null;
            this.tableAdapterManager2.T2TableAdapter = null;
            this.tableAdapterManager2.T4TableAdapter = null;
            this.tableAdapterManager2.TBCTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = DailyCensusReport.SE265_AJF1130DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vw_GetRecordsDataGridView
            // 
            this.vw_GetRecordsDataGridView.AllowUserToAddRows = false;
            this.vw_GetRecordsDataGridView.AllowUserToDeleteRows = false;
            this.vw_GetRecordsDataGridView.AutoGenerateColumns = false;
            this.vw_GetRecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vw_GetRecordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.vw_GetRecordsDataGridView.DataSource = this.vw_GetRecordsBindingSource;
            this.vw_GetRecordsDataGridView.Location = new System.Drawing.Point(0, 174);
            this.vw_GetRecordsDataGridView.Name = "vw_GetRecordsDataGridView";
            this.vw_GetRecordsDataGridView.ReadOnly = true;
            this.vw_GetRecordsDataGridView.Size = new System.Drawing.Size(874, 269);
            this.vw_GetRecordsDataGridView.TabIndex = 1;
            this.vw_GetRecordsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hospitalCensusDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "unitName";
            this.dataGridViewTextBoxColumn1.HeaderText = "unitName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "currentCensus";
            this.dataGridViewTextBoxColumn2.HeaderText = "currentCensus";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "availBeds";
            this.dataGridViewTextBoxColumn3.HeaderText = "availBeds";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "numberISP";
            this.dataGridViewTextBoxColumn4.HeaderText = "numberISP";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DC";
            this.dataGridViewTextBoxColumn5.HeaderText = "DC";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "notes";
            this.dataGridViewTextBoxColumn6.HeaderText = "notes";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "currentCap";
            this.dataGridViewTextBoxColumn7.HeaderText = "currentCap";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "updateDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "updateDate";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // lblSearchByUnitName
            // 
            this.lblSearchByUnitName.AutoSize = true;
            this.lblSearchByUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByUnitName.Location = new System.Drawing.Point(251, 85);
            this.lblSearchByUnitName.Name = "lblSearchByUnitName";
            this.lblSearchByUnitName.Size = new System.Drawing.Size(183, 20);
            this.lblSearchByUnitName.TabIndex = 2;
            this.lblSearchByUnitName.Text = "Search by Unit Name:";
            // 
            // cboUnitNameSearch
            // 
            this.cboUnitNameSearch.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hospitalDepartmentsBindingSource1, "unitID", true));
            this.cboUnitNameSearch.DataSource = this.hospitalDepartmentsBindingSource1;
            this.cboUnitNameSearch.DisplayMember = "unitName";
            this.cboUnitNameSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnitNameSearch.FormattingEnabled = true;
            this.cboUnitNameSearch.Location = new System.Drawing.Point(255, 109);
            this.cboUnitNameSearch.Name = "cboUnitNameSearch";
            this.cboUnitNameSearch.Size = new System.Drawing.Size(146, 21);
            this.cboUnitNameSearch.TabIndex = 3;
            this.cboUnitNameSearch.ValueMember = "unitName";
            this.cboUnitNameSearch.SelectedIndexChanged += new System.EventHandler(this.cboUnitNameSearch_SelectedIndexChanged);
            // 
            // hospitalDepartmentsBindingSource1
            // 
            this.hospitalDepartmentsBindingSource1.DataMember = "HospitalDepartments";
            this.hospitalDepartmentsBindingSource1.DataSource = this.sE265AJF1130DataSetBindingSource;
            // 
            // sE265AJF1130DataSetBindingSource
            // 
            this.sE265AJF1130DataSetBindingSource.DataSource = this.sE265_AJF1130DataSet;
            this.sE265AJF1130DataSetBindingSource.Position = 0;
            // 
            // hospitalDepartmentsBindingSource
            // 
            this.hospitalDepartmentsBindingSource.DataMember = "HospitalDepartments";
            this.hospitalDepartmentsBindingSource.DataSource = this.sE265AJF1130DataSetBindingSource;
            // 
            // hospitalDepartmentsTableAdapter
            // 
            this.hospitalDepartmentsTableAdapter.ClearBeforeFill = true;
            // 
            // txttest
            // 
            this.txttest.Location = new System.Drawing.Point(246, 33);
            this.txttest.Name = "txttest";
            this.txttest.Size = new System.Drawing.Size(100, 20);
            this.txttest.TabIndex = 4;
            // 
            // txttest3
            // 
            this.txttest3.Location = new System.Drawing.Point(488, 34);
            this.txttest3.Name = "txttest3";
            this.txttest3.Size = new System.Drawing.Size(100, 20);
            this.txttest3.TabIndex = 5;
            // 
            // txttest2
            // 
            this.txttest2.Location = new System.Drawing.Point(367, 34);
            this.txttest2.Name = "txttest2";
            this.txttest2.Size = new System.Drawing.Size(100, 20);
            this.txttest2.TabIndex = 6;
            // 
            // lblSearchByDate
            // 
            this.lblSearchByDate.AutoSize = true;
            this.lblSearchByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByDate.Location = new System.Drawing.Point(495, 85);
            this.lblSearchByDate.Name = "lblSearchByDate";
            this.lblSearchByDate.Size = new System.Drawing.Size(138, 20);
            this.lblSearchByDate.TabIndex = 7;
            this.lblSearchByDate.Text = "Search by Date:";
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.Location = new System.Drawing.Point(459, 109);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(183, 20);
            this.dtpSearchDate.TabIndex = 8;
            this.dtpSearchDate.Value = new System.DateTime(2016, 3, 3, 18, 16, 59, 0);
            this.dtpSearchDate.ValueChanged += new System.EventHandler(this.dtpSearchDate_ValueChanged);
            // 
            // ViewRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 444);
            this.Controls.Add(this.dtpSearchDate);
            this.Controls.Add(this.lblSearchByDate);
            this.Controls.Add(this.txttest2);
            this.Controls.Add(this.txttest3);
            this.Controls.Add(this.txttest);
            this.Controls.Add(this.cboUnitNameSearch);
            this.Controls.Add(this.lblSearchByUnitName);
            this.Controls.Add(this.vw_GetRecordsDataGridView);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hospitalCensusBindingSource, "unitID", true));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewRecordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewRecordsForm";
            this.Load += new System.EventHandler(this.ViewRecordsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalCensusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sE265_AJF1130DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sE265_AJF1130DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetRecordsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sE265_AJF1130DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_GetRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_GetRecordsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDepartmentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sE265AJF1130DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDepartmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SE265_AJF1130DataSet1 sE265_AJF1130DataSet1;
        private System.Windows.Forms.BindingSource hospitalCensusBindingSource;
        private SE265_AJF1130DataSet1TableAdapters.HospitalCensusTableAdapter hospitalCensusTableAdapter;
        private SE265_AJF1130DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private SE265_AJF1130DataSet1TableAdapters.spGetHospitalCensusTableAdapter spGetHospitalCensusTableAdapter;
        private SE265_AJF1130DataSet sE265_AJF1130DataSet;
        private SE265_AJF1130DataSetTableAdapters.spGetRecordsTableAdapter spGetRecordsTableAdapter;
        private SE265_AJF1130DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource spGetRecordsBindingSource;
        private System.Windows.Forms.BindingSource spGetRecordsBindingSource1;
        private SE265_AJF1130DataSet2 sE265_AJF1130DataSet2;
        private System.Windows.Forms.BindingSource vw_GetRecordsBindingSource;
        private SE265_AJF1130DataSet2TableAdapters.vw_GetRecordsTableAdapter vw_GetRecordsTableAdapter;
        private SE265_AJF1130DataSet2TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView vw_GetRecordsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label lblSearchByUnitName;
        private System.Windows.Forms.ComboBox cboUnitNameSearch;
        private System.Windows.Forms.BindingSource sE265AJF1130DataSetBindingSource;
        private System.Windows.Forms.BindingSource hospitalDepartmentsBindingSource;
        private SE265_AJF1130DataSetTableAdapters.HospitalDepartmentsTableAdapter hospitalDepartmentsTableAdapter;
        private System.Windows.Forms.BindingSource hospitalDepartmentsBindingSource1;
        private System.Windows.Forms.TextBox txttest;
        private System.Windows.Forms.TextBox txttest3;
        private System.Windows.Forms.TextBox txttest2;
        private System.Windows.Forms.Label lblSearchByDate;
        private System.Windows.Forms.DateTimePicker dtpSearchDate;
    }
}