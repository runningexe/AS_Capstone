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
            this.txtCCSICU = new System.Windows.Forms.TextBox();
            this.txtICUDC = new System.Windows.Forms.TextBox();
            this.txtISOICU = new System.Windows.Forms.TextBox();
            this.txtABICU = new System.Windows.Forms.TextBox();
            this.txtCCICU = new System.Windows.Forms.TextBox();
            this.rtbICUNotes = new System.Windows.Forms.RichTextBox();
            this.lblICU = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnViewRecord = new System.Windows.Forms.Button();
            this.tlpHeaders.SuspendLayout();
            this.tlpICU.SuspendLayout();
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
            this.tlpHeaders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
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
            this.lblCurrentStatus.Location = new System.Drawing.Point(569, 2);
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
            this.lblNotes.Location = new System.Drawing.Point(438, 9);
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
            this.lblPotentialDCs.Location = new System.Drawing.Point(290, 2);
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
            this.lblIsolationPts.Location = new System.Drawing.Point(219, 1);
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
            this.lblAvailBeds.Location = new System.Drawing.Point(159, 2);
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
            this.lblCurrentCensus.Location = new System.Drawing.Point(85, 2);
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
            this.lblUnit.Location = new System.Drawing.Point(19, 9);
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
            this.tlpICU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.64238F));
            this.tlpICU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.35762F));
            this.tlpICU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlpICU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tlpICU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tlpICU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tlpICU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tlpICU.Controls.Add(this.txtCCSICU, 6, 0);
            this.tlpICU.Controls.Add(this.txtICUDC, 4, 0);
            this.tlpICU.Controls.Add(this.txtISOICU, 3, 0);
            this.tlpICU.Controls.Add(this.txtABICU, 2, 0);
            this.tlpICU.Controls.Add(this.txtCCICU, 1, 0);
            this.tlpICU.Controls.Add(this.rtbICUNotes, 5, 0);
            this.tlpICU.Controls.Add(this.lblICU, 0, 0);
            this.tlpICU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tlpICU.Location = new System.Drawing.Point(12, 125);
            this.tlpICU.Name = "tlpICU";
            this.tlpICU.RowCount = 1;
            this.tlpICU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpICU.Size = new System.Drawing.Size(680, 29);
            this.tlpICU.TabIndex = 1;
            // 
            // txtCCSICU
            // 
            this.txtCCSICU.Location = new System.Drawing.Point(555, 4);
            this.txtCCSICU.Name = "txtCCSICU";
            this.txtCCSICU.Size = new System.Drawing.Size(105, 20);
            this.txtCCSICU.TabIndex = 6;
            // 
            // txtICUDC
            // 
            this.txtICUDC.Location = new System.Drawing.Point(278, 4);
            this.txtICUDC.Name = "txtICUDC";
            this.txtICUDC.Size = new System.Drawing.Size(67, 20);
            this.txtICUDC.TabIndex = 4;
            // 
            // txtISOICU
            // 
            this.txtISOICU.Location = new System.Drawing.Point(208, 4);
            this.txtISOICU.Name = "txtISOICU";
            this.txtISOICU.Size = new System.Drawing.Size(63, 20);
            this.txtISOICU.TabIndex = 3;
            // 
            // txtABICU
            // 
            this.txtABICU.Location = new System.Drawing.Point(139, 4);
            this.txtABICU.Name = "txtABICU";
            this.txtABICU.Size = new System.Drawing.Size(62, 20);
            this.txtABICU.TabIndex = 2;
            // 
            // txtCCICU
            // 
            this.txtCCICU.Location = new System.Drawing.Point(76, 4);
            this.txtCCICU.Name = "txtCCICU";
            this.txtCCICU.Size = new System.Drawing.Size(56, 20);
            this.txtCCICU.TabIndex = 0;
            // 
            // rtbICUNotes
            // 
            this.rtbICUNotes.Location = new System.Drawing.Point(352, 4);
            this.rtbICUNotes.Name = "rtbICUNotes";
            this.rtbICUNotes.Size = new System.Drawing.Size(196, 21);
            this.rtbICUNotes.TabIndex = 7;
            this.rtbICUNotes.Text = "";
            // 
            // lblICU
            // 
            this.lblICU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblICU.AutoSize = true;
            this.lblICU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICU.Location = new System.Drawing.Point(22, 8);
            this.lblICU.Name = "lblICU";
            this.lblICU.Size = new System.Drawing.Size(28, 13);
            this.lblICU.TabIndex = 8;
            this.lblICU.Text = "ICU";
            this.lblICU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnSubmit.Size = new System.Drawing.Size(213, 40);
            this.btnSubmit.TabIndex = 2;
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
            this.btnViewRecord.Location = new System.Drawing.Point(266, 305);
            this.btnViewRecord.Name = "btnViewRecord";
            this.btnViewRecord.Size = new System.Drawing.Size(213, 40);
            this.btnViewRecord.TabIndex = 3;
            this.btnViewRecord.Text = "View Records";
            this.btnViewRecord.UseVisualStyleBackColor = true;
            this.btnViewRecord.Click += new System.EventHandler(this.btnViewRecord_Click);
            // 
            // frmDailyCensusReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(712, 357);
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
            this.tlpHeaders.ResumeLayout(false);
            this.tlpHeaders.PerformLayout();
            this.tlpICU.ResumeLayout(false);
            this.tlpICU.PerformLayout();
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
        private System.Windows.Forms.TextBox txtCCSICU;
        private System.Windows.Forms.TextBox txtICUDC;
        private System.Windows.Forms.TextBox txtISOICU;
        private System.Windows.Forms.TextBox txtABICU;
        private System.Windows.Forms.TextBox txtCCICU;
        private System.Windows.Forms.RichTextBox rtbICUNotes;
        private System.Windows.Forms.Label lblICU;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnViewRecord;
    }
}

