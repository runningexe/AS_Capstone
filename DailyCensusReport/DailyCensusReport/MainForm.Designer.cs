namespace DailyCensusReport
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.btnMainViewRecord = new System.Windows.Forms.Button();
            this.btnMainAddRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMainViewRecord
            // 
            this.btnMainViewRecord.Location = new System.Drawing.Point(189, 172);
            this.btnMainViewRecord.Name = "btnMainViewRecord";
            this.btnMainViewRecord.Size = new System.Drawing.Size(171, 43);
            this.btnMainViewRecord.TabIndex = 0;
            this.btnMainViewRecord.Text = "View Record(s)";
            this.btnMainViewRecord.UseVisualStyleBackColor = true;
            this.btnMainViewRecord.Click += new System.EventHandler(this.btnMainViewRecord_Click);
            // 
            // btnMainAddRecord
            // 
            this.btnMainAddRecord.Location = new System.Drawing.Point(12, 172);
            this.btnMainAddRecord.Name = "btnMainAddRecord";
            this.btnMainAddRecord.Size = new System.Drawing.Size(171, 43);
            this.btnMainAddRecord.TabIndex = 1;
            this.btnMainAddRecord.Text = "Add Record(s)";
            this.btnMainAddRecord.UseVisualStyleBackColor = true;
            this.btnMainAddRecord.Click += new System.EventHandler(this.btnMainAddRecord_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(370, 227);
            this.Controls.Add(this.btnMainAddRecord);
            this.Controls.Add(this.btnMainViewRecord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Census Report";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMainViewRecord;
        private System.Windows.Forms.Button btnMainAddRecord;
    }
}