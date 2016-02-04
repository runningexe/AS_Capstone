using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Outlook = Microsoft.Office.Interop.Outlook;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
//using System.Reflection;

namespace DailyCensusReport
{
    public partial class frmDailyCensusReport : Form
    {
        SaveFileDialog sfd = new SaveFileDialog();

        public frmDailyCensusReport()
        {
            InitializeComponent();
        }

        private void frmDailyCensusReport_Load(object sender, EventArgs e)
        {
         
        }

/*Submit's entered Data into database
 Calculates Current Census & Avail Beds to determine Capactiy Status color
 Prints entered data into a PDF and saves to Desktop*/
        private void btnSubmit_Click(object sender, EventArgs e)
        {

//Submits into database
            int unitID = 1;
            string currentCensus = Convert.ToString(txtCCICU.Text);
            string availBeds = Convert.ToString(txtABICU.Text);
            string numOfIsoPatients = Convert.ToString(txtISOICU.Text);
            string potentialDCs = Convert.ToString(txtICUDC.Text);
            string notes = Convert.ToString(rtbICUNotes.Text);
            string currentCapStat = Convert.ToString(txtCCSICU.Text);

            //SubmitRecord sr = new SubmitRecord();
            SubmitRecord.AddRecord(unitID,currentCensus, availBeds, numOfIsoPatients, potentialDCs, notes, currentCapStat);

//To save PDF to desktop
//path to save to your desktop
            sfd.Title = "Save As PDF";
            sfd.Filter = "PDF|.PDF";
            sfd.InitialDirectory = @"C:\Users\RunningEXE\Desktop";

            sfd.InitialDirectory = @"C:\Users\Anthony J. Fiori\Desktop";


//pops up the dialog box to actually save
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
//pushes out notification when PDF is created
                MessageBox.Show("PDF Has Been Saved To Desktop", "PDF Notification");
//Open Document to write
                doc.Open();

//PDF Table Header
            PdfPTable table1 = new PdfPTable(7);

//One row added
            PdfPCell cell21 = new PdfPCell();
            cell21.AddElement(new Paragraph("Unit"));

            PdfPCell cell22 = new PdfPCell();
            cell22.AddElement(new Paragraph("Current Census"));
            
            PdfPCell cell23 = new PdfPCell();
            cell23.AddElement(new Paragraph("Avail Beds"));

            PdfPCell cell24 = new PdfPCell();
            cell24.AddElement(new Paragraph("# of Isolation Pts."));

            PdfPCell cell25 = new PdfPCell();
            cell25.AddElement(new Paragraph("Potential D/C's"));

            PdfPCell cell26 = new PdfPCell();
            cell26.AddElement(new Paragraph("Notes"));

            PdfPCell cell27 = new PdfPCell();
            cell27.AddElement(new Paragraph("Current Capcity Status"));

            table1.AddCell(cell21);
            table1.AddCell(cell22);
            table1.AddCell(cell23);

            table1.AddCell(cell24);
            table1.AddCell(cell25);
            table1.AddCell(cell26);
            table1.AddCell(cell27);

/////////////////////////////////////////////////////////////////
//ICU Data
            PdfPCell cell28 = new PdfPCell();
            cell28.AddElement(new Paragraph("ICU"));
            
            PdfPCell cell29 = new PdfPCell();
            cell29.AddElement(new Paragraph(txtCCICU.Text));

            PdfPCell cell30 = new PdfPCell();
            cell30.AddElement(new Paragraph(txtABICU.Text));
            

            table1.AddCell(cell28);
            table1.AddCell(cell29);
            table1.AddCell(cell30);


//New Row Added
            PdfPCell cell41 = new PdfPCell();
            cell41.AddElement(new Paragraph(txtISOICU.Text));
            
            PdfPCell cell42 = new PdfPCell();
            cell42.AddElement(new Paragraph(txtICUDC.Text));
            

            PdfPCell cell43 = new PdfPCell();
            cell43.AddElement(new Paragraph(rtbICUNotes.Text));
            

            table1.AddCell(cell41);
            table1.AddCell(cell42);
            table1.AddCell(cell43);

//New Row Added
            PdfPCell cell44 = new PdfPCell();
            cell44.AddElement(new Paragraph(txtCCSICU.Text));
            

            table1.AddCell(cell44);

///////////////////////////////////////////////
//T2 Data

            PdfPCell cell45 = new PdfPCell();
            cell45.AddElement(new Paragraph("T2 M/S"));
            

            PdfPCell cell46 = new PdfPCell();
            cell46.AddElement(new Paragraph(txtCCICU.Text));
            

            PdfPCell cell47 = new PdfPCell();
            cell47.AddElement(new Paragraph(txtABICU.Text));
            

            table1.AddCell(cell45);
            table1.AddCell(cell46);
            table1.AddCell(cell47);


//New Row Added
            PdfPCell cell48 = new PdfPCell();
            cell48.AddElement(new Paragraph(txtISOICU.Text));
           
            PdfPCell cell49 = new PdfPCell();
            cell49.AddElement(new Paragraph(txtICUDC.Text));
            
            PdfPCell cell50 = new PdfPCell();
            cell50.AddElement(new Paragraph(rtbICUNotes.Text));
            

            table1.AddCell(cell48);
            table1.AddCell(cell49);
            table1.AddCell(cell50);

//New Row Added
            PdfPCell cell51 = new PdfPCell();
            cell51.AddElement(new Paragraph(txtCCSICU.Text));
            

            table1.AddCell(cell51);

/////////////////////////////////////////////////////////
//PEDI Data

            PdfPCell cell52 = new PdfPCell();
            cell52.AddElement(new Paragraph("PEDI"));
           

            PdfPCell cell53 = new PdfPCell();
            cell53.AddElement(new Paragraph(txtCCICU.Text));

            PdfPCell cell54 = new PdfPCell();
            cell54.AddElement(new Paragraph(txtABICU.Text));
            

            table1.AddCell(cell52);
            table1.AddCell(cell53);
            table1.AddCell(cell54);


//New Row Added
            PdfPCell cell55 = new PdfPCell();
            cell55.AddElement(new Paragraph(txtISOICU.Text));
           


            PdfPCell cell56 = new PdfPCell();
            cell56.AddElement(new Paragraph(txtICUDC.Text));
            


            PdfPCell cell57 = new PdfPCell();
            cell57.AddElement(new Paragraph(rtbICUNotes.Text));
           

            table1.AddCell(cell55);
            table1.AddCell(cell56);
            table1.AddCell(cell57);

            //New Row Added
            PdfPCell cell58 = new PdfPCell();
            cell58.AddElement(new Paragraph(txtCCSICU.Text));
            

            table1.AddCell(cell58);
/////////////////////////////////////////////////////
//T4 M/S Data

            PdfPCell cell59 = new PdfPCell();
            cell59.AddElement(new Paragraph("T4 M/S"));
            


            PdfPCell cell60 = new PdfPCell();
            cell60.AddElement(new Paragraph(txtCCICU.Text));
            


            PdfPCell cell61 = new PdfPCell();
            cell61.AddElement(new Paragraph(txtABICU.Text));
            

            table1.AddCell(cell59);
            table1.AddCell(cell60);
            table1.AddCell(cell61);


//New Row Added
            PdfPCell cell62 = new PdfPCell();
            cell62.AddElement(new Paragraph(txtISOICU.Text));
            


            PdfPCell cell63 = new PdfPCell();
            cell63.AddElement(new Paragraph(txtICUDC.Text));
         


            PdfPCell cell64 = new PdfPCell();
            cell64.AddElement(new Paragraph(rtbICUNotes.Text));
            

            table1.AddCell(cell62);
            table1.AddCell(cell63);
            table1.AddCell(cell64);

//New Row Added
            PdfPCell cell65 = new PdfPCell();
            cell65.AddElement(new Paragraph(txtCCSICU.Text));
       
            table1.AddCell(cell65);
//////////////////////////////////////////////
//6ACU Data

            PdfPCell cell66 = new PdfPCell();
            cell66.AddElement(new Paragraph("6ACU"));


            PdfPCell cell67 = new PdfPCell();
            cell67.AddElement(new Paragraph(txtCCICU.Text));


            PdfPCell cell68 = new PdfPCell();
            cell68.AddElement(new Paragraph(txtABICU.Text));


            table1.AddCell(cell66);
            table1.AddCell(cell67);
            table1.AddCell(cell68);


//New Row Added
            PdfPCell cell69 = new PdfPCell();
            cell69.AddElement(new Paragraph(txtISOICU.Text));

            PdfPCell cell70 = new PdfPCell();
            cell70.AddElement(new Paragraph(txtICUDC.Text));

            PdfPCell cell71 = new PdfPCell();
            cell71.AddElement(new Paragraph(rtbICUNotes.Text));

            table1.AddCell(cell69);
            table1.AddCell(cell70);
            table1.AddCell(cell71);

//New Row Added
            PdfPCell cell72 = new PdfPCell();
            cell72.AddElement(new Paragraph(txtCCSICU.Text));

            table1.AddCell(cell72);
//////////////////////////////////////////////
//TBC(T7) Data

            PdfPCell cell73 = new PdfPCell();
            cell73.AddElement(new Paragraph("TBC(T7)"));


            PdfPCell cell74 = new PdfPCell();
            cell74.AddElement(new Paragraph(txtCCICU.Text));


            PdfPCell cell75 = new PdfPCell();
            cell75.AddElement(new Paragraph(txtABICU.Text));


            table1.AddCell(cell73);
            table1.AddCell(cell74);
            table1.AddCell(cell75);


//New Row Added
            PdfPCell cell76 = new PdfPCell();
            cell76.AddElement(new Paragraph(txtISOICU.Text));

            PdfPCell cell77 = new PdfPCell();
            cell77.AddElement(new Paragraph(txtICUDC.Text));

            PdfPCell cell78 = new PdfPCell();
            cell78.AddElement(new Paragraph(rtbICUNotes.Text));

            table1.AddCell(cell76);
            table1.AddCell(cell77);
            table1.AddCell(cell78);

//New Row Added
            PdfPCell cell79 = new PdfPCell();
            cell79.AddElement(new Paragraph(txtCCSICU.Text));

            table1.AddCell(cell79);

//////////////////////////////////////////////
//BHU Data

            PdfPCell cell80 = new PdfPCell();
            cell80.AddElement(new Paragraph("BHU"));


            PdfPCell cell81 = new PdfPCell();
            cell81.AddElement(new Paragraph(txtCCICU.Text));


            PdfPCell cell82 = new PdfPCell();
            cell82.AddElement(new Paragraph(txtABICU.Text));


            table1.AddCell(cell80);
            table1.AddCell(cell81);
            table1.AddCell(cell82);


//New Row Added
            PdfPCell cell83 = new PdfPCell();
            cell83.AddElement(new Paragraph(txtISOICU.Text));

            PdfPCell cell84 = new PdfPCell();
            cell84.AddElement(new Paragraph(txtICUDC.Text));

            PdfPCell cell85 = new PdfPCell();
            cell85.AddElement(new Paragraph(rtbICUNotes.Text));

            table1.AddCell(cell83);
            table1.AddCell(cell84);
            table1.AddCell(cell85);

//New Row Added
            PdfPCell cell86 = new PdfPCell();
            cell86.AddElement(new Paragraph(txtCCSICU.Text));

            table1.AddCell(cell86);

//////////////////////////////////////////////
//Total Census Data

            PdfPCell cell87 = new PdfPCell();
            cell87.AddElement(new Paragraph("TOTAL"));


            PdfPCell cell88 = new PdfPCell();
            cell88.AddElement(new Paragraph(txtCCICU.Text));


            PdfPCell cell89 = new PdfPCell();
            cell89.AddElement(new Paragraph(txtABICU.Text));


            table1.AddCell(cell87);
            table1.AddCell(cell88);
            table1.AddCell(cell89);


//New Row Added
            PdfPCell cell90 = new PdfPCell();
            cell90.AddElement(new Paragraph(txtISOICU.Text));

            PdfPCell cell91 = new PdfPCell();
            cell91.AddElement(new Paragraph(txtICUDC.Text));

            PdfPCell cell92 = new PdfPCell();
            cell92.AddElement(new Paragraph(rtbICUNotes.Text));

            table1.AddCell(cell90);
            table1.AddCell(cell91);
            table1.AddCell(cell92);

//New Row Added
            PdfPCell cell93 = new PdfPCell();
            cell93.AddElement(new Paragraph(txtCCSICU.Text));

            table1.AddCell(cell93);

//Adds data to table
            doc.Add(table1);

//close document
                doc.Close();
            }
           
        }
//Redirects to the ViewRecord Form
        private void btnViewRecord_Click(object sender, EventArgs e)
        {
            this.Show();
            ViewRecordsForm openVR = new ViewRecordsForm();
            openVR.Show(); 
        }

//Closes Program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
