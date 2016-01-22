using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            sfd.InitialDirectory = @"C:\Users\Anthony J. Fiori\Desktop";

        //pops up the dialog box to actually save
            if (sfd.ShowDialog() == DialogResult.OK)
            { 
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
            //pushes out notification when PDF is created
            MessageBox.Show("PDF Created");
            doc.Open();//Open Document to write
            //write some content
            Paragraph paragraph = new Paragraph(txtInfo.Text +" "+ "This is my firest line using paragraph. ");
            //now add the above created text using different class object to our pdf document
            doc.Add(paragraph);
            doc.Close();//close document
            }
        }
    }
}
