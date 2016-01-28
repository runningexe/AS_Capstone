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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            this.tlpHeaders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
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
            this.tlpHeaders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHeaders.Size = new System.Drawing.Size(680, 31);
            this.tlpHeaders.TabIndex = 0;
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStatus.Location = new System.Drawing.Point(573, 2);
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
            this.lblNotes.Location = new System.Drawing.Point(446, 9);
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
            this.lblPotentialDCs.Location = new System.Drawing.Point(298, 2);
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
            this.lblIsolationPts.Location = new System.Drawing.Point(227, 1);
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
            this.lblAvailBeds.Location = new System.Drawing.Point(167, 2);
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
            this.lblCurrentCensus.Location = new System.Drawing.Point(93, 2);
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
            this.lblUnit.Location = new System.Drawing.Point(23, 9);
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
            this.tlpICU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpICU.Controls.Add(this.textBox7, 6, 0);
            this.tlpICU.Controls.Add(this.textBox5, 4, 0);
            this.tlpICU.Controls.Add(this.textBox4, 3, 0);
            this.tlpICU.Controls.Add(this.textBox3, 2, 0);
            this.tlpICU.Controls.Add(this.textBox1, 1, 0);
            this.tlpICU.Controls.Add(this.richTextBox1, 5, 0);
            this.tlpICU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tlpICU.Location = new System.Drawing.Point(12, 125);
            this.tlpICU.Name = "tlpICU";
            this.tlpICU.RowCount = 1;
            this.tlpICU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpICU.Size = new System.Drawing.Size(680, 29);
            this.tlpICU.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(155, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(62, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(224, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(63, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(294, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(67, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(571, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(105, 20);
            this.textBox7.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(368, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(196, 21);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // frmDailyCensusReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 360);
            this.Controls.Add(this.tlpICU);
            this.Controls.Add(this.tlpHeaders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDailyCensusReport";
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
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

