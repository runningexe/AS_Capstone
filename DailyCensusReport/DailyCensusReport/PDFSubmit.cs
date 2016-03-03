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
        #region PDF View
        public static bool PDFView(
            /**ICU**/
            TextBox txtCurrentCensusICU, TextBox txtAvailableBedsICU, TextBox txtIsoPatientsICU, TextBox txtDischargesICU, TextBox txtNotesICU, TextBox txtCurrentCapStatusICU,

            /**T2**/
            TextBox txtCurrentCensusT2, TextBox txtAvailableBedsT2, TextBox txtIsoPatientsT2, TextBox txtDischargesT2, TextBox txtNotesT2, TextBox txtCurrentCapStatusT2,

            /**PEDI**/
            TextBox txtCurrentCensusPEDI, TextBox txtAvailableBedsPEDI, TextBox txtIsoPatientsPEDI, TextBox txtDischargesPEDI, TextBox txtNotesPEDI, TextBox txtCurrentCapStatusPEDI,

            /**T4**/
            TextBox txtCurrentCensusT4, TextBox txtAvailableBedsT4, TextBox txtIsoPatientsT4, TextBox txtDischargesT4, TextBox txtNotesT4, TextBox txtCurrentCapStatusT4,

            /**6ACU**/
            TextBox txtCurrentCensus6ACU, TextBox txtAvailableBeds6ACU, TextBox txtIsoPatients6ACU, TextBox txtDischarges6ACU, TextBox txtNotes6ACU, TextBox txtCurrentCapStatus6ACU,

            /**TBC**/
            TextBox txtCurrentCensusTBC, TextBox txtAvailableBedsTBC, TextBox txtIsoPatientsTBC, TextBox txtDischargesTBC, TextBox txtNotesTBC, TextBox txtCurrentCapStatusTBC,

            /**BHU**/
            TextBox txtCurrentCensusBHU, TextBox txtAvailableBedsBHU, TextBox txtIsoPatientsBHU, TextBox txtDischargesBHU, TextBox txtNotesBHU, TextBox txtCurrentCapStatusBHU,

            /**Total**/
            Label lblCCTotal, Label lblABTotal, Label lblISOTotal, Label lblTotalDC, Label lbltotalNotes, TextBox txtCCSTotal
            )
        #endregion

        #region Save Dialog Box
        {
            //Creates a new SFD object (Opens the Save File Box)
            SaveFileDialog sfd = new SaveFileDialog();

            //To save PDF to desktop
            //path to save to your desktop
            sfd.Title = "Save As PDF";
            sfd.Filter = "PDF|.PDF";


            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                    doc.SetMargins(doc.LeftMargin, doc.RightMargin, doc.TopMargin + 50, doc.BottomMargin);
                    PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));

                    //Displays notification when PDF is created
                    MessageBox.Show("PDF Has Been Saved!", "Save Confirmation");
                    //Open Document.
                    doc.Open();

                    /*
                     * create document header; shows GMT time when PDF created.
                     * HeaderFooter class removed in iText 5.0.0, so we instead write 
                     * content to an **absolute** position on the document
                     */
                    iTextSharp.text.Rectangle page = doc.PageSize;
                    PdfPTable head = new PdfPTable(1);
                    head.TotalWidth = page.Width;
                    Phrase phrase = new Phrase("Hospital's Daily Census Report" + "\n" +
                      DateTime.Now.ToString("MM-dd-yyyy") + "\n\n" + "Hospital Capacity Status Alert:" + "  " + txtCCSTotal.Text + "\n\n" + "Total Census = " + " " + lblCCTotal.Text + "\n\n"
                    );

                    PdfPCell censusHeader = new PdfPCell(phrase);
                    censusHeader.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    censusHeader.VerticalAlignment = Element.ALIGN_TOP;
                    censusHeader.HorizontalAlignment = Element.ALIGN_CENTER;
                    head.AddCell(censusHeader);
                    head.WriteSelectedRows(
                        // first/last row; -1 writes all rows
                      0, -1,
                        // left offset
                      0,

                        // ** bottom** yPos of the table
                      doc.PageSize.Height - doc.TopMargin + head.TotalHeight + 2,
                      wri.DirectContent
                    );
        #endregion
                    #region Creates PDF Table
                    //Instantiating the table and giving it the number of columns it will have.
                    PdfPTable pdfTable = new PdfPTable(7);
                    iTextSharp.text.Font arial = FontFactory.GetFont("Arial", 8);

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
                    pdfTable.AddCell(cell24);
                    pdfTable.AddCell(cell25);
                    pdfTable.AddCell(cell26);
                    pdfTable.AddCell(cell27);

                    #endregion

                    #region ICU Row
                    /*********************ICU Data*********************/
                    PdfPCell cell28 = new PdfPCell();
                    cell28.AddElement(new Paragraph("ICU"));
                    cell28.BackgroundColor = BaseColor.LIGHT_GRAY;


                    PdfPCell cell29 = new PdfPCell();
                    cell29.AddElement(new Paragraph(txtCurrentCensusICU.Text, arial));


                    PdfPCell cell30 = new PdfPCell();
                    cell30.AddElement(new Paragraph(txtAvailableBedsICU.Text, arial));


                    PdfPCell cell31 = new PdfPCell();
                    cell31.AddElement(new Paragraph(txtIsoPatientsICU.Text, arial));


                    PdfPCell cell32 = new PdfPCell();
                    cell32.AddElement(new Paragraph(txtDischargesICU.Text, arial));


                    PdfPCell cell33 = new PdfPCell();
                    cell33.AddElement(new Paragraph(txtNotesICU.Text, arial));


                    pdfTable.AddCell(cell28);
                    pdfTable.AddCell(cell29);
                    pdfTable.AddCell(cell30);
                    pdfTable.AddCell(cell31);
                    pdfTable.AddCell(cell32);
                    pdfTable.AddCell(cell33);
                    /*************************************************/
                    #region ICU Color Changer
                    /****Dynamically changing PDF/Textbox colors.****/

                    int totalICUBeds = 9;
                    totalICUBeds = Convert.ToInt32(txtCurrentCensusICU.Text);


                    if (totalICUBeds <= 2)
                    {
                        //ICU Row Added
                        PdfPCell cell100 = new PdfPCell();
                        cell100.AddElement(new Paragraph(txtCurrentCapStatusICU.Text));
                        cell100.BackgroundColor = BaseColor.GREEN;
                        pdfTable.AddCell(cell100);
                    }
                    else if (totalICUBeds <= 4)
                    {
                        //ICU Row Added
                        PdfPCell cell100 = new PdfPCell();
                        cell100.AddElement(new Paragraph(txtCurrentCapStatusICU.Text));
                        cell100.BackgroundColor = BaseColor.YELLOW;
                        pdfTable.AddCell(cell100);
                    }

                    else if (totalICUBeds <= 5)
                    {
                        //ICU Row Added
                        PdfPCell cell100 = new PdfPCell();
                        cell100.AddElement(new Paragraph(txtCurrentCapStatusICU.Text));
                        cell100.BackgroundColor = BaseColor.ORANGE;
                        pdfTable.AddCell(cell100);
                    }

                    else if (totalICUBeds >= 6 && totalICUBeds <= 9)
                    {
                        //ICU Row Added
                        PdfPCell cell100 = new PdfPCell();
                        cell100.AddElement(new Paragraph(txtCurrentCapStatusICU.Text));
                        cell100.BackgroundColor = BaseColor.RED;
                        pdfTable.AddCell(cell100);
                    }
                    #endregion

                    /*************************************************/
                    #endregion

                    #region T2 Row

                    /*********************T2 Data*********************/
                    PdfPCell cell34 = new PdfPCell();
                    cell34.AddElement(new Paragraph("T2 M/S"));
                    cell34.BackgroundColor = BaseColor.LIGHT_GRAY;

                    PdfPCell cell35 = new PdfPCell();
                    cell35.AddElement(new Paragraph(txtCurrentCensusT2.Text, arial));

                    PdfPCell cell36 = new PdfPCell();
                    cell36.AddElement(new Paragraph(txtAvailableBedsT2.Text, arial));

                    PdfPCell cell37 = new PdfPCell();
                    cell37.AddElement(new Paragraph(txtIsoPatientsT2.Text, arial));

                    PdfPCell cell38 = new PdfPCell();
                    cell38.AddElement(new Paragraph(txtDischargesT2.Text, arial));

                    PdfPCell cell39 = new PdfPCell();
                    cell39.AddElement(new Paragraph(txtNotesT2.Text, arial));

                    pdfTable.AddCell(cell34);
                    pdfTable.AddCell(cell35);
                    pdfTable.AddCell(cell36);
                    pdfTable.AddCell(cell37);
                    pdfTable.AddCell(cell38);
                    pdfTable.AddCell(cell39);
                    /*************************************************/
                    #region T2 Color Changer
                    /****Dynamically changing PDF/Textbox colors.****/

                    int totalT2Beds = 28;
                    totalT2Beds = Convert.ToInt32(txtCurrentCensusT2.Text);


                    if (totalT2Beds <= 14)
                    {
                        //T2 Row Added
                        PdfPCell cell200 = new PdfPCell();
                        cell200.AddElement(new Paragraph(txtCurrentCapStatusT2.Text));
                        cell200.BackgroundColor = BaseColor.GREEN;
                        pdfTable.AddCell(cell200);
                    }
                    else if (totalT2Beds <= 17)
                    {
                        //T2 Row Added
                        PdfPCell cell200 = new PdfPCell();
                        cell200.AddElement(new Paragraph(txtCurrentCapStatusT2.Text));
                        cell200.BackgroundColor = BaseColor.YELLOW;
                        pdfTable.AddCell(cell200);
                    }
                    else if (totalT2Beds <= 20)
                    {
                        //T2 Row Added
                        PdfPCell cell200 = new PdfPCell();
                        cell200.AddElement(new Paragraph(txtCurrentCapStatusT2.Text));
                        cell200.BackgroundColor = BaseColor.ORANGE;
                        pdfTable.AddCell(cell200);
                    }

                    else if (totalT2Beds >= 20 && totalT2Beds <= 28)
                    {
                        //T2 Row Added
                        PdfPCell cell200 = new PdfPCell();
                        cell200.AddElement(new Paragraph(txtCurrentCapStatusT2.Text));
                        cell200.BackgroundColor = BaseColor.RED;
                        pdfTable.AddCell(cell200);
                    }
                    #endregion
                    /*************************************************/
                    #endregion

                    #region PEDI Row
                    /*********************PEDI Data*********************/
                    PdfPCell cell40 = new PdfPCell();
                    cell40.AddElement(new Paragraph("PEDI(T2)"));
                    cell40.BackgroundColor = BaseColor.LIGHT_GRAY;

                    PdfPCell cell41 = new PdfPCell();
                    cell41.AddElement(new Paragraph(txtCurrentCensusPEDI.Text, arial));

                    PdfPCell cell42 = new PdfPCell();
                    cell42.AddElement(new Paragraph(txtAvailableBedsPEDI.Text, arial));

                    PdfPCell cell43 = new PdfPCell();
                    cell43.AddElement(new Paragraph(txtIsoPatientsPEDI.Text, arial));

                    PdfPCell cell44 = new PdfPCell();
                    cell44.AddElement(new Paragraph(txtDischargesPEDI.Text, arial));

                    PdfPCell cell45 = new PdfPCell();
                    cell45.AddElement(new Paragraph(txtNotesPEDI.Text, arial));

                    pdfTable.AddCell(cell40);
                    pdfTable.AddCell(cell41);
                    pdfTable.AddCell(cell42);
                    pdfTable.AddCell(cell43);
                    pdfTable.AddCell(cell44);
                    pdfTable.AddCell(cell45);
                    /*************************************************/
                    #region PEDI Color Changer
                    /****Dynamically changing PDF/Textbox colors.****/
                    int totalPEDIBeds = 28;
                    totalPEDIBeds = Convert.ToInt32(txtCurrentCensusPEDI.Text);


                    if (totalPEDIBeds <= 14)
                    {
                        //PEDI Row Added
                        PdfPCell cell300 = new PdfPCell();
                        cell300.AddElement(new Paragraph(txtCurrentCapStatusPEDI.Text));
                        cell300.BackgroundColor = BaseColor.GREEN;
                        pdfTable.AddCell(cell300);
                    }
                    else if (totalPEDIBeds <= 17)
                    {
                        //PEDI Row Added
                        PdfPCell cell300 = new PdfPCell();
                        cell300.AddElement(new Paragraph(txtCurrentCapStatusPEDI.Text));
                        cell300.BackgroundColor = BaseColor.YELLOW;
                        pdfTable.AddCell(cell300);
                    }
                    else if (totalPEDIBeds <= 20)
                    {
                        //PEDI Row Added
                        PdfPCell cell300 = new PdfPCell();
                        cell300.AddElement(new Paragraph(txtCurrentCapStatusPEDI.Text));
                        cell300.BackgroundColor = BaseColor.ORANGE;
                        pdfTable.AddCell(cell300);
                    }

                    else if (totalPEDIBeds >= 20 && totalPEDIBeds <= 28)
                    {
                        //PEDI Row Added
                        PdfPCell cell300 = new PdfPCell();
                        cell300.AddElement(new Paragraph(txtCurrentCapStatusPEDI.Text));
                        cell300.BackgroundColor = BaseColor.RED;
                        pdfTable.AddCell(cell300);
                    }
                    #endregion
                    /*************************************************/
                    #endregion

                    #region T4 Row
                    /*********************T4 M/S Data*********************/
                    PdfPCell cell46 = new PdfPCell();
                    cell46.AddElement(new Paragraph("T4 M/S"));
                    cell46.BackgroundColor = BaseColor.LIGHT_GRAY;

                    PdfPCell cell47 = new PdfPCell();
                    cell47.AddElement(new Paragraph(txtCurrentCensusT4.Text, arial));

                    PdfPCell cell48 = new PdfPCell();
                    cell48.AddElement(new Paragraph(txtAvailableBedsT4.Text, arial));

                    PdfPCell cell49 = new PdfPCell();
                    cell49.AddElement(new Paragraph(txtIsoPatientsT4.Text, arial));

                    PdfPCell cell50 = new PdfPCell();
                    cell50.AddElement(new Paragraph(txtDischargesT4.Text, arial));

                    PdfPCell cell51 = new PdfPCell();
                    cell51.AddElement(new Paragraph(txtNotesT4.Text, arial));

                    pdfTable.AddCell(cell46);
                    pdfTable.AddCell(cell47);
                    pdfTable.AddCell(cell48);
                    pdfTable.AddCell(cell49);
                    pdfTable.AddCell(cell50);
                    pdfTable.AddCell(cell51);
                    /*************************************************/
                    #region T4 Color Changer
                    /****Dynamically changing PDF/Textbox colors.****/


                    int totalT4Beds = 29;
                    totalT4Beds = Convert.ToInt32(txtCurrentCensusT4.Text);


                    if (totalT4Beds <= 14)
                    {
                        //T4 Row Added
                        PdfPCell cell400 = new PdfPCell();
                        cell400.AddElement(new Paragraph(txtCurrentCapStatusT4.Text));
                        cell400.BackgroundColor = BaseColor.GREEN;
                        pdfTable.AddCell(cell400);
                    }
                    else if (totalT4Beds <= 17)
                    {
                        //T4 Row Added
                        PdfPCell cell400 = new PdfPCell();
                        cell400.AddElement(new Paragraph(txtCurrentCapStatusT4.Text));
                        cell400.BackgroundColor = BaseColor.YELLOW;
                        pdfTable.AddCell(cell400);
                    }
                    else if (totalT4Beds <= 20)
                    {
                        //T4 Row Added
                        PdfPCell cell400 = new PdfPCell();
                        cell400.AddElement(new Paragraph(txtCurrentCapStatusT4.Text));
                        cell400.BackgroundColor = BaseColor.ORANGE;
                        pdfTable.AddCell(cell400);
                    }

                    else if (totalT4Beds >= 20 && totalT4Beds <= 28)
                    {
                        //T4 Row Added
                        PdfPCell cell400 = new PdfPCell();
                        cell400.AddElement(new Paragraph(txtCurrentCapStatusT4.Text));
                        cell400.BackgroundColor = BaseColor.RED;
                        pdfTable.AddCell(cell400);
                    }
                    /*************************************************/
                    #endregion
                    #endregion

                    #region 6ACU Row
                    /*********************6ACU Data*********************/
                    PdfPCell cell52 = new PdfPCell();
                    cell52.AddElement(new Paragraph("6ACU"));
                    cell52.BackgroundColor = BaseColor.LIGHT_GRAY;

                    PdfPCell cell53 = new PdfPCell();
                    cell53.AddElement(new Paragraph(txtCurrentCensus6ACU.Text, arial));

                    PdfPCell cell54 = new PdfPCell();
                    cell54.AddElement(new Paragraph(txtAvailableBeds6ACU.Text, arial));

                    PdfPCell cell55 = new PdfPCell();
                    cell55.AddElement(new Paragraph(txtIsoPatients6ACU.Text, arial));

                    PdfPCell cell56 = new PdfPCell();
                    cell56.AddElement(new Paragraph(txtDischarges6ACU.Text, arial));

                    PdfPCell cell57 = new PdfPCell();
                    cell57.AddElement(new Paragraph(txtNotes6ACU.Text, arial));

                    pdfTable.AddCell(cell52);
                    pdfTable.AddCell(cell53);
                    pdfTable.AddCell(cell54);
                    pdfTable.AddCell(cell55);
                    pdfTable.AddCell(cell56);
                    pdfTable.AddCell(cell57);
                    /*************************************************/
                    #region 6ACU Color Changer
                    /****Dynamically changing PDF/Textbox colors.****/

                    int total6ACUBeds = 10;
                    total6ACUBeds = Convert.ToInt32(txtCurrentCensus6ACU.Text);


                    if (total6ACUBeds <= 3)
                    {
                        //6ACU Row Added
                        PdfPCell cell500 = new PdfPCell();
                        cell500.AddElement(new Paragraph(txtCurrentCapStatus6ACU.Text));
                        cell500.BackgroundColor = BaseColor.GREEN;
                        pdfTable.AddCell(cell500);
                    }
                    else if (total6ACUBeds <= 5)
                    {
                        //6ACU Row Added
                        PdfPCell cell500 = new PdfPCell();
                        cell500.AddElement(new Paragraph(txtCurrentCapStatus6ACU.Text));
                        cell500.BackgroundColor = BaseColor.YELLOW;
                        pdfTable.AddCell(cell500);
                    }

                    else if (total6ACUBeds <= 6)
                    {
                        //6ACU Row Added
                        PdfPCell cell500 = new PdfPCell();
                        cell500.AddElement(new Paragraph(txtCurrentCapStatus6ACU.Text));
                        cell500.BackgroundColor = BaseColor.ORANGE;
                        pdfTable.AddCell(cell500);
                    }

                    else if (total6ACUBeds >= 7 && total6ACUBeds <= 10)
                    {
                        //6ACU Row Added
                        PdfPCell cell500 = new PdfPCell();
                        cell500.AddElement(new Paragraph(txtCurrentCapStatus6ACU.Text));
                        cell500.BackgroundColor = BaseColor.RED;
                        pdfTable.AddCell(cell500);
                    }
                    #endregion
                    /*************************************************/
                    #endregion

                    #region TBC Row
                    /*********************TBC Data*********************/
                    PdfPCell cell58 = new PdfPCell();
                    cell58.AddElement(new Paragraph("TBC (T7)"));
                    cell58.BackgroundColor = BaseColor.LIGHT_GRAY;

                    PdfPCell cell59 = new PdfPCell();
                    cell59.AddElement(new Paragraph(txtCurrentCensusTBC.Text, arial));

                    PdfPCell cell60 = new PdfPCell();
                    cell60.AddElement(new Paragraph(txtAvailableBedsTBC.Text, arial));

                    PdfPCell cell61 = new PdfPCell();
                    cell61.AddElement(new Paragraph(txtIsoPatientsTBC.Text, arial));

                    PdfPCell cell62 = new PdfPCell();
                    cell62.AddElement(new Paragraph(txtDischargesTBC.Text, arial));

                    PdfPCell cell63 = new PdfPCell();
                    cell63.AddElement(new Paragraph(txtNotesTBC.Text, arial));

                    pdfTable.AddCell(cell58);
                    pdfTable.AddCell(cell59);
                    pdfTable.AddCell(cell60);
                    pdfTable.AddCell(cell61);
                    pdfTable.AddCell(cell62);
                    pdfTable.AddCell(cell63);
                    /*************************************************/
                    #region TBC Color Changer
                    /****Dynamically changing PDF/Textbox colors.****/

                    int totalTBCBeds = 10;
                    totalTBCBeds = Convert.ToInt32(txtCurrentCensusTBC.Text);


                    if (totalTBCBeds <= 3)
                    {
                        //TBC Row Added
                        PdfPCell cell600 = new PdfPCell();
                        cell600.AddElement(new Paragraph(txtCurrentCapStatusTBC.Text));
                        cell600.BackgroundColor = BaseColor.GREEN;
                        pdfTable.AddCell(cell600);
                    }
                    else if (totalTBCBeds <= 5)
                    {
                        //TBC Row Added
                        PdfPCell cell600 = new PdfPCell();
                        cell600.AddElement(new Paragraph(txtCurrentCapStatusTBC.Text));
                        cell600.BackgroundColor = BaseColor.YELLOW;
                        pdfTable.AddCell(cell600);
                    }

                    else if (totalTBCBeds <= 6)
                    {
                        //TBC Row Added
                        PdfPCell cell600 = new PdfPCell();
                        cell600.AddElement(new Paragraph(txtCurrentCapStatusTBC.Text));
                        cell600.BackgroundColor = BaseColor.ORANGE;
                        pdfTable.AddCell(cell600);
                    }

                    else if (totalTBCBeds >= 7 && totalTBCBeds <= 10)
                    {
                        //TBC Row Added
                        PdfPCell cell600 = new PdfPCell();
                        cell600.AddElement(new Paragraph(txtCurrentCapStatusTBC.Text));
                        cell600.BackgroundColor = BaseColor.RED;
                        pdfTable.AddCell(cell600);
                    }
                    /*************************************************/
                    #endregion
                    #endregion

                    #region BHU Row
                    /*********************BHU Data*********************/
                    PdfPCell cell64 = new PdfPCell();
                    cell64.AddElement(new Paragraph("BHU (T8)"));
                    cell64.BackgroundColor = BaseColor.LIGHT_GRAY;

                    PdfPCell cell65 = new PdfPCell();
                    cell65.AddElement(new Paragraph(txtCurrentCensusBHU.Text, arial));

                    PdfPCell cell66 = new PdfPCell();
                    cell66.AddElement(new Paragraph(txtAvailableBedsBHU.Text, arial));

                    PdfPCell cell67 = new PdfPCell();
                    cell67.AddElement(new Paragraph(txtIsoPatientsBHU.Text, arial));

                    PdfPCell cell68 = new PdfPCell();
                    cell68.AddElement(new Paragraph(txtDischargesBHU.Text, arial));

                    PdfPCell cell69 = new PdfPCell();
                    cell69.AddElement(new Paragraph(txtNotesBHU.Text, arial));

                    pdfTable.AddCell(cell64);
                    pdfTable.AddCell(cell65);
                    pdfTable.AddCell(cell66);
                    pdfTable.AddCell(cell67);
                    pdfTable.AddCell(cell68);
                    pdfTable.AddCell(cell69);
                    /*************************************************/
                    #region BHU Color Changer
                    /****Dynamically changing PDF/Textbox colors.****/

                    int totalBHUBeds = 15;
                    totalBHUBeds = Convert.ToInt32(txtCurrentCensusBHU.Text);


                    if (totalBHUBeds <= 8)
                    {
                        //BHU Row Added
                        PdfPCell cell700 = new PdfPCell();
                        cell700.AddElement(new Paragraph(txtCurrentCapStatusBHU.Text));
                        cell700.BackgroundColor = BaseColor.GREEN;
                        pdfTable.AddCell(cell700);
                    }
                    else if (totalBHUBeds <= 10)
                    {
                        //BHU Row Added
                        PdfPCell cell700 = new PdfPCell();
                        cell700.AddElement(new Paragraph(txtCurrentCapStatusBHU.Text));
                        cell700.BackgroundColor = BaseColor.YELLOW;
                        pdfTable.AddCell(cell700);
                    }

                    else if (totalBHUBeds <= 11)
                    {
                        //BHU Row Added
                        PdfPCell cell700 = new PdfPCell();
                        cell700.AddElement(new Paragraph(txtCurrentCapStatusBHU.Text));
                        cell700.BackgroundColor = BaseColor.ORANGE;
                        pdfTable.AddCell(cell700);
                    }

                    else if (totalBHUBeds >= 12 && totalBHUBeds <= 15)
                    {
                        //BHU Row Added
                        PdfPCell cell700 = new PdfPCell();
                        cell700.AddElement(new Paragraph(txtCurrentCapStatusBHU.Text));
                        cell700.BackgroundColor = BaseColor.RED;
                        pdfTable.AddCell(cell700);
                    }
                    #endregion
                    /*************************************************/

                    #endregion

                    #region Total Row
                    /*********************TOTAL Data*********************/

                    PdfPCell cell70 = new PdfPCell();
                    cell70.AddElement(new Paragraph("Total:"));
                    cell70.BackgroundColor = BaseColor.LIGHT_GRAY;
                    cell70.UseVariableBorders = true;
                    cell70.BorderColorLeft = BaseColor.BLACK;
                    cell70.BorderColorBottom = BaseColor.BLACK;
                    cell70.BorderColorTop = BaseColor.BLACK;
                    cell70.BorderColorRight = BaseColor.BLACK;
                    cell70.BorderWidthLeft = 1f;
                    cell70.BorderWidthRight = 1f;
                    cell70.BorderWidthTop = 1f;
                    cell70.BorderWidthBottom = 1f;

                    PdfPCell cell71 = new PdfPCell();
                    cell71.AddElement(new Paragraph(lblCCTotal.Text));
                    cell71.BackgroundColor = BaseColor.LIGHT_GRAY;
                    cell71.UseVariableBorders = true;
                    cell71.BorderColorLeft = BaseColor.BLACK;
                    cell71.BorderColorBottom = BaseColor.BLACK;
                    cell71.BorderColorTop = BaseColor.BLACK;
                    cell71.BorderColorRight = BaseColor.BLACK;
                    cell71.BorderWidthLeft = 1f;
                    cell71.BorderWidthRight = 1f;
                    cell71.BorderWidthTop = 1f;
                    cell71.BorderWidthBottom = 1f;


                    PdfPCell cell72 = new PdfPCell();
                    cell72.AddElement(new Paragraph(lblABTotal.Text));
                    cell72.BackgroundColor = BaseColor.LIGHT_GRAY;
                    cell72.UseVariableBorders = true;
                    cell72.BorderColorLeft = BaseColor.BLACK;
                    cell72.BorderColorBottom = BaseColor.BLACK;
                    cell72.BorderColorTop = BaseColor.BLACK;
                    cell72.BorderColorRight = BaseColor.BLACK;
                    cell72.BorderWidthLeft = 1f;
                    cell72.BorderWidthRight = 1f;
                    cell72.BorderWidthTop = 1f;
                    cell72.BorderWidthBottom = 1f;


                    PdfPCell cell73 = new PdfPCell();
                    cell73.AddElement(new Paragraph(lblISOTotal.Text));
                    cell73.BackgroundColor = BaseColor.LIGHT_GRAY;
                    cell73.UseVariableBorders = true;
                    cell73.BorderColorLeft = BaseColor.BLACK;
                    cell73.BorderColorBottom = BaseColor.BLACK;
                    cell73.BorderColorTop = BaseColor.BLACK;
                    cell73.BorderColorRight = BaseColor.BLACK;
                    cell73.BorderWidthLeft = 1f;
                    cell73.BorderWidthRight = 1f;
                    cell73.BorderWidthTop = 1f;
                    cell73.BorderWidthBottom = 1f;


                    PdfPCell cell74 = new PdfPCell();
                    cell74.AddElement(new Paragraph(lblTotalDC.Text));
                    cell74.BackgroundColor = BaseColor.LIGHT_GRAY;
                    cell74.UseVariableBorders = true;
                    cell74.BorderColorLeft = BaseColor.BLACK;
                    cell74.BorderColorBottom = BaseColor.BLACK;
                    cell74.BorderColorTop = BaseColor.BLACK;
                    cell74.BorderColorRight = BaseColor.BLACK;
                    cell74.BorderWidthLeft = 1f;
                    cell74.BorderWidthRight = 1f;
                    cell74.BorderWidthTop = 1f;
                    cell74.BorderWidthBottom = 1f;


                    PdfPCell cell75 = new PdfPCell();
                    cell75.AddElement(new Paragraph(lbltotalNotes.Text));
                    cell75.BackgroundColor = BaseColor.LIGHT_GRAY;
                    cell75.UseVariableBorders = true;
                    cell75.BorderColorLeft = BaseColor.BLACK;
                    cell75.BorderColorBottom = BaseColor.BLACK;
                    cell75.BorderColorTop = BaseColor.BLACK;
                    cell75.BorderColorRight = BaseColor.BLACK;
                    cell75.BorderWidthLeft = 1f;
                    cell75.BorderWidthRight = 1f;
                    cell75.BorderWidthTop = 1f;
                    cell75.BorderWidthBottom = 1f;

                    pdfTable.AddCell(cell70);
                    pdfTable.AddCell(cell71);
                    pdfTable.AddCell(cell72);
                    pdfTable.AddCell(cell73);
                    pdfTable.AddCell(cell74);
                    pdfTable.AddCell(cell75);
                    /*************************************************/
                    #region Total Calculation Color Changer
                    /****Dynamically changing PDF/Textbox colors.****/


                    int totalHospitalCensus = 129;
                    totalHospitalCensus = Convert.ToInt32(lblCCTotal.Text);


                    if (totalHospitalCensus <= 70)
                    {
                        //Total Row Added
                        PdfPCell cell600 = new PdfPCell();
                        cell600.AddElement(new Paragraph(txtCCSTotal.Text));
                        cell600.BackgroundColor = BaseColor.GREEN;
                        cell600.UseVariableBorders = true;
                        cell600.BorderColorLeft = BaseColor.BLACK;
                        cell600.BorderColorBottom = BaseColor.BLACK;
                        cell600.BorderColorTop = BaseColor.BLACK;
                        cell600.BorderColorRight = BaseColor.BLACK;
                        cell600.BorderWidthLeft = 1f;
                        cell600.BorderWidthRight = 1f;
                        cell600.BorderWidthTop = 1f;
                        cell600.BorderWidthBottom = 1f;
                        pdfTable.AddCell(cell600);
                    }
                    else if (totalHospitalCensus <= 80)
                    {
                        //Total Row Added
                        PdfPCell cell600 = new PdfPCell();
                        cell600.AddElement(new Paragraph(txtCCSTotal.Text));
                        cell600.BackgroundColor = BaseColor.YELLOW;
                        cell600.UseVariableBorders = true;
                        cell600.BorderColorLeft = BaseColor.BLACK;
                        cell600.BorderColorBottom = BaseColor.BLACK;
                        cell600.BorderColorTop = BaseColor.BLACK;
                        cell600.BorderColorRight = BaseColor.BLACK;
                        cell600.BorderWidthLeft = 1f;
                        cell600.BorderWidthRight = 1f;
                        cell600.BorderWidthTop = 1f;
                        cell600.BorderWidthBottom = 1f;
                        pdfTable.AddCell(cell600);
                    }

                    else if (totalHospitalCensus <= 90)
                    {
                        //Total Row Added
                        PdfPCell cell600 = new PdfPCell();
                        cell600.AddElement(new Paragraph(txtCCSTotal.Text));
                        cell600.BackgroundColor = BaseColor.ORANGE;
                        cell600.UseVariableBorders = true;
                        cell600.BorderColorLeft = BaseColor.BLACK;
                        cell600.BorderColorBottom = BaseColor.BLACK;
                        cell600.BorderColorTop = BaseColor.BLACK;
                        cell600.BorderColorRight = BaseColor.BLACK;
                        cell600.BorderWidthLeft = 1f;
                        cell600.BorderWidthRight = 1f;
                        cell600.BorderWidthTop = 1f;
                        cell600.BorderWidthBottom = 1f;
                        pdfTable.AddCell(cell600);
                    }

                    else if (totalHospitalCensus >= 100 && totalHospitalCensus <= 129)
                    {

                        //Total Row Added
                        PdfPCell cell600 = new PdfPCell();
                        cell600.AddElement(new Paragraph(txtCCSTotal.Text));
                        cell600.BackgroundColor = BaseColor.RED;
                        cell600.UseVariableBorders = true;
                        cell600.BorderColorLeft = BaseColor.BLACK;
                        cell600.BorderColorBottom = BaseColor.BLACK;
                        cell600.BorderColorTop = BaseColor.BLACK;
                        cell600.BorderColorRight = BaseColor.BLACK;
                        cell600.BorderWidthLeft = 1f;
                        cell600.BorderWidthRight = 1f;
                        cell600.BorderWidthTop = 1f;
                        cell600.BorderWidthBottom = 1f;
                        pdfTable.AddCell(cell600);
                    }
                    #endregion
                    /*************************************************/
                    #endregion

                    //Adds the inputted data to the PDF Table
                    doc.Add(pdfTable);

                    //Close document
                    doc.Close();

                    #endregion
                }

//If PDF File Is Currently Open, This Will Push Out The Error

                catch (System.IO.IOException)
                {
                   MessageBox.Show(sfd.FileName + "  " + "Is Currently Open. Please Close Your PDF Viewer.", "ERROR MESSAGE");
                }
            }
            return false;
        }
        
    }
}
