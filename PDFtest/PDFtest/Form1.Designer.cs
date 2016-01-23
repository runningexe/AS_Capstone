namespace PDFtest
{
    partial class Form1
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
            this.btnButtonPDF = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // btnButtonPDF
            // 
            this.btnButtonPDF.Location = new System.Drawing.Point(69, 74);
            this.btnButtonPDF.Name = "btnButtonPDF";
            this.btnButtonPDF.Size = new System.Drawing.Size(75, 23);
            this.btnButtonPDF.TabIndex = 0;
            this.btnButtonPDF.Text = "Create PDF";
            this.btnButtonPDF.UseVisualStyleBackColor = true;
            this.btnButtonPDF.Click += new System.EventHandler(this.btnButtonPDF_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(69, 24);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(100, 20);
            this.txtInfo.TabIndex = 1;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(69, 144);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(75, 23);
            this.mail.TabIndex = 2;
            this.mail.Text = "button1";
            this.mail.UseVisualStyleBackColor = true;

            /*************************************************************************
            THIS IS COMMENTED SO THAT THE PROGRAM WILL RUN CORRECTLY. IN ORDER FOR IT TO DO SO
            BOTH THIS LINE AND THE main_Click EVENT CODE NEEDS TO BE COMMENTED OUT*

            //this.mail.Click += new System.EventHandler(this.mail_Click);
            **************************************************************************/


            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 238);

            this.Controls.Add(this.mail);

            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnButtonPDF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnButtonPDF;
        private System.Windows.Forms.TextBox txtInfo;

        private System.Windows.Forms.Button mail;

    }
}

