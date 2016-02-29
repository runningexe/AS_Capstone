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
            TextBox txtCurrentCensusBHU, TextBox txtAvailableBedsBHU, TextBox txtIsoPatientsBHU, TextBox txtDischargesBHU, TextBox txtNotesBHU, TextBox txtCurrentCapStatusBHU)
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
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                //Displays notification when PDF is created
                MessageBox.Show("PDF Has Been Saved!", "Saved");
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
                  DateTime.Now.ToString("MM-dd-yyyy")
                );

                PdfPCell c = new PdfPCell(phrase);
                c.Border = iTextSharp.text.Rectangle.NO_BORDER;
                c.VerticalAlignment = Element.ALIGN_TOP;
                c.HorizontalAlignment = Element.ALIGN_CENTER;
                head.AddCell(c);
                head.WriteSelectedRows(
                  // first/last row; -1 writes all rows
                  0, -1,
                  // left offset
                  0,
                  // ** bottom** yPos of the table
                  page.Height - doc.TopMargin + head.TotalHeight + 10,
                  wri.DirectContent
                );
        #endregion

        #region Creates PDF Table
                //Instantiating the table and giving it the number of columns it will have.
                PdfPTable pdfTable = new PdfPTable(7);
                iTextSharp.text.Font arial = FontFactory.GetFont("Arial",8);

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


/*************************************************/
                #endregion

                #region T2 Row

/*********************T2 Data*********************/
                PdfPCell cell34 = new PdfPCell();
                cell34.AddElement(new Paragraph("T2 M/S"));
                cell34.BackgroundColor = BaseColor.LIGHT_GRAY;

                PdfPCell cell35 = new PdfPCell();
                cell35.AddElement(new Paragraph(txtCurrentCensusT2.Text));

                PdfPCell cell36 = new PdfPCell();
                cell36.AddElement(new Paragraph(txtAvailableBedsT2.Text));

                PdfPCell cell37 = new PdfPCell();
                cell37.AddElement(new Paragraph(txtIsoPatientsT2.Text));

                PdfPCell cell38 = new PdfPCell();
                cell38.AddElement(new Paragraph(txtDischargesT2.Text));

                PdfPCell cell39 = new PdfPCell();
                cell39.AddElement(new Paragraph(txtNotesT2.Text));

                pdfTable.AddCell(cell34);
                pdfTable.AddCell(cell35);
                pdfTable.AddCell(cell36);
                pdfTable.AddCell(cell37);
                pdfTable.AddCell(cell38);
                pdfTable.AddCell(cell39);
/*************************************************/
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
/*************************************************/
                #endregion

                #region PEDI Row
/*********************PEDI Data*********************/
                PdfPCell cell40 = new PdfPCell();
                cell40.AddElement(new Paragraph("PEDI(T2)"));
                cell40.BackgroundColor = BaseColor.LIGHT_GRAY;

                PdfPCell cell41 = new PdfPCell();
                cell41.AddElement(new Paragraph(txtCurrentCensusPEDI.Text));

                PdfPCell cell42 = new PdfPCell();
                cell42.AddElement(new Paragraph(txtAvailableBedsPEDI.Text));

                PdfPCell cell43 = new PdfPCell();
                cell43.AddElement(new Paragraph(txtIsoPatientsPEDI.Text));

                PdfPCell cell44 = new PdfPCell();
                cell44.AddElement(new Paragraph(txtDischargesPEDI.Text));

                PdfPCell cell45 = new PdfPCell();
                cell45.AddElement(new Paragraph(txtNotesPEDI.Text));

                pdfTable.AddCell(cell40);
                pdfTable.AddCell(cell41);
                pdfTable.AddCell(cell42);
                pdfTable.AddCell(cell43);
                pdfTable.AddCell(cell44);
                pdfTable.AddCell(cell45);
/*************************************************/
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

/*************************************************/
                #endregion

                #region T4 Row
/*********************T4 M/S Data*********************/
                PdfPCell cell46 = new PdfPCell();
                cell46.AddElement(new Paragraph("T4 M/S"));
                cell46.BackgroundColor = BaseColor.LIGHT_GRAY;

                PdfPCell cell47 = new PdfPCell();
                cell47.AddElement(new Paragraph(txtCurrentCensusT4.Text));

                PdfPCell cell48 = new PdfPCell();
                cell48.AddElement(new Paragraph(txtAvailableBedsT4.Text));

                PdfPCell cell49 = new PdfPCell();
                cell49.AddElement(new Paragraph(txtIsoPatientsT4.Text));

                PdfPCell cell50 = new PdfPCell();
                cell50.AddElement(new Paragraph(txtDischargesT4.Text));

                PdfPCell cell51 = new PdfPCell();
                cell51.AddElement(new Paragraph(txtNotesT4.Text));

                pdfTable.AddCell(cell46);
                pdfTable.AddCell(cell47);
                pdfTable.AddCell(cell48);
                pdfTable.AddCell(cell49);
                pdfTable.AddCell(cell50);
                pdfTable.AddCell(cell51);
/*************************************************/
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

                #region 6ACU Row
/*********************6ACU Data*********************/
                PdfPCell cell52 = new PdfPCell();
                cell52.AddElement(new Paragraph("6ACU"));
                cell52.BackgroundColor = BaseColor.LIGHT_GRAY;

                PdfPCell cell53 = new PdfPCell();
                cell53.AddElement(new Paragraph(txtCurrentCensus6ACU.Text));

                PdfPCell cell54 = new PdfPCell();
                cell54.AddElement(new Paragraph(txtAvailableBeds6ACU.Text));

                PdfPCell cell55 = new PdfPCell();
                cell55.AddElement(new Paragraph(txtIsoPatients6ACU.Text));

                PdfPCell cell56 = new PdfPCell();
                cell56.AddElement(new Paragraph(txtDischarges6ACU.Text));

                PdfPCell cell57 = new PdfPCell();
                cell57.AddElement(new Paragraph(txtNotes6ACU.Text));

                pdfTable.AddCell(cell52);
                pdfTable.AddCell(cell53);
                pdfTable.AddCell(cell54);
                pdfTable.AddCell(cell55);
                pdfTable.AddCell(cell56);
                pdfTable.AddCell(cell57);
