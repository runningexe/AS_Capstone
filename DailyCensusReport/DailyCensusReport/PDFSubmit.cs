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

namespace DailyCensusReport
{
    public class PDFSubmit
    {
        public static bool PDFView(TextBox textBox)
        {
            

            if (textBox.Text != "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                //To save PDF to desktop
                //path to save to your desktop
                sfd.Title = "Save As PDF";
                sfd.Filter = "PDF|.PDF";
                sfd.InitialDirectory = @"C:\Users\RunningEXE\Desktop";

                sfd.InitialDirectory = @"C:\Users\Anthony J. Fiori\Desktop";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                    PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    //pushes out notification when PDF is created
                    MessageBox.Show("PDF Has Been Saved!", "Saved");
                    //Open Document to write
                    doc.Open();

                    //PDF Table Header
                    PdfPTable pdfTable = new PdfPTable(7);

                    #region Header Row
                    /*********************Header Row*********************/
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

                    pdfTable.AddCell(cell21);
                    pdfTable.AddCell(cell22);
                    pdfTable.AddCell(cell23);
                    #endregion

                    #region ICU Row
                    /*********************ICU Data*********************/
                    PdfPCell cell28 = new PdfPCell();
                    cell28.AddElement(new Paragraph("ICU"));

                    PdfPCell cell29 = new PdfPCell();
                    cell29.AddElement(new Paragraph(textBox.Text));

                    PdfPCell cell30 = new PdfPCell();
                    cell30.AddElement(new Paragraph(textBox.Text));

                    pdfTable.AddCell(cell28);
                    pdfTable.AddCell(cell29);
                    pdfTable.AddCell(cell30);
                    /*************************************************/

                    /*******************Creates Row*******************/
                    PdfPCell cell41 = new PdfPCell();
                    cell41.AddElement(new Paragraph(textBox.Text));

                    PdfPCell cell42 = new PdfPCell();
                    cell42.AddElement(new Paragraph(textBox.Text));


                    PdfPCell cell43 = new PdfPCell();
                    cell43.AddElement(new Paragraph(textBox.Text));


                    pdfTable.AddCell(cell41);
                    pdfTable.AddCell(cell42);
                    pdfTable.AddCell(cell43);
                    /*************************************************/
                    

                    /****Dynamically changing PDF/Textbox colors.****/

                    /*
                     *NOTE:
                     *This may not be possible to do in a class. It will
                     *always change the Current Census textbox's color because
                     *textBox.Text is a general control entity. Currently figuring
                     *out a way to stop that.
                     */

                    int icuCurrentCensus = Convert.ToInt32(textBox.Text);

                    if (icuCurrentCensus <= 5)
                    {
                        //ICU Row Added
                        PdfPCell cell44 = new PdfPCell();
                        cell44.AddElement(new Paragraph(textBox.Text));
                        cell44.BackgroundColor = BaseColor.GREEN;

                        pdfTable.AddCell(cell44);
                    }

                    else if (icuCurrentCensus > 7)
                    {

                        //ICU Row Added
                        PdfPCell cell44 = new PdfPCell();
                        cell44.AddElement(new Paragraph(textBox.Text));
                        cell44.BackgroundColor = BaseColor.RED;

                        pdfTable.AddCell(cell44);

                    }
                    /*************************************************/
                    #endregion

                    #region T2 Row
                    /*********************T2 Data*********************/
                    PdfPCell cell45 = new PdfPCell();
                    cell45.AddElement(new Paragraph("T2 M/S"));


                    PdfPCell cell46 = new PdfPCell();
                    cell46.AddElement(new Paragraph(textBox.Text));


                    PdfPCell cell47 = new PdfPCell();
                    cell47.AddElement(new Paragraph(textBox.Text));

                    pdfTable.AddCell(cell45);
                    pdfTable.AddCell(cell46);
                    pdfTable.AddCell(cell47);
                    /*************************************************/

                    /*******************Creates Row*******************/
                    PdfPCell cell48 = new PdfPCell();
                    cell48.AddElement(new Paragraph(textBox.Text));

                    PdfPCell cell49 = new PdfPCell();
                    cell49.AddElement(new Paragraph(textBox.Text));

                    PdfPCell cell50 = new PdfPCell();
                    cell50.AddElement(new Paragraph(textBox.Text));


                    pdfTable.AddCell(cell48);
                    pdfTable.AddCell(cell49);
                    pdfTable.AddCell(cell50);
                    /*************************************************/
#endregion

                    //New Row Added
                    PdfPCell cell51 = new PdfPCell();
                    cell51.AddElement(new Paragraph(textBox.Text));

                    pdfTable.AddCell(cell51);
                    

                    /////////////////////////////////////////////////////////
                    //PEDI Data

                    PdfPCell cell52 = new PdfPCell();
                    cell52.AddElement(new Paragraph("PEDI"));


                    PdfPCell cell53 = new PdfPCell();
                    cell53.AddElement(new Paragraph(textBox.Text));

                    PdfPCell cell54 = new PdfPCell();
                    cell54.AddElement(new Paragraph(textBox.Text));


                    pdfTable.AddCell(cell52);
                    pdfTable.AddCell(cell53);
                    pdfTable.AddCell(cell54);


                    //New Row Added
                    PdfPCell cell55 = new PdfPCell();
                    cell55.AddElement(new Paragraph(textBox.Text));



                    PdfPCell cell56 = new PdfPCell();
                    cell56.AddElement(new Paragraph(textBox.Text));



                    PdfPCell cell57 = new PdfPCell();
                    cell57.AddElement(new Paragraph(textBox.Text));


                    pdfTable.AddCell(cell55);
                    pdfTable.AddCell(cell56);
                    pdfTable.AddCell(cell57);

                    //New Row Added
                    PdfPCell cell58 = new PdfPCell();
                    cell58.AddElement(new Paragraph(textBox.Text));


                    pdfTable.AddCell(cell58);
                    /////////////////////////////////////////////////////
                    //T4 M/S Data

                    PdfPCell cell59 = new PdfPCell();
                    cell59.AddElement(new Paragraph("T4 M/S"));



                    PdfPCell cell60 = new PdfPCell();
                    cell60.AddElement(new Paragraph(textBox.Text));



                    PdfPCell cell61 = new PdfPCell();
                    cell61.AddElement(new Paragraph(textBox.Text));


                    pdfTable.AddCell(cell59);
                    pdfTable.AddCell(cell60);
                    pdfTable.AddCell(cell61);


                    //New Row Added
                    PdfPCell cell62 = new PdfPCell();
                    cell62.AddElement(new Paragraph(textBox.Text));



                    PdfPCell cell63 = new PdfPCell();
                    cell63.AddElement(new Paragraph(textBox.Text));



                    PdfPCell cell64 = new PdfPCell();
                    cell64.AddElement(new Paragraph(textBox.Text));


                    pdfTable.AddCell(cell62);
                    pdfTable.AddCell(cell63);
                    pdfTable.AddCell(cell64);

                    //New Row Added
                    PdfPCell cell65 = new PdfPCell();
                    cell65.AddElement(new Paragraph(textBox.Text));

                    pdfTable.AddCell(cell65);
                    //////////////////////////////////////////////
                    //6ACU Data

                    PdfPCell cell66 = new PdfPCell();
                    cell66.AddElement(new Paragraph("6ACU"));


                    PdfPCell cell67 = new PdfPCell();
                    cell67.AddElement(new Paragraph(textBox.Text));


                    PdfPCell cell68 = new PdfPCell();
                    cell68.AddElement(new Paragraph(textBox.Text));


                    pdfTable.AddCell(cell66);
                    pdfTable.AddCell(cell67);
                    pdfTable.AddCell(cell68);


                    //New Row Added
                    PdfPCell cell69 = new PdfPCell();
                    cell69.AddElement(new Paragraph(textBox.Text));

                    PdfPCell cell70 = new PdfPCell();
                    cell70.AddElement(new Paragraph(textBox.Text));

                    PdfPCell cell71 = new PdfPCell();
                    cell71.AddElement(new Paragraph(textBox.Text));

                    pdfTable.AddCell(cell69);
                    pdfTable.AddCell(cell70);
                    pdfTable.AddCell(cell71);

                    //New Row Added
                    PdfPCell cell72 = new PdfPCell();
                    cell72.AddElement(new Paragraph(textBox.Text));

                    pdfTable.AddCell(cell72);
                    //////////////////////////////////////////////
                    //TBC(T7) Data

                    PdfPCell cell73 = new PdfPCell();
                    cell73.AddElement(new Paragraph("TBC(T7)"));


                    PdfPCell cell74 = new PdfPCell();
                    cell74.AddElement(new Paragraph(textBox.Text));


                    PdfPCell cell75 = new PdfPCell();
                    cell75.AddElement(new Paragraph(textBox.Text));


                    pdfTable.AddCell(cell73);
                    pdfTable.AddCell(cell74);
                    pdfTable.AddCell(cell75);


                    //New Row Added
                    PdfPCell cell76 = new PdfPCell();
                    cell76.AddElement(new Paragraph(textBox.Text));

                    PdfPCell cell77 = new PdfPCell();
                    cell77.AddElement(new Paragraph(textBox.Text));

                    PdfPCell cell78 = new PdfPCell();
                    cell78.AddElement(new Paragraph(textBox.Text));

                    pdfTable.AddCell(cell76);
                    pdfTable.AddCell(cell77);
                    pdfTable.AddCell(cell78);

                    //New Row Added
                    PdfPCell cell79 = new PdfPCell();
                    cell79.AddElement(new Paragraph(textBox.Text));

                    pdfTable.AddCell(cell79);

                    //////////////////////////////////////////////
                    //BHU Data

                    PdfPCell cell80 = new PdfPCell();
                    cell80.AddElement(new Paragraph("BHU"));


                    PdfPCell cell81 = new PdfPCell();
                    cell81.AddElement(new Paragraph(textBox.Text));


                    PdfPCell cell82 = new PdfPCell();
                    cell82.AddElement(new Paragraph(textBox.Text));


                    pdfTable.AddCell(cell80);
                    pdfTable.AddCell(cell81);
                    pdfTable.AddCell(cell82);


                    //New Row Added
                    PdfPCell cell83 = new PdfPCell();
                    cell83.AddElement(new Paragraph(textBox.Text));

                    PdfPCell cell84 = new PdfPCell();
                    cell84.AddElement(new Paragraph(textBox.Text));

                    PdfPCell cell85 = new PdfPCell();
                    cell85.AddElement(new Paragraph(textBox.Text));

                    pdfTable.AddCell(cell83);
                    pdfTable.AddCell(cell84);
                    pdfTable.AddCell(cell85);

                    //New Row Added
                    PdfPCell cell86 = new PdfPCell();
                    cell86.AddElement(new Paragraph(textBox.Text));

                    pdfTable.AddCell(cell86);

                    //////////////////////////////////////////////
                    //Total Census Data

                    PdfPCell cell87 = new PdfPCell();
                    cell87.AddElement(new Paragraph("TOTAL"));
                    cell87.BackgroundColor = BaseColor.LIGHT_GRAY;


                    PdfPCell cell88 = new PdfPCell();
                    cell88.AddElement(new Paragraph(textBox.Text));
                    cell88.BackgroundColor = BaseColor.LIGHT_GRAY;


                    PdfPCell cell89 = new PdfPCell();
                    cell89.AddElement(new Paragraph(textBox.Text));
                    cell89.BackgroundColor = BaseColor.LIGHT_GRAY;


                    pdfTable.AddCell(cell87);
                    pdfTable.AddCell(cell88);
                    pdfTable.AddCell(cell89);


                    //New Row Added
                    PdfPCell cell90 = new PdfPCell();
                    cell90.AddElement(new Paragraph(textBox.Text));
                    cell90.BackgroundColor = BaseColor.LIGHT_GRAY;

                    PdfPCell cell91 = new PdfPCell();
                    cell91.AddElement(new Paragraph(textBox.Text));
                    cell91.BackgroundColor = BaseColor.LIGHT_GRAY;

                    PdfPCell cell92 = new PdfPCell();
                    cell92.AddElement(new Paragraph(textBox.Text));
                    cell92.BackgroundColor = BaseColor.LIGHT_GRAY;

                    pdfTable.AddCell(cell90);
                    pdfTable.AddCell(cell91);
                    pdfTable.AddCell(cell92);

                    //New Row Added
                    PdfPCell cell93 = new PdfPCell();
                    cell93.AddElement(new Paragraph(textBox.Text));
                    cell93.BackgroundColor = BaseColor.LIGHT_GRAY;

                    pdfTable.AddCell(cell93);

                    //Adds data to table
                    doc.Add(pdfTable);

                    //close document
                    doc.Close();
                }
                return false;
            }
            return true;
        }
    }
}
