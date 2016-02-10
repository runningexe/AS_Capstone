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
            this.txtNotesICU = new System.Windows.Forms.TextBox();
            this.iCUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sE265_AJF1130DataSet = new DailyCensusReport.SE265_AJF1130DataSet();
            this.txtDischargesICU = new System.Windows.Forms.TextBox();
            this.txtIsoPatientsICU = new System.Windows.Forms.TextBox();
            this.txtAvailableBedsICU = new System.Windows.Forms.TextBox();
            this.txtCurrentCensusICU = new System.Windows.Forms.TextBox();
            this.lblICU = new System.Windows.Forms.Label();
            this.txtCurrentCapStatusICU = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnViewRecord = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.iCUTableAdapter = new DailyCensusReport.SE265_AJF1130DataSetTableAdapters.ICUTableAdapter();
            this.tableAdapterManager = new DailyCensusReport.SE265_AJF1130DataSetTableAdapters.TableAdapterManager();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblT2 = new System.Windows.Forms.Label();
            this.txtCurrentCapStatusT2 = new System.Windows.Forms.TextBox();
            this.t2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sE265_AJF1130DataSet1 = new DailyCensusReport.SE265_AJF1130DataSet1();
            this.txtCurrentCensusT2 = new System.Windows.Forms.TextBox();
            this.txtNotesT2 = new System.Windows.Forms.TextBox();
            this.txtDischargesT2 = new System.Windows.Forms.TextBox();
            this.txtAvailableBedsT2 = new System.Windows.Forms.TextBox();
            this.txtIsoPatientsT2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCurrentCapStatusPEDI = new System.Windows.Forms.TextBox();
            this.pEDIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNotesPEDI = new System.Windows.Forms.TextBox();
            this.txtDischargesPEDI = new System.Windows.Forms.TextBox();
            this.txtIsoPatientsPEDI = new System.Windows.Forms.TextBox();
            this.txtAvailableBedsPEDI = new System.Windows.Forms.TextBox();
            this.txtCurrentCensusPEDI = new System.Windows.Forms.TextBox();
            this.lblPEDI = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCurrentCapStatus6ACU = new System.Windows.Forms.TextBox();
            this._6ACUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNotes6ACU = new System.Windows.Forms.TextBox();
            this.txtDischarges6ACU = new System.Windows.Forms.TextBox();
            this.txtIsoPatients6ACU = new System.Windows.Forms.TextBox();
            this.txtAvailableBeds6ACU = new System.Windows.Forms.TextBox();
            this.txtCurrentCensus6ACU = new System.Windows.Forms.TextBox();
            this.lbl6ACU = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCurrentCapStatusT4 = new System.Windows.Forms.TextBox();
            this.t4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNotesT4 = new System.Windows.Forms.TextBox();
            this.txtDischargesT4 = new System.Windows.Forms.TextBox();
            this.txtIsoPatientsT4 = new System.Windows.Forms.TextBox();
            this.txtAvailableBedsT4 = new System.Windows.Forms.TextBox();
            this.txtCurrentCensusT4 = new System.Windows.Forms.TextBox();
            this.lblT4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotAvailBeds = new System.Windows.Forms.Label();
            this.lblTotCurrentCensus = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotIsoPatients = new System.Windows.Forms.Label();
            this.lblTotDCs = new System.Windows.Forms.Label();
            this.lblTotalCapacity = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurrentCapStatusBHU = new System.Windows.Forms.TextBox();
            this.bHUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNotesBHU = new System.Windows.Forms.TextBox();
            this.txtDischargesBHU = new System.Windows.Forms.TextBox();
            this.txtIsoPatientsBHU = new System.Windows.Forms.TextBox();
            this.txtAvailableBedsBHU = new System.Windows.Forms.TextBox();
            this.txtCurrentCensusBHU = new System.Windows.Forms.TextBox();
            this.lblBHU = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCurrentCapStatusTBC = new System.Windows.Forms.TextBox();
            this.tBCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNotesTBC = new System.Windows.Forms.TextBox();
            this.txtDischargesTBC = new System.Windows.Forms.TextBox();
            this.txtIsoPatientsTBC = new System.Windows.Forms.TextBox();
            this.txtAvailableBedsTBC = new System.Windows.Forms.TextBox();
            this.txtCurrentCensusTBC = new System.Windows.Forms.TextBox();
            this.lblTBC = new System.Windows.Forms.Label();
            this.t2TableAdapter = new DailyCensusReport.SE265_AJF1130DataSet1TableAdapters.T2TableAdapter();
            this.tableAdapterManager1 = new DailyCensusReport.SE265_AJF1130DataSet1TableAdapters.TableAdapterManager();
            this.pEDITableAdapter = new DailyCensusReport.SE265_AJF1130DataSet1TableAdapters.PEDITableAdapter();
            this.t4TableAdapter = new DailyCensusReport.SE265_AJF1130DataSet1TableAdapters.T4TableAdapter();
            this._6ACUTableAdapter = new DailyCensusReport.SE265_AJF1130DataSet1TableAdapters._6ACUTableAdapter();
            this.tBCTableAdapter = new DailyCensusReport.SE265_AJF1130DataSet1TableAdapters.TBCTableAdapter();
            this.bHUTableAdapter = new DailyCensusReport.SE265_AJF1130DataSet1TableAdapters.BHUTableAdapter();
            this.tlpHeaders.SuspendLayout();
            this.tlpICU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iCUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sE265_AJF1130DataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sE265_AJF1130DataSet1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIBindingSource)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._6ACUBindingSource)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t4BindingSource)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bHUBindingSource)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBCBindingSource)).BeginInit();
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
            this.tlpHeaders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tlpHeaders.Controls.Add(this.lblCurrentStatus, 6, 0);
            this.tlpHeaders.Controls.Add(this.lblNotes, 5, 0);
            this.tlpHeaders.Controls.Add(this.lblPotentialDCs, 4, 0);
            this.tlpHeaders.Controls.Add(this.lblIsolationPts, 3, 0);
            this.tlpHeaders.Controls.Add(this.lblAvailBeds, 2, 0);
            this.tlpHeaders.Controls.Add(this.lblCurrentCensus, 1, 0);
            this.tlpHeaders.Controls.Add(this.lblUnit, 0, 0);
            this.tlpHeaders.Location = new System.Drawing.Point(12, 144);
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
            this.lblCurrentStatus.Location = new System.Drawing.Point(562, 2);
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
            this.lblNotes.Location = new System.Drawing.Point(425, 9);
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
            this.lblPotentialDCs.Location = new System.Drawing.Point(277, 2);
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
            this.lblIsolationPts.Location = new System.Drawing.Point(206, 1);
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
            this.lblAvailBeds.Location = new System.Drawing.Point(146, 2);
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
            this.lblCurrentCensus.Location = new System.Drawing.Point(72, 2);
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
            this.lblUnit.Location = new System.Drawing.Point(12, 9);
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
            this.tlpICU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tlpICU.Controls.Add(this.txtNotesICU, 5, 0);
            this.tlpICU.Controls.Add(this.txtDischargesICU, 4, 0);
            this.tlpICU.Controls.Add(this.txtIsoPatientsICU, 3, 0);
            this.tlpICU.Controls.Add(this.txtAvailableBedsICU, 2, 0);
            this.tlpICU.Controls.Add(this.txtCurrentCensusICU, 1, 0);
            this.tlpICU.Controls.Add(this.lblICU, 0, 0);
            this.tlpICU.Controls.Add(this.txtCurrentCapStatusICU, 6, 0);
            this.tlpICU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tlpICU.Location = new System.Drawing.Point(12, 174);
            this.tlpICU.Name = "tlpICU";
            this.tlpICU.RowCount = 1;
            this.tlpICU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpICU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpICU.Size = new System.Drawing.Size(680, 29);
            this.tlpICU.TabIndex = 1;
            // 
            // txtNotesICU
            // 
            this.txtNotesICU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iCUBindingSource, "notes", true));
            this.txtNotesICU.Location = new System.Drawing.Point(340, 4);
            this.txtNotesICU.Name = "txtNotesICU";
            this.txtNotesICU.Size = new System.Drawing.Size(196, 20);
            this.txtNotesICU.TabIndex = 6;
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
            // txtDischargesICU
            // 
            this.txtDischargesICU.Location = new System.Drawing.Point(265, 4);
            this.txtDischargesICU.Name = "txtDischargesICU";
            this.txtDischargesICU.Size = new System.Drawing.Size(68, 20);
            this.txtDischargesICU.TabIndex = 3;
            // 
            // txtIsoPatientsICU
            // 
            this.txtIsoPatientsICU.Location = new System.Drawing.Point(197, 4);
            this.txtIsoPatientsICU.Name = "txtIsoPatientsICU";
            this.txtIsoPatientsICU.Size = new System.Drawing.Size(61, 20);
            this.txtIsoPatientsICU.TabIndex = 2;
            // 
            // txtAvailableBedsICU
            // 
            this.txtAvailableBedsICU.Location = new System.Drawing.Point(128, 4);
            this.txtAvailableBedsICU.Name = "txtAvailableBedsICU";
            this.txtAvailableBedsICU.Size = new System.Drawing.Size(62, 20);
            this.txtAvailableBedsICU.TabIndex = 1;
            // 
            // txtCurrentCensusICU
            // 
            this.txtCurrentCensusICU.Location = new System.Drawing.Point(65, 4);
            this.txtCurrentCensusICU.Name = "txtCurrentCensusICU";
            this.txtCurrentCensusICU.Size = new System.Drawing.Size(56, 20);
            this.txtCurrentCensusICU.TabIndex = 0;
            // 
            // lblICU
            // 
            this.lblICU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblICU.AutoSize = true;
            this.lblICU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICU.Location = new System.Drawing.Point(17, 8);
            this.lblICU.Name = "lblICU";
            this.lblICU.Size = new System.Drawing.Size(28, 13);
            this.lblICU.TabIndex = 8;
            this.lblICU.Text = "ICU";
            this.lblICU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurrentCapStatusICU
            // 
            this.txtCurrentCapStatusICU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurrentCapStatusICU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iCUBindingSource, "currentCap", true));
            this.txtCurrentCapStatusICU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentCapStatusICU.Location = new System.Drawing.Point(550, 4);
            this.txtCurrentCapStatusICU.Name = "txtCurrentCapStatusICU";
            this.txtCurrentCapStatusICU.ReadOnly = true;
            this.txtCurrentCapStatusICU.Size = new System.Drawing.Size(119, 21);
            this.txtCurrentCapStatusICU.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatAppearance.BorderSize = 3;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Location = new System.Drawing.Point(12, 419);
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
            this.btnViewRecord.Location = new System.Drawing.Point(299, 419);
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
            this.btnExit.Location = new System.Drawing.Point(568, 419);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 40);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblT2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCurrentCapStatusT2, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCurrentCensusT2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNotesT2, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDischargesT2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAvailableBedsT2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtIsoPatientsT2, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 202);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(680, 30);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "T2 M/S";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblT2
            // 
            this.lblT2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblT2.AutoSize = true;
            this.lblT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT2.Location = new System.Drawing.Point(6, 1);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(50, 1);
            this.lblT2.TabIndex = 28;
            this.lblT2.Text = "T2 M/S";
            this.lblT2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurrentCapStatusT2
            // 
            this.txtCurrentCapStatusT2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t2BindingSource, "currentCap", true));
            this.txtCurrentCapStatusT2.Location = new System.Drawing.Point(550, 4);
            this.txtCurrentCapStatusT2.Name = "txtCurrentCapStatusT2";
            this.txtCurrentCapStatusT2.ReadOnly = true;
            this.txtCurrentCapStatusT2.Size = new System.Drawing.Size(119, 20);
            this.txtCurrentCapStatusT2.TabIndex = 27;
            // 
            // t2BindingSource
            // 
            this.t2BindingSource.DataMember = "T2";
            this.t2BindingSource.DataSource = this.sE265_AJF1130DataSet1;
            // 
            // sE265_AJF1130DataSet1
            // 
            this.sE265_AJF1130DataSet1.DataSetName = "SE265_AJF1130DataSet1";
            this.sE265_AJF1130DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCurrentCensusT2
            // 
            this.txtCurrentCensusT2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t2BindingSource, "currentCensus", true));
            this.txtCurrentCensusT2.Location = new System.Drawing.Point(65, 4);
            this.txtCurrentCensusT2.Name = "txtCurrentCensusT2";
            this.txtCurrentCensusT2.Size = new System.Drawing.Size(63, 20);
            this.txtCurrentCensusT2.TabIndex = 17;
            // 
            // txtNotesT2
            // 
            this.txtNotesT2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t2BindingSource, "notes", true));
            this.txtNotesT2.Location = new System.Drawing.Point(347, 4);
            this.txtNotesT2.Name = "txtNotesT2";
            this.txtNotesT2.Size = new System.Drawing.Size(196, 20);
            this.txtNotesT2.TabIndex = 25;
            // 
            // txtDischargesT2
            // 
            this.txtDischargesT2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t2BindingSource, "DC", true));
            this.txtDischargesT2.Location = new System.Drawing.Point(272, 4);
            this.txtDischargesT2.Name = "txtDischargesT2";
            this.txtDischargesT2.Size = new System.Drawing.Size(68, 20);
            this.txtDischargesT2.TabIndex = 23;
            // 
            // txtAvailableBedsT2
            // 
            this.txtAvailableBedsT2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t2BindingSource, "availBeds", true));
            this.txtAvailableBedsT2.Location = new System.Drawing.Point(135, 4);
            this.txtAvailableBedsT2.Name = "txtAvailableBedsT2";
            this.txtAvailableBedsT2.Size = new System.Drawing.Size(61, 20);
            this.txtAvailableBedsT2.TabIndex = 19;
            // 
            // txtIsoPatientsT2
            // 
            this.txtIsoPatientsT2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t2BindingSource, "numberISP", true));
            this.txtIsoPatientsT2.Location = new System.Drawing.Point(203, 4);
            this.txtIsoPatientsT2.Name = "txtIsoPatientsT2";
            this.txtIsoPatientsT2.Size = new System.Drawing.Size(62, 20);
            this.txtIsoPatientsT2.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.27536F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.72464F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel2.Controls.Add(this.txtCurrentCapStatusPEDI, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNotesPEDI, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtDischargesPEDI, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtIsoPatientsPEDI, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtAvailableBedsPEDI, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtCurrentCensusPEDI, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPEDI, 0, 0);
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 231);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(680, 29);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // txtCurrentCapStatusPEDI
            // 
            this.txtCurrentCapStatusPEDI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pEDIBindingSource, "currentCap", true));
            this.txtCurrentCapStatusPEDI.Location = new System.Drawing.Point(543, 4);
            this.txtCurrentCapStatusPEDI.Name = "txtCurrentCapStatusPEDI";
            this.txtCurrentCapStatusPEDI.ReadOnly = true;
            this.txtCurrentCapStatusPEDI.Size = new System.Drawing.Size(121, 20);
            this.txtCurrentCapStatusPEDI.TabIndex = 27;
            // 
            // pEDIBindingSource
            // 
            this.pEDIBindingSource.DataMember = "PEDI";
            this.pEDIBindingSource.DataSource = this.sE265_AJF1130DataSet1;
            // 
            // txtNotesPEDI
            // 
            this.txtNotesPEDI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pEDIBindingSource, "notes", true));
            this.txtNotesPEDI.Location = new System.Drawing.Point(340, 4);
            this.txtNotesPEDI.Name = "txtNotesPEDI";
            this.txtNotesPEDI.Size = new System.Drawing.Size(196, 20);
            this.txtNotesPEDI.TabIndex = 25;
            // 
            // txtDischargesPEDI
            // 
            this.txtDischargesPEDI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pEDIBindingSource, "DC", true));
            this.txtDischargesPEDI.Location = new System.Drawing.Point(265, 4);
            this.txtDischargesPEDI.Name = "txtDischargesPEDI";
            this.txtDischargesPEDI.Size = new System.Drawing.Size(68, 20);
            this.txtDischargesPEDI.TabIndex = 23;
            // 
            // txtIsoPatientsPEDI
            // 
            this.txtIsoPatientsPEDI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pEDIBindingSource, "numberISP", true));
            this.txtIsoPatientsPEDI.Location = new System.Drawing.Point(197, 4);
            this.txtIsoPatientsPEDI.Name = "txtIsoPatientsPEDI";
            this.txtIsoPatientsPEDI.Size = new System.Drawing.Size(61, 20);
            this.txtIsoPatientsPEDI.TabIndex = 21;
            // 
            // txtAvailableBedsPEDI
            // 
            this.txtAvailableBedsPEDI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pEDIBindingSource, "availBeds", true));
            this.txtAvailableBedsPEDI.Location = new System.Drawing.Point(128, 4);
            this.txtAvailableBedsPEDI.Name = "txtAvailableBedsPEDI";
            this.txtAvailableBedsPEDI.Size = new System.Drawing.Size(62, 20);
            this.txtAvailableBedsPEDI.TabIndex = 19;
            // 
            // txtCurrentCensusPEDI
            // 
            this.txtCurrentCensusPEDI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pEDIBindingSource, "currentCensus", true));
            this.txtCurrentCensusPEDI.Location = new System.Drawing.Point(65, 4);
            this.txtCurrentCensusPEDI.Name = "txtCurrentCensusPEDI";
            this.txtCurrentCensusPEDI.Size = new System.Drawing.Size(56, 20);
            this.txtCurrentCensusPEDI.TabIndex = 17;
            // 
            // lblPEDI
            // 
            this.lblPEDI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPEDI.AutoSize = true;
            this.lblPEDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPEDI.Location = new System.Drawing.Point(13, 1);
            this.lblPEDI.Name = "lblPEDI";
            this.lblPEDI.Size = new System.Drawing.Size(36, 26);
            this.lblPEDI.TabIndex = 30;
            this.lblPEDI.Text = "PEDI (T2)";
            this.lblPEDI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.27536F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.72464F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel3.Controls.Add(this.txtCurrentCapStatus6ACU, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtNotes6ACU, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtDischarges6ACU, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtIsoPatients6ACU, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtAvailableBeds6ACU, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtCurrentCensus6ACU, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl6ACU, 0, 0);
            this.tableLayoutPanel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 288);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(680, 29);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // txtCurrentCapStatus6ACU
            // 
            this.txtCurrentCapStatus6ACU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._6ACUBindingSource, "currentCap", true));
            this.txtCurrentCapStatus6ACU.Location = new System.Drawing.Point(543, 4);
            this.txtCurrentCapStatus6ACU.Name = "txtCurrentCapStatus6ACU";
            this.txtCurrentCapStatus6ACU.ReadOnly = true;
            this.txtCurrentCapStatus6ACU.Size = new System.Drawing.Size(121, 20);
            this.txtCurrentCapStatus6ACU.TabIndex = 27;
            // 
            // _6ACUBindingSource
            // 
            this._6ACUBindingSource.DataMember = "6ACU";
            this._6ACUBindingSource.DataSource = this.sE265_AJF1130DataSet1;
            // 
            // txtNotes6ACU
            // 
            this.txtNotes6ACU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._6ACUBindingSource, "notes", true));
            this.txtNotes6ACU.Location = new System.Drawing.Point(340, 4);
            this.txtNotes6ACU.Name = "txtNotes6ACU";
            this.txtNotes6ACU.Size = new System.Drawing.Size(196, 20);
            this.txtNotes6ACU.TabIndex = 25;
            // 
            // txtDischarges6ACU
            // 
            this.txtDischarges6ACU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._6ACUBindingSource, "DC", true));
            this.txtDischarges6ACU.Location = new System.Drawing.Point(265, 4);
            this.txtDischarges6ACU.Name = "txtDischarges6ACU";
            this.txtDischarges6ACU.Size = new System.Drawing.Size(68, 20);
            this.txtDischarges6ACU.TabIndex = 23;
            // 
            // txtIsoPatients6ACU
            // 
            this.txtIsoPatients6ACU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._6ACUBindingSource, "numberISP", true));
            this.txtIsoPatients6ACU.Location = new System.Drawing.Point(197, 4);
            this.txtIsoPatients6ACU.Name = "txtIsoPatients6ACU";
            this.txtIsoPatients6ACU.Size = new System.Drawing.Size(61, 20);
            this.txtIsoPatients6ACU.TabIndex = 21;
            // 
            // txtAvailableBeds6ACU
            // 
            this.txtAvailableBeds6ACU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._6ACUBindingSource, "availBeds", true));
            this.txtAvailableBeds6ACU.Location = new System.Drawing.Point(128, 4);
            this.txtAvailableBeds6ACU.Name = "txtAvailableBeds6ACU";
            this.txtAvailableBeds6ACU.Size = new System.Drawing.Size(62, 20);
            this.txtAvailableBeds6ACU.TabIndex = 19;
            // 
            // txtCurrentCensus6ACU
            // 
            this.txtCurrentCensus6ACU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._6ACUBindingSource, "currentCensus", true));
            this.txtCurrentCensus6ACU.Location = new System.Drawing.Point(65, 4);
            this.txtCurrentCensus6ACU.Name = "txtCurrentCensus6ACU";
            this.txtCurrentCensus6ACU.Size = new System.Drawing.Size(56, 20);
            this.txtCurrentCensus6ACU.TabIndex = 17;
            // 
            // lbl6ACU
            // 
            this.lbl6ACU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl6ACU.AutoSize = true;
            this.lbl6ACU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6ACU.Location = new System.Drawing.Point(11, 8);
            this.lbl6ACU.Name = "lbl6ACU";
            this.lbl6ACU.Size = new System.Drawing.Size(39, 13);
            this.lbl6ACU.TabIndex = 31;
            this.lbl6ACU.Text = "6ACU";
            this.lbl6ACU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel4.Controls.Add(this.txtCurrentCapStatusT4, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtNotesT4, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtDischargesT4, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtIsoPatientsT4, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtAvailableBedsT4, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtCurrentCensusT4, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblT4, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(12, 259);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(680, 30);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // txtCurrentCapStatusT4
            // 
            this.txtCurrentCapStatusT4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t4BindingSource, "currentCap", true));
            this.txtCurrentCapStatusT4.Location = new System.Drawing.Point(550, 4);
            this.txtCurrentCapStatusT4.Name = "txtCurrentCapStatusT4";
            this.txtCurrentCapStatusT4.ReadOnly = true;
            this.txtCurrentCapStatusT4.Size = new System.Drawing.Size(119, 20);
            this.txtCurrentCapStatusT4.TabIndex = 27;
            // 
            // t4BindingSource
            // 
            this.t4BindingSource.DataMember = "T4";
            this.t4BindingSource.DataSource = this.sE265_AJF1130DataSet1;
            // 
            // txtNotesT4
            // 
            this.txtNotesT4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t4BindingSource, "notes", true));
            this.txtNotesT4.Location = new System.Drawing.Point(347, 4);
            this.txtNotesT4.Name = "txtNotesT4";
            this.txtNotesT4.Size = new System.Drawing.Size(196, 20);
            this.txtNotesT4.TabIndex = 25;
            // 
            // txtDischargesT4
            // 
            this.txtDischargesT4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t4BindingSource, "DC", true));
            this.txtDischargesT4.Location = new System.Drawing.Point(272, 4);
            this.txtDischargesT4.Name = "txtDischargesT4";
            this.txtDischargesT4.Size = new System.Drawing.Size(68, 20);
            this.txtDischargesT4.TabIndex = 23;
            // 
            // txtIsoPatientsT4
            // 
            this.txtIsoPatientsT4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t4BindingSource, "numberISP", true));
            this.txtIsoPatientsT4.Location = new System.Drawing.Point(203, 4);
            this.txtIsoPatientsT4.Name = "txtIsoPatientsT4";
            this.txtIsoPatientsT4.Size = new System.Drawing.Size(62, 20);
            this.txtIsoPatientsT4.TabIndex = 21;
            // 
            // txtAvailableBedsT4
            // 
            this.txtAvailableBedsT4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t4BindingSource, "availBeds", true));
            this.txtAvailableBedsT4.Location = new System.Drawing.Point(135, 4);
            this.txtAvailableBedsT4.Name = "txtAvailableBedsT4";
            this.txtAvailableBedsT4.Size = new System.Drawing.Size(61, 20);
            this.txtAvailableBedsT4.TabIndex = 19;
            // 
            // txtCurrentCensusT4
            // 
            this.txtCurrentCensusT4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t4BindingSource, "currentCensus", true));
            this.txtCurrentCensusT4.Location = new System.Drawing.Point(65, 4);
            this.txtCurrentCensusT4.Name = "txtCurrentCensusT4";
            this.txtCurrentCensusT4.Size = new System.Drawing.Size(63, 20);
            this.txtCurrentCensusT4.TabIndex = 17;
            // 
            // lblT4
            // 
            this.lblT4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblT4.AutoSize = true;
            this.lblT4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT4.Location = new System.Drawing.Point(6, 8);
            this.lblT4.Name = "lblT4";
            this.lblT4.Size = new System.Drawing.Size(50, 13);
            this.lblT4.TabIndex = 30;
            this.lblT4.Text = "T4 M/S";
            this.lblT4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 7;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel6.Controls.Add(this.lblTotAvailBeds, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblTotCurrentCensus, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblTotal, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblTotIsoPatients, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblTotDCs, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblTotalCapacity, 6, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(12, 373);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(680, 30);
            this.tableLayoutPanel6.TabIndex = 9;
            // 
            // lblTotAvailBeds
            // 
            this.lblTotAvailBeds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotAvailBeds.AutoSize = true;
            this.lblTotAvailBeds.Location = new System.Drawing.Point(165, 8);
            this.lblTotAvailBeds.Name = "lblTotAvailBeds";
            this.lblTotAvailBeds.Size = new System.Drawing.Size(0, 13);
            this.lblTotAvailBeds.TabIndex = 37;
            // 
            // lblTotCurrentCensus
            // 
            this.lblTotCurrentCensus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotCurrentCensus.AutoSize = true;
            this.lblTotCurrentCensus.Location = new System.Drawing.Point(96, 8);
            this.lblTotCurrentCensus.Name = "lblTotCurrentCensus";
            this.lblTotCurrentCensus.Size = new System.Drawing.Size(0, 13);
            this.lblTotCurrentCensus.TabIndex = 36;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(4, 7);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(53, 15);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "TOTAL:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotIsoPatients
            // 
            this.lblTotIsoPatients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotIsoPatients.AutoSize = true;
            this.lblTotIsoPatients.Location = new System.Drawing.Point(234, 8);
            this.lblTotIsoPatients.Name = "lblTotIsoPatients";
            this.lblTotIsoPatients.Size = new System.Drawing.Size(0, 13);
            this.lblTotIsoPatients.TabIndex = 34;
            // 
            // lblTotDCs
            // 
            this.lblTotDCs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotDCs.AutoSize = true;
            this.lblTotDCs.Location = new System.Drawing.Point(306, 8);
            this.lblTotDCs.Name = "lblTotDCs";
            this.lblTotDCs.Size = new System.Drawing.Size(0, 13);
            this.lblTotDCs.TabIndex = 35;
            // 
            // lblTotalCapacity
            // 
            this.lblTotalCapacity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalCapacity.AutoSize = true;
            this.lblTotalCapacity.Location = new System.Drawing.Point(613, 8);
            this.lblTotalCapacity.Name = "lblTotalCapacity";
            this.lblTotalCapacity.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCapacity.TabIndex = 38;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel7.ColumnCount = 7;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.27536F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.72464F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel7.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.txtCurrentCapStatusBHU, 6, 0);
            this.tableLayoutPanel7.Controls.Add(this.txtNotesBHU, 5, 0);
            this.tableLayoutPanel7.Controls.Add(this.txtDischargesBHU, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.txtIsoPatientsBHU, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.txtAvailableBedsBHU, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.txtCurrentCensusBHU, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblBHU, 0, 0);
            this.tableLayoutPanel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(12, 345);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(680, 29);
            this.tableLayoutPanel7.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 26);
            this.label3.TabIndex = 34;
            this.label3.Text = "BHU (T8)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurrentCapStatusBHU
            // 
            this.txtCurrentCapStatusBHU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bHUBindingSource, "currentCap", true));
            this.txtCurrentCapStatusBHU.Location = new System.Drawing.Point(543, 4);
            this.txtCurrentCapStatusBHU.Name = "txtCurrentCapStatusBHU";
            this.txtCurrentCapStatusBHU.ReadOnly = true;
            this.txtCurrentCapStatusBHU.Size = new System.Drawing.Size(121, 20);
            this.txtCurrentCapStatusBHU.TabIndex = 27;
            // 
            // bHUBindingSource
            // 
            this.bHUBindingSource.DataMember = "BHU";
            this.bHUBindingSource.DataSource = this.sE265_AJF1130DataSet1;
            // 
            // txtNotesBHU
            // 
            this.txtNotesBHU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bHUBindingSource, "notes", true));
            this.txtNotesBHU.Location = new System.Drawing.Point(340, 4);
            this.txtNotesBHU.Name = "txtNotesBHU";
            this.txtNotesBHU.Size = new System.Drawing.Size(196, 20);
            this.txtNotesBHU.TabIndex = 25;
            // 
            // txtDischargesBHU
            // 
            this.txtDischargesBHU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bHUBindingSource, "DC", true));
            this.txtDischargesBHU.Location = new System.Drawing.Point(265, 4);
            this.txtDischargesBHU.Name = "txtDischargesBHU";
            this.txtDischargesBHU.Size = new System.Drawing.Size(68, 20);
            this.txtDischargesBHU.TabIndex = 23;
            // 
            // txtIsoPatientsBHU
            // 
            this.txtIsoPatientsBHU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bHUBindingSource, "numberISP", true));
            this.txtIsoPatientsBHU.Location = new System.Drawing.Point(197, 4);
            this.txtIsoPatientsBHU.Name = "txtIsoPatientsBHU";
            this.txtIsoPatientsBHU.Size = new System.Drawing.Size(61, 20);
            this.txtIsoPatientsBHU.TabIndex = 21;
            // 
            // txtAvailableBedsBHU
            // 
            this.txtAvailableBedsBHU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bHUBindingSource, "availBeds", true));
            this.txtAvailableBedsBHU.Location = new System.Drawing.Point(128, 4);
            this.txtAvailableBedsBHU.Name = "txtAvailableBedsBHU";
            this.txtAvailableBedsBHU.Size = new System.Drawing.Size(62, 20);
            this.txtAvailableBedsBHU.TabIndex = 19;
            // 
            // txtCurrentCensusBHU
            // 
            this.txtCurrentCensusBHU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bHUBindingSource, "currentCensus", true));
            this.txtCurrentCensusBHU.Location = new System.Drawing.Point(65, 4);
            this.txtCurrentCensusBHU.Name = "txtCurrentCensusBHU";
            this.txtCurrentCensusBHU.Size = new System.Drawing.Size(56, 20);
            this.txtCurrentCensusBHU.TabIndex = 17;
            // 
            // lblBHU
            // 
            this.lblBHU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBHU.AutoSize = true;
            this.lblBHU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBHU.Location = new System.Drawing.Point(14, 1);
            this.lblBHU.Name = "lblBHU";
            this.lblBHU.Size = new System.Drawing.Size(33, 1);
            this.lblBHU.TabIndex = 32;
            this.lblBHU.Text = "BHU (T8)";
            this.lblBHU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel8.ColumnCount = 7;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel8.Controls.Add(this.txtCurrentCapStatusTBC, 6, 0);
            this.tableLayoutPanel8.Controls.Add(this.txtNotesTBC, 5, 0);
            this.tableLayoutPanel8.Controls.Add(this.txtDischargesTBC, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.txtIsoPatientsTBC, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.txtAvailableBedsTBC, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.txtCurrentCensusTBC, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.lblTBC, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(12, 316);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(680, 30);
            this.tableLayoutPanel8.TabIndex = 7;
            // 
            // txtCurrentCapStatusTBC
            // 
            this.txtCurrentCapStatusTBC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBCBindingSource, "currentCap", true));
            this.txtCurrentCapStatusTBC.Location = new System.Drawing.Point(550, 4);
            this.txtCurrentCapStatusTBC.Name = "txtCurrentCapStatusTBC";
            this.txtCurrentCapStatusTBC.ReadOnly = true;
            this.txtCurrentCapStatusTBC.Size = new System.Drawing.Size(120, 20);
            this.txtCurrentCapStatusTBC.TabIndex = 27;
            // 
            // tBCBindingSource
            // 
            this.tBCBindingSource.DataMember = "TBC";
            this.tBCBindingSource.DataSource = this.sE265_AJF1130DataSet1;
            // 
            // txtNotesTBC
            // 
            this.txtNotesTBC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBCBindingSource, "notes", true));
            this.txtNotesTBC.Location = new System.Drawing.Point(347, 4);
            this.txtNotesTBC.Name = "txtNotesTBC";
            this.txtNotesTBC.Size = new System.Drawing.Size(195, 20);
            this.txtNotesTBC.TabIndex = 25;
            // 
            // txtDischargesTBC
            // 
            this.txtDischargesTBC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBCBindingSource, "DC", true));
            this.txtDischargesTBC.Location = new System.Drawing.Point(272, 4);
            this.txtDischargesTBC.Name = "txtDischargesTBC";
            this.txtDischargesTBC.Size = new System.Drawing.Size(68, 20);
            this.txtDischargesTBC.TabIndex = 23;
            // 
            // txtIsoPatientsTBC
            // 
            this.txtIsoPatientsTBC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBCBindingSource, "numberISP", true));
            this.txtIsoPatientsTBC.Location = new System.Drawing.Point(203, 4);
            this.txtIsoPatientsTBC.Name = "txtIsoPatientsTBC";
            this.txtIsoPatientsTBC.Size = new System.Drawing.Size(62, 20);
            this.txtIsoPatientsTBC.TabIndex = 21;
            // 
            // txtAvailableBedsTBC
            // 
            this.txtAvailableBedsTBC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBCBindingSource, "availBeds", true));
            this.txtAvailableBedsTBC.Location = new System.Drawing.Point(135, 4);
            this.txtAvailableBedsTBC.Name = "txtAvailableBedsTBC";
            this.txtAvailableBedsTBC.Size = new System.Drawing.Size(61, 20);
            this.txtAvailableBedsTBC.TabIndex = 19;
            // 
            // txtCurrentCensusTBC
            // 
            this.txtCurrentCensusTBC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBCBindingSource, "currentCensus", true));
            this.txtCurrentCensusTBC.Location = new System.Drawing.Point(65, 4);
            this.txtCurrentCensusTBC.Name = "txtCurrentCensusTBC";
            this.txtCurrentCensusTBC.Size = new System.Drawing.Size(63, 20);
            this.txtCurrentCensusTBC.TabIndex = 17;
            // 
            // lblTBC
            // 
            this.lblTBC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTBC.AutoSize = true;
            this.lblTBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTBC.Location = new System.Drawing.Point(15, 2);
            this.lblTBC.Name = "lblTBC";
            this.lblTBC.Size = new System.Drawing.Size(31, 26);
            this.lblTBC.TabIndex = 31;
            this.lblTBC.Text = "TBC (T7)";
            this.lblTBC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t2TableAdapter
            // 
            this.t2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1._6ACUTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BHUTableAdapter = null;
            this.tableAdapterManager1.CensusRecordsTableAdapter = null;
            this.tableAdapterManager1.CensusTableAdapter = null;
            this.tableAdapterManager1.ICUTableAdapter = null;
            this.tableAdapterManager1.PEDITableAdapter = this.pEDITableAdapter;
            this.tableAdapterManager1.T2TableAdapter = this.t2TableAdapter;
            this.tableAdapterManager1.T4TableAdapter = this.t4TableAdapter;
            this.tableAdapterManager1.TBCTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = DailyCensusReport.SE265_AJF1130DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pEDITableAdapter
            // 
            this.pEDITableAdapter.ClearBeforeFill = true;
            // 
            // t4TableAdapter
            // 
            this.t4TableAdapter.ClearBeforeFill = true;
            // 
            // _6ACUTableAdapter
            // 
            this._6ACUTableAdapter.ClearBeforeFill = true;
            // 
            // tBCTableAdapter
            // 
            this.tBCTableAdapter.ClearBeforeFill = true;
            // 
            // bHUTableAdapter
            // 
            this.bHUTableAdapter.ClearBeforeFill = true;
            // 
            // frmDailyCensusReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(712, 471);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.tableLayoutPanel8);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sE265_AJF1130DataSet1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIBindingSource)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._6ACUBindingSource)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t4BindingSource)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bHUBindingSource)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBCBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtDischargesICU;
        private System.Windows.Forms.TextBox txtIsoPatientsICU;
        private System.Windows.Forms.TextBox txtAvailableBedsICU;
        private System.Windows.Forms.TextBox txtCurrentCensusICU;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnViewRecord;
        private System.Windows.Forms.Button btnExit;
        private SE265_AJF1130DataSet sE265_AJF1130DataSet;
        private System.Windows.Forms.BindingSource iCUBindingSource;
        private SE265_AJF1130DataSetTableAdapters.ICUTableAdapter iCUTableAdapter;
        private SE265_AJF1130DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblICU;
        private System.Windows.Forms.TextBox txtCurrentCapStatusICU;
        private System.Windows.Forms.TextBox txtNotesICU;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private SE265_AJF1130DataSet1 sE265_AJF1130DataSet1;
        private System.Windows.Forms.BindingSource t2BindingSource;
        private SE265_AJF1130DataSet1TableAdapters.T2TableAdapter t2TableAdapter;
        private SE265_AJF1130DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.TextBox txtCurrentCapStatusT2;
        private System.Windows.Forms.TextBox txtCurrentCensusT2;
        private System.Windows.Forms.TextBox txtNotesT2;
        private System.Windows.Forms.TextBox txtDischargesT2;
        private System.Windows.Forms.TextBox txtAvailableBedsT2;
        private System.Windows.Forms.TextBox txtIsoPatientsT2;
        private System.Windows.Forms.Label lblPEDI;
        private System.Windows.Forms.Label lbl6ACU;
        private System.Windows.Forms.Label lblT4;
        private System.Windows.Forms.Label lblBHU;
        private System.Windows.Forms.Label lblTBC;
        private SE265_AJF1130DataSet1TableAdapters.PEDITableAdapter pEDITableAdapter;
        private System.Windows.Forms.BindingSource pEDIBindingSource;
        private System.Windows.Forms.TextBox txtCurrentCapStatusPEDI;
        private System.Windows.Forms.TextBox txtDischargesPEDI;
        private System.Windows.Forms.TextBox txtIsoPatientsPEDI;
        private System.Windows.Forms.TextBox txtAvailableBedsPEDI;
        private System.Windows.Forms.TextBox txtCurrentCensusPEDI;
        private SE265_AJF1130DataSet1TableAdapters.T4TableAdapter t4TableAdapter;
        private System.Windows.Forms.BindingSource t4BindingSource;
        private System.Windows.Forms.TextBox txtNotesPEDI;
        private System.Windows.Forms.TextBox txtCurrentCapStatusT4;
        private System.Windows.Forms.TextBox txtNotesT4;
        private System.Windows.Forms.TextBox txtDischargesT4;
        private System.Windows.Forms.TextBox txtIsoPatientsT4;
        private System.Windows.Forms.TextBox txtAvailableBedsT4;
        private System.Windows.Forms.TextBox txtCurrentCensusT4;
        private System.Windows.Forms.BindingSource _6ACUBindingSource;
        private SE265_AJF1130DataSet1TableAdapters._6ACUTableAdapter _6ACUTableAdapter;
        private System.Windows.Forms.TextBox txtCurrentCapStatus6ACU;
        private System.Windows.Forms.TextBox txtNotes6ACU;
        private System.Windows.Forms.TextBox txtDischarges6ACU;
        private System.Windows.Forms.TextBox txtIsoPatients6ACU;
        private System.Windows.Forms.TextBox txtAvailableBeds6ACU;
        private System.Windows.Forms.TextBox txtCurrentCensus6ACU;
        private System.Windows.Forms.BindingSource tBCBindingSource;
        private SE265_AJF1130DataSet1TableAdapters.TBCTableAdapter tBCTableAdapter;
        private System.Windows.Forms.TextBox txtCurrentCapStatusTBC;
        private System.Windows.Forms.TextBox txtNotesTBC;
        private System.Windows.Forms.TextBox txtDischargesTBC;
        private System.Windows.Forms.TextBox txtIsoPatientsTBC;
        private System.Windows.Forms.TextBox txtAvailableBedsTBC;
        private System.Windows.Forms.TextBox txtCurrentCensusTBC;
        private System.Windows.Forms.BindingSource bHUBindingSource;
        private SE265_AJF1130DataSet1TableAdapters.BHUTableAdapter bHUTableAdapter;
        private System.Windows.Forms.TextBox txtCurrentCapStatusBHU;
        private System.Windows.Forms.TextBox txtNotesBHU;
        private System.Windows.Forms.TextBox txtDischargesBHU;
        private System.Windows.Forms.TextBox txtIsoPatientsBHU;
        private System.Windows.Forms.TextBox txtAvailableBedsBHU;
        private System.Windows.Forms.TextBox txtCurrentCensusBHU;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotIsoPatients;
        private System.Windows.Forms.Label lblTotDCs;
        private System.Windows.Forms.Label lblTotAvailBeds;
        private System.Windows.Forms.Label lblTotCurrentCensus;
        private System.Windows.Forms.Label lblTotalCapacity;
    }
}