/*************************************************/
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
/*************************************************/
                #endregion

                #region TBC Row
/*********************TBC Data*********************/
                PdfPCell cell71 = new PdfPCell();
                cell71.AddElement(new Paragraph("TBC (T7)"));
                cell71.BackgroundColor = BaseColor.LIGHT_GRAY;

                PdfPCell cell72 = new PdfPCell();
                cell72.AddElement(new Paragraph(txtCurrentCensusTBC.Text));

                PdfPCell cell73 = new PdfPCell();
                cell73.AddElement(new Paragraph(txtAvailableBedsTBC.Text));

                PdfPCell cell74 = new PdfPCell();
                cell74.AddElement(new Paragraph(txtIsoPatientsTBC.Text));

                PdfPCell cell75 = new PdfPCell();
                cell75.AddElement(new Paragraph(txtDischargesTBC.Text));

                PdfPCell cell76 = new PdfPCell();
                cell76.AddElement(new Paragraph(txtNotesTBC.Text));

                pdfTable.AddCell(cell71);
                pdfTable.AddCell(cell72);
                pdfTable.AddCell(cell73);
                pdfTable.AddCell(cell74);
                pdfTable.AddCell(cell75);
                pdfTable.AddCell(cell76);
/*************************************************/
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

                #region BHU Row
/*********************BHU Data*********************/
                PdfPCell cell81 = new PdfPCell();
                cell81.AddElement(new Paragraph("BHU (T8)"));
                cell81.BackgroundColor = BaseColor.LIGHT_GRAY;

                PdfPCell cell82 = new PdfPCell();
                cell82.AddElement(new Paragraph(txtCurrentCensusBHU.Text));

                PdfPCell cell83 = new PdfPCell();
                cell83.AddElement(new Paragraph(txtAvailableBedsBHU.Text));

                PdfPCell cell84 = new PdfPCell();
                cell84.AddElement(new Paragraph(txtIsoPatientsBHU.Text));

                PdfPCell cell85 = new PdfPCell();
                cell85.AddElement(new Paragraph(txtDischargesBHU.Text));

                PdfPCell cell86 = new PdfPCell();
                cell86.AddElement(new Paragraph(txtNotesBHU.Text));

                pdfTable.AddCell(cell81);
                pdfTable.AddCell(cell82);
                pdfTable.AddCell(cell83);
                pdfTable.AddCell(cell84);
                pdfTable.AddCell(cell85);
                pdfTable.AddCell(cell86);
/*************************************************/
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
/*************************************************/
                #endregion

                #region Total Row
                ///*********************TOTAL Data*********************/
                //PdfPCell cell91 = new PdfPCell();
                //cell91.AddElement(new Paragraph("TOTAL"));
                //cell91.BackgroundColor = BaseColor.LIGHT_GRAY;

                //PdfPCell cell92 = new PdfPCell();
                //cell92.AddElement(new Paragraph(currentCensus.Text));
                //cell92.BackgroundColor = BaseColor.LIGHT_GRAY;

                //PdfPCell cell93 = new PdfPCell();
                //cell93.AddElement(new Paragraph(availableBeds.Text));
                //cell93.BackgroundColor = BaseColor.LIGHT_GRAY;

                //PdfPCell cell94 = new PdfPCell();
                //cell94.AddElement(new Paragraph(numOfIsoPatients.Text));
                //cell94.BackgroundColor = BaseColor.LIGHT_GRAY;

                //PdfPCell cell95 = new PdfPCell();
                //cell95.AddElement(new Paragraph(potentialDCs.Text));
                //cell95.BackgroundColor = BaseColor.LIGHT_GRAY;

                //PdfPCell cell96 = new PdfPCell();
                //cell96.AddElement(new Paragraph(notes.Text));
                //cell96.BackgroundColor = BaseColor.LIGHT_GRAY;

                //pdfTable.AddCell(cell91);
                //pdfTable.AddCell(cell92);
                //pdfTable.AddCell(cell93);
                //pdfTable.AddCell(cell94);
                //pdfTable.AddCell(cell95);
                //pdfTable.AddCell(cell96);
                /*************************************************/

                /****Dynamically changing PDF/Textbox colors.****/

                //int totalCurrentCensus = Convert.ToInt32(currentCensus.Text);

                //if (totalCurrentCensus <= 5)
                //{
                //    //ICU Row Added
                //    PdfPCell colorChangeCell = new PdfPCell();
                //    colorChangeCell.AddElement(new Paragraph(currentCapStatus.Text));
                //    colorChangeCell.BackgroundColor = BaseColor.GREEN;
                //    pdfTable.AddCell(colorChangeCell);
                //}
                //else if (totalCurrentCensus > 7)
                //{
                //    //ICU Row Added
                //    PdfPCell colorChangeCell = new PdfPCell();
                //    colorChangeCell.AddElement(new Paragraph(currentCapStatus.Text));
                //    colorChangeCell.BackgroundColor = BaseColor.RED;
                //    pdfTable.AddCell(colorChangeCell);
                //}
                ///*************************************************/
                #endregion

                //Adds the inputted data to the PDF Table
                doc.Add(pdfTable);

                //Close document
                doc.Close();
            }
                #endregion
            return true;
        }
    }    
}
