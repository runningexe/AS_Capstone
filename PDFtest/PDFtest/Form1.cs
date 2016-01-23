using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using Outlook = Microsoft.Office.Interop.Outlook;
=======

>>>>>>> 935662b1edfe0617974f56ad6cc9d2383e14828f
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
//using System.Reflection;



namespace PDFtest
{
    public partial class Form1 : Form
    {
        SaveFileDialog sfd = new SaveFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnButtonPDF_Click(object sender, EventArgs e)
        {
        //path to save to your desktop
            sfd.Title = "Save As PDF";
            sfd.Filter = "PDF|.PDF";
<<<<<<< HEAD
            sfd.InitialDirectory = @"C:\Users\RunningEXE\Desktop";
=======
            sfd.InitialDirectory = @"C:\Users\Anthony J. Fiori\Desktop";
>>>>>>> 935662b1edfe0617974f56ad6cc9d2383e14828f

        //pops up the dialog box to actually save
            if (sfd.ShowDialog() == DialogResult.OK)
            { 
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
            //pushes out notification when PDF is created
<<<<<<< HEAD
            MessageBox.Show("PDF Saved to " + wri);
=======
            MessageBox.Show("PDF Created");
>>>>>>> 935662b1edfe0617974f56ad6cc9d2383e14828f
            doc.Open();//Open Document to write
            //write some content
            Paragraph paragraph = new Paragraph(txtInfo.Text +" "+ "This is my firest line using paragraph. ");
            //now add the above created text using different class object to our pdf document
            doc.Add(paragraph);
            doc.Close();//close document
            }
        }
<<<<<<< HEAD

        /*private void mail_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> lstAllRecipients = new List<string>();

                *******************************************************************************************
                You can either hard-code the e-mails into the recipients Add function, or grab e-mails from
                a database. I figured we could maybe hard-code them in? since idk how we'd get their e-mails through
                a database. It would take us a bit more time, but it would be sort of neat to have all of the e-mails already
                in there and ready to go.
                ******************************************************************************************
                lstAllRecipients.Add("");
                lstAllRecipients.Add("");

                Outlook.Application outlookApp = new Outlook.Application();
                Outlook._MailItem oMailItem = (Outlook._MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
                Outlook.Inspector oInspector = oMailItem.GetInspector;
                // Thread.Sleep(10000);

                //Recipient
                Outlook.Recipients oRecips = (Outlook.Recipients)oMailItem.Recipients;
                foreach (String recipient in lstAllRecipients)
                {
                    Outlook.Recipient oRecip = (Outlook.Recipient)oRecips.Add(recipient);
                    oRecip.Resolve();
                }

                //Add CC
                Outlook.Recipient oCCRecip = oRecips.Add("");
                oCCRecip.Type = (int)Outlook.OlMailRecipientType.olCC;
                oCCRecip.Resolve();

                //Add Subject
                oMailItem.Subject = "";

                // body, bcc etc...

                //Display the mailbox
                oMailItem.Display(true);
            }
            catch (Exception objEx)
            {
                MessageBox.Show(objEx.ToString(),"");
            }
        }*/
=======
>>>>>>> 935662b1edfe0617974f56ad6cc9d2383e14828f
    }
}
