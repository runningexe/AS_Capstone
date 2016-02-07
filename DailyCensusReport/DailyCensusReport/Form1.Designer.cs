namespace DailyCensusReport
{
    partial class frmDailyCensusReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDailyCensusReport));
            this.tlpHeaders = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblPotentialDCs = new System.Windows.Forms.Label();
            this.lblIsolationPts = new System.Windows.Forms.Label();
            this.lblAvailBeds = new System.Windows.Forms.Label();
            this.lblCurrentCensus = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.tlpICU = new System.Windows.Forms.TableLayoutPanel();
            this.txtDischarges = new System.Windows.Forms.TextBox();
            this.txtIsoPatients = new System.Windows.Forms.TextBox();
            this.txtAvailableBeds = new System.Windows.Forms.TextBox();
            this.txtCurrentCensus = new System.Windows.Forms.TextBox();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.lblICU = new System.Windows.Forms.Label();
            this.txtCurrentCapStatus = new System.Windows.Forms.TextBox();
            this.iCUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sE265_AJF1130DataSet = new DailyCensusReport.SE265_AJF1130DataSet();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnViewRecord = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.iCUTableAdapter = new DailyCensusReport.SE265_AJF1130DataSetTableAdapters.ICUTableAdapter();
            this.tableAdapterManager = new DailyCensusReport.SE265_AJF1130DataSetTableAdapters.TableAdapterManager();
            this.tlpHeaders.SuspendLayout();
            this.tlpICU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iCUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sE265_AJF1130DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpHeaders
            // 
            this.tlpHeaders.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpHeaders.ColumnCount = 7;
            this.tlpHeaders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHeaders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tlpHeaders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpHeaders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlpHeaders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tlpHeaders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tlpHeaders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tlpHeaders.Controls.Add(this.lblCurrentStatus, 6, 0);
            this.tlpHeaders.Controls.Add(this.lblNotes, 5, 0);
            this.tlpHeaders.Controls.Add(this.lblPotentialDCs, 4, 0);
            this.tlpHeaders.Controls.Add(this.lblIsolationPts, 3, 0);
            this.tlpHeaders.Controls.Add(this.lblAvailBeds, 2, 0);
            this.tlpHeaders.Controls.Add(this.lblCurrentCensus, 1, 0);
            this.tlpHeaders.Controls.Add(this.lblUnit, 0, 0);
            this.tlpHeaders.Location = new System.Drawing.Point(12, 88);
            this.tlpHeaders.Name = "tlpHeaders";
            this.tlpHeaders.RowCount = 1;
            this.tlpHeaders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHeaders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpHeaders.Size = new System.Drawing.Size(680, 31);
            this.tlpHeaders.TabIndex = 0;
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStatus.Location = new System.Drawing.Point(566, 2);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(101, 26);
            this.lblCurrentStatus.TabIndex = 6;
            this.lblCurrentStatus.Text = "Current Capacity Status";
            this.lblCurrentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(432, 9);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(40, 13);
            this.lblNotes.TabIndex = 5;
            this.lblNotes.Text = "Notes";
            // 
            // lblPotentialDCs
            // 
            this.lblPotentialDCs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPotentialDCs.AutoSize = true;
            this.lblPotentialDCs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotentialDCs.Location = new System.Drawing.Point(284, 2);
            this.lblPotentialDCs.Name = "lblPotentialDCs";
            this.lblPotentialDCs.Size = new System.Drawing.Size(57, 26);
            this.lblPotentialDCs.TabIndex = 4;
            this.lblPotentialDCs.Text = "Potential D/Cs";
            this.lblPotentialDCs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIsolationPts
            // 
            this.lblIsolationPts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIsolationPts.AutoSize = true;
            this.lblIsolationPts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsolationPts.Location = new System.Drawing.Point(213, 1);
            this.lblIsolationPts.Name = "lblIsolationPts";
            this.lblIsolationPts.Size = new System.Drawing.Size(55, 29);
            this.lblIsolationPts.TabIndex = 3;
            this.lblIsolationPts.Text = "# of Isolation Pts.";
            this.lblIsolationPts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvailBeds
            // 
            this.lblAvailBeds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAvailBeds.AutoSize = true;
            this.lblAvailBeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailBeds.Location = new System.Drawing.Point(153, 2);
            this.lblAvailBeds.Name = "lblAvailBeds";
            this.lblAvailBeds.Size = new System.Drawing.Size(39, 26);
            this.lblAvailBeds.TabIndex = 2;
            this.lblAvailBeds.Text = "Avail. Beds";
            this.lblAvailBeds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentCensus
            // 
            this.lblCurrentCensus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentCensus.AutoSize = true;
            this.lblCurrentCensus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCensus.Location = new System.Drawing.Point(79, 2);
            this.lblCurrentCensus.Name = "lblCurrentCensus";
            this.lblCurrentCensus.Size = new System.Drawing.Size(48, 26);
            this.lblCurrentCensus.TabIndex = 1;
            this.lblCurrentCensus.Text = "Current Census";
            this.lblCurrentCensus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnit
            // 
            this.lblUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(16, 9);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(37, 13);
            this.lblUnit.TabIndex = 0;
            this.lblUnit.Text = "UNIT";
            // 
            // tlpICU
            // 
            this.tlpICU.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tlpICU.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpICU.ColumnCount = 7;
            this.tlpICU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.27536F));
            this.tlpICU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.72464F));
            this.tlpICU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlpICU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpICU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tlpICU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tlpICU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tlpICU.Controls.Add(this.txtDischarges, 4, 0);
            this.tlpICU.Controls.Add(this.txtIsoPatients, 3, 0);
            this.tlpICU.Controls.Add(this.txtAvailableBeds, 2, 0);
            this.tlpICU.Controls.Add(this.txtCurrentCensus, 1, 0);
            this.tlpICU.Controls.Add(this.rtbNotes, 5, 0);
            this.tlpICU.Controls.Add(this.lblICU, 0, 0);
            this.tlpICU.Controls.Add(this.txtCurrentCapStatus, 6, 0);
            this.tlpICU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tlpICU.Location = new System.Drawing.Point(12, 118);
            this.tlpICU.Name = "tlpICU";
            this.tlpICU.RowCount = 1;
            this.tlpICU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpICU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpICU.Size = new System.Drawing.Size(680, 29);
            this.tlpICU.TabIndex = 1;
            // 
            // txtDischarges
            // 
            this.txtDischarges.Location = new System.Drawing.Point(279, 4);
            this.txtDischarges.Name = "txtDischarges";
            this.txtDischarges.Size = new System.Drawing.Size(68, 20);
            this.txtDischarges.TabIndex = 3;
            // 
            // txtIsoPatients
            // 
            this.txtIsoPatients.Location = new System.Drawing.Point(211, 4);
            this.txtIsoPatients.Name = "txtIsoPatients";
            this.txtIsoPatients.Size = new System.Drawing.Size(61, 20);
            this.txtIsoPatients.TabIndex = 2;
            // 
            // txtAvailableBeds
            // 
            this.txtAvailableBeds.Location = new System.Drawing.Point(142, 4);
            this.txtAvailableBeds.Name = "txtAvailableBeds";
            this.txtAvailableBeds.Size = new System.Drawing.Size(62, 20);
            this.txtAvailableBeds.TabIndex = 1;
            // 
            // txtCurrentCensus
            // 
            this.txtCurrentCensus.Location = new System.Drawing.Point(72, 4);
            this.txtCurrentCensus.Name = "txtCurrentCensus";
            this.txtCurrentCensus.Size = new System.Drawing.Size(63, 20);
            this.txtCurrentCensus.TabIndex = 0;
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(354, 4);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(196, 19);
            this.rtbNotes.TabIndex = 4;
            this.rtbNotes.Text = "";
            // 
            // lblICU
            // 
            this.lblICU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblICU.AutoSize = true;
            this.lblICU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICU.Location = new System.Drawing.Point(20, 8);
            this.lblICU.Name = "lblICU";
            this.lblICU.Size = new System.Drawing.Size(28, 13);
            this.lblICU.TabIndex = 8;
            this.lblICU.Text = "ICU";
            this.lblICU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurrentCapStatus
            // 
            this.txtCurrentCapStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurrentCapStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iCUBindingSource, "currentCap", true));
            this.txtCurrentCapStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentCapStatus.Location = new System.Drawing.Point(557, 4);
            this.txtCurrentCapStatus.Name = "txtCurrentCapStatus";
            this.txtCurrentCapStatus.ReadOnly = true;
            this.txtCurrentCapStatus.Size = new System.Drawing.Size(119, 21);
            this.txtCurrentCapStatus.TabIndex = 9;
            // 
            // iCUBindingSource
            // 
            this.iCUBindingSource.DataMember = "ICU";
            this.iCUBindingSource.DataSource = this.sE265_AJF1130DataSet;
            // 
            // sE265_AJF1130DataSet
            // 
            this.sE265_AJF1130DataSet.DataSetName = "SE265_AJF1130DataSet";
            this.sE265_AJF1130DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatAppearance.BorderSize = 3;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Location = new System.Drawing.Point(12, 308);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(281, 40);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnViewRecord
            // 
            this.btnViewRecord.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewRecord.FlatAppearance.BorderSize = 3;
            this.btnViewRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnViewRecord.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnViewRecord.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewRecord.Location = new System.Drawing.Point(299, 308);
            this.btnViewRecord.Name = "btnViewRecord";
            this.btnViewRecord.Size = new System.Drawing.Size(263, 40);
            this.btnViewRecord.TabIndex = 1;
            this.btnViewRecord.Text = "View Records";
            this.btnViewRecord.UseVisualStyleBackColor = true;
            this.btnViewRecord.Click += new System.EventHandler(this.btnViewRecord_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(568, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            // frmDailyCensusReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(712, 357);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewRecord);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tlpICU);
            this.Controls.Add(this.tlpHeaders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDailyCensusReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Census Report";
            this.Load += new System.EventHandler(this.frmDailyCensusReport_Load);
            this.tlpHeaders.ResumeLayout(false);
            this.tlpHeaders.PerformLayout();
            this.tlpICU.ResumeLayout(false);
            this.tlpICU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iCUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sE265_AJF1130DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpHeaders;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblPotentialDCs;
        private System.Windows.Forms.Label lblIsolationPts;
        private System.Windows.Forms.Label lblAvailBeds;
        private System.Windows.Forms.Label lblCurrentCensus;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TableLayoutPanel tlpICU;
        private System.Windows.Forms.TextBox txtDischarges;
        private System.Windows.Forms.TextBox txtIsoPatients;
        private System.Windows.Forms.TextBox txtAvailableBeds;
        private System.Windows.Forms.TextBox txtCurrentCensus;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnViewRecord;
        private System.Windows.Forms.Button btnExit;
        private SE265_AJF1130DataSet sE265_AJF1130DataSet;
        private System.Windows.Forms.BindingSource iCUBindingSource;
        private SE265_AJF1130DataSetTableAdapters.ICUTableAdapter iCUTableAdapter;
        private SE265_AJF1130DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblICU;
        private System.Windows.Forms.TextBox txtCurrentCapStatus;
    }
}

