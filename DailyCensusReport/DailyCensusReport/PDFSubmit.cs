﻿using System;
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
            Label lblCCTotal, Label lblABTotal, Label lblISOTotal, Label lblTotalDC, Label lbltotalNotes, TextBox txtCCSTotal)
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
                    doc.SetMargins(doc.LeftMargin, doc.RightMargin, doc.TopMargin + 70, doc.BottomMargin);
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
                    Phrase phrase = new Phrase("Hospital's Daily Census Report" + "\n\n" +
                      DateTime.Today.ToLongDateString() + "\n\n" + "Hospital Capacity Status Alert:" + "  " + txtCCSTotal.Text + "\n\n" + "Total Census = " + " " + lblCCTotal.Text + "\n\n"
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

        #region PDF Header Table
                    iTextSharp.text.Font times = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        //{ HorizontalAlignment = Element.ALIGN_CENTER, WidthPercentage = 100, HeaderRows = 2 }
                        PdfPTable table = new PdfPTable(new float[] { 1, 1, 1, 1, 1, 5, 1 });
                        table.WidthPercentage = 100;
                        table.HorizontalAlignment = Element.ALIGN_CENTER;
                        //table.SetWidths(new float[] { 2f, 6f, 6f, 3f, 5f, 8f, 5f, 5f, 5f, 5f });
                        table.AddCell(new PdfPCell(new Phrase("unit", times)));
                        table.AddCell(new PdfPCell(new Phrase("Current Census", times)));
                        table.AddCell(new PdfPCell(new Phrase("Avail Beds", times)));
                        table.AddCell(new PdfPCell(new Phrase("# Iso Patients", times)));
                        table.AddCell(new PdfPCell(new Phrase("Potential DC's", times)));
                        table.AddCell(new PdfPCell(new Phrase("Notes", times)));
                        table.AddCell(new PdfPCell(new Phrase("Current Capactiy Status", times)));
                     #endregion
                        
        #region ICU Column
                        PdfPTable tableICU = new PdfPTable(new float[] { 1, 1, 1, 1, 1, 5, 1 });
                        table.WidthPercentage = 100;
                        table.HorizontalAlignment = Element.ALIGN_CENTER;
                        //table.SetWidths(new float[] { 2f, 6f, 6f, 3f, 5f, 8f, 5f, 5f, 5f, 5f });
                        table.AddCell(new PdfPCell(new Phrase("ICU", times)));
                        table.AddCell(new PdfPCell(new Phrase(txtCurrentCensusICU.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtAvailableBedsICU.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtIsoPatientsICU.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtDischargesICU.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtNotesICU.Text, times)));
                        #endregion

        #region ICU Color Calculation

                        int totalICUBeds = 9;
                        totalICUBeds = Convert.ToInt32(txtCurrentCensusICU.Text);


                        if (totalICUBeds <= 2)
                        {
                            //ICU Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusICU.Text, times))).BackgroundColor = BaseColor.GREEN; 
                            
                           
                        }
                        else if (totalICUBeds <= 4)
                        {
                            //ICU Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusICU.Text, times))).BackgroundColor = BaseColor.YELLOW; 
                            
                        }

                        else if (totalICUBeds <= 5)
                        {
                            //ICU Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusICU.Text, times))).BackgroundColor = BaseColor.ORANGE; 
                            
                        }

                        else if (totalICUBeds >= 6 && totalICUBeds <= 9)
                        {
                            //ICU Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusICU.Text, times))).BackgroundColor = BaseColor.RED;

                        }

                        #endregion

        #region T2 Column

                        PdfPTable tableT2 = new PdfPTable(new float[] { 1, 1, 1, 1, 1, 5, 1 });
                        table.WidthPercentage = 100;
                        table.HorizontalAlignment = Element.ALIGN_CENTER;
                        //table.SetWidths(new float[] { 2f, 6f, 6f, 3f, 5f, 8f, 5f, 5f, 5f, 5f });
                        table.AddCell(new PdfPCell(new Phrase("T2", times)));
                        table.AddCell(new PdfPCell(new Phrase(txtCurrentCensusT2.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtAvailableBedsT2.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtIsoPatientsT2.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtDischargesT2.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtNotesT2.Text, times)));
 
                        #endregion
        
        #region T2 Calculation

                        int totalT2Beds = 28;
                        totalT2Beds = Convert.ToInt32(txtCurrentCensusT2.Text);


                        if (totalT2Beds <= 14)
                        {
                            //T2 Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusT2.Text, times))).BackgroundColor = BaseColor.GREEN;
                        }
                        else if (totalT2Beds <= 17)
                        {
                            //T2 Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusT2.Text, times))).BackgroundColor = BaseColor.YELLOW;
                        }
                        else if (totalT2Beds <= 20)
                        {
                            //T2 Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusT2.Text, times))).BackgroundColor = BaseColor.ORANGE;
                        }

                        else if (totalT2Beds >= 20 && totalT2Beds <= 28)
                        {
                            //T2 Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusT2.Text, times))).BackgroundColor = BaseColor.RED;
                        }

                        #endregion


        #region PEDI Column

        PdfPTable tablePEDI = new PdfPTable(new float[] { 1, 1, 1, 1, 1, 5, 1 });
        table.WidthPercentage = 100;
        table.HorizontalAlignment = Element.ALIGN_CENTER;
        //table.SetWidths(new float[] { 2f, 6f, 6f, 3f, 5f, 8f, 5f, 5f, 5f, 5f });
        table.AddCell(new PdfPCell(new Phrase("PEDI", times)));
        table.AddCell(new PdfPCell(new Phrase(txtCurrentCensusPEDI.Text, times)));
        table.AddCell(new PdfPCell(new Phrase(txtAvailableBedsPEDI.Text, times)));
        table.AddCell(new PdfPCell(new Phrase(txtIsoPatientsPEDI.Text, times)));
        table.AddCell(new PdfPCell(new Phrase(txtDischargesPEDI.Text, times)));
        table.AddCell(new PdfPCell(new Phrase(txtNotesPEDI.Text, times)));
                        
        #endregion

        #region PEDI Color Calculation

        int totalPEDIBeds = 28;
        totalPEDIBeds = Convert.ToInt32(txtCurrentCensusPEDI.Text);

        if (totalPEDIBeds <= 14)
        {
            //PEDI Row Added
            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusPEDI.Text, times))).BackgroundColor = BaseColor.GREEN;
        }
        else if (totalPEDIBeds <= 17)
        {
            //PEDI Row Added
            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusPEDI.Text, times))).BackgroundColor = BaseColor.YELLOW;
        }
        else if (totalPEDIBeds <= 20)
        {
            //PEDI Row Added
            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusPEDI.Text, times))).BackgroundColor = BaseColor.ORANGE;
        }

        else if (totalPEDIBeds >= 20 && totalPEDIBeds <= 28)
        {
            //PEDI Row Added
            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusPEDI.Text, times))).BackgroundColor = BaseColor.RED;
        }


        #endregion


        #region T4 Column

                        PdfPTable tableT4 = new PdfPTable(new float[] { 1, 1, 1, 1, 1, 5, 1 });
                        table.WidthPercentage = 100;
                        table.HorizontalAlignment = Element.ALIGN_CENTER;
                        //table.SetWidths(new float[] { 2f, 6f, 6f, 3f, 5f, 8f, 5f, 5f, 5f, 5f });
                        table.AddCell(new PdfPCell(new Phrase("T4", times)));
                        table.AddCell(new PdfPCell(new Phrase(txtCurrentCensusT4.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtAvailableBedsT4.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtIsoPatientsT4.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtDischargesT4.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtNotesT4.Text, times)));
                      

        #endregion
        
        #region T4 Color Calculation

                    int totalT4Beds = 29;
                    totalT4Beds = Convert.ToInt32(txtCurrentCensusT4.Text);


                    if (totalT4Beds <= 14)
                    {
                        //T4 Row Added
                        table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusT4.Text, times))).BackgroundColor = BaseColor.GREEN;
                    }
                    else if (totalT4Beds <= 17)
                    {
                        //T4 Row Added
                        table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusT4.Text, times))).BackgroundColor = BaseColor.YELLOW;

                    }
                    else if (totalT4Beds <= 20)
                    {
                        //T4 Row Added
                        table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusT4.Text, times))).BackgroundColor = BaseColor.ORANGE;

                    }

                    else if (totalT4Beds >= 20 && totalT4Beds <= 28)
                    {
                        //T4 Row Added
                        table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusT4.Text, times))).BackgroundColor = BaseColor.RED;

                    }




        #endregion


        #region 6ACU Column


                    PdfPTable table6ACU = new PdfPTable(new float[] { 1, 1, 1, 1, 1, 5, 1 });
                        table.WidthPercentage = 100;
                        table.HorizontalAlignment = Element.ALIGN_CENTER;
                        //table.SetWidths(new float[] { 2f, 6f, 6f, 3f, 5f, 8f, 5f, 5f, 5f, 5f });
                        table.AddCell(new PdfPCell(new Phrase("6ACU", times)));
                        table.AddCell(new PdfPCell(new Phrase(txtCurrentCensus6ACU.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtAvailableBeds6ACU.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtIsoPatientsICU.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtDischarges6ACU.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtNotes6ACU.Text, times)));
                       

 #endregion

        #region 6ACU Color Changer

                        int total6ACUBeds = 10;
                        total6ACUBeds = Convert.ToInt32(txtCurrentCensus6ACU.Text);


                        if (total6ACUBeds <= 3)
                        {
                            //6ACU Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatus6ACU.Text, times))).BackgroundColor = BaseColor.GREEN;

                        }
                        else if (total6ACUBeds <= 5)
                        {
                            //6ACU Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatus6ACU.Text, times))).BackgroundColor = BaseColor.YELLOW;
                        }

                        else if (total6ACUBeds <= 6)
                        {
                            //6ACU Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatus6ACU.Text, times))).BackgroundColor = BaseColor.ORANGE;
                        }

                        else if (total6ACUBeds >= 7 && total6ACUBeds <= 10)
                        {
                            //6ACU Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatus6ACU.Text, times))).BackgroundColor = BaseColor.RED;
                        }








    #endregion


        #region TBC Column

                        PdfPTable tableTBC = new PdfPTable(new float[] { 1, 1, 1, 1, 1, 5, 1 });
                        table.WidthPercentage = 100;
                        table.HorizontalAlignment = Element.ALIGN_CENTER;
                        //table.SetWidths(new float[] { 2f, 6f, 6f, 3f, 5f, 8f, 5f, 5f, 5f, 5f });
                        table.AddCell(new PdfPCell(new Phrase("TBC", times)));
                        table.AddCell(new PdfPCell(new Phrase(txtCurrentCensusTBC.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtAvailableBedsTBC.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtIsoPatientsTBC.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtDischargesTBC.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtNotesTBC.Text, times)));
                        

                        #endregion

        #region TBC Color Calculation
                        int totalTBCBeds = 10;
                        totalTBCBeds = Convert.ToInt32(txtCurrentCensusTBC.Text);


                        if (totalTBCBeds <= 3)
                        {
                            //TBC Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusTBC.Text, times))).BackgroundColor = BaseColor.GREEN;
                        }
                        else if (totalTBCBeds <= 5)
                        {
                            //TBC Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusTBC.Text, times))).BackgroundColor = BaseColor.YELLOW;
                        }

                        else if (totalTBCBeds <= 6)
                        {
                            //TBC Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusTBC.Text, times))).BackgroundColor = BaseColor.ORANGE;
                        }

                        else if (totalTBCBeds >= 7 && totalTBCBeds <= 10)
                        {
                            //TBC Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusTBC.Text, times))).BackgroundColor = BaseColor.RED;
                        }


                        #endregion


        #region BHU Column

                        PdfPTable tableBHU = new PdfPTable(new float[] { 1, 1, 1, 1, 1, 5, 1 });
                        table.WidthPercentage = 100;
                        table.HorizontalAlignment = Element.ALIGN_CENTER;
                        //table.SetWidths(new float[] { 2f, 6f, 6f, 3f, 5f, 8f, 5f, 5f, 5f, 5f });
                        table.AddCell(new PdfPCell(new Phrase("BHU", times)));
                        table.AddCell(new PdfPCell(new Phrase(txtCurrentCensusBHU.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtAvailableBedsBHU.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtIsoPatientsBHU.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtDischargesBHU.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(txtNotesBHU.Text, times)));
                        
                        #endregion

        #region BHU Color Calculation
                        int totalBHUBeds = 15;
                        totalBHUBeds = Convert.ToInt32(txtCurrentCensusBHU.Text);


                        if (totalBHUBeds <= 8)
                        {
                            //BHU Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusBHU.Text, times))).BackgroundColor = BaseColor.GREEN;
                        }
                        else if (totalBHUBeds <= 10)
                        {
                            //BHU Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusBHU.Text, times))).BackgroundColor = BaseColor.YELLOW;
                        }

                        else if (totalBHUBeds <= 11)
                        {
                            //BHU Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusBHU.Text, times))).BackgroundColor = BaseColor.ORANGE;
                        }

                        else if (totalBHUBeds >= 12 && totalBHUBeds <= 15)
                        {
                            //BHU Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCurrentCapStatusBHU.Text, times))).BackgroundColor = BaseColor.RED;
                        }

                        #endregion


        #region Total Census Column

                        PdfPTable tableTotal = new PdfPTable(new float[] { 1, 1, 1, 1, 1, 5, 1 });
                        table.WidthPercentage = 100;
                        table.HorizontalAlignment = Element.ALIGN_CENTER;
                        //table.SetWidths(new float[] { 2f, 6f, 6f, 3f, 5f, 8f, 5f, 5f, 5f, 5f });
                        table.AddCell(new PdfPCell(new Phrase("Total", times)));
                        table.AddCell(new PdfPCell(new Phrase(lblCCTotal.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(lblABTotal.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(lblISOTotal.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(lblTotalDC.Text, times)));
                        table.AddCell(new PdfPCell(new Phrase(lbltotalNotes.Text, times)));

        #endregion

        #region Total Census Color Calculation

                        int totalHospitalCensus = 129;
                        totalHospitalCensus = Convert.ToInt32(lblCCTotal.Text);


                        if (totalHospitalCensus <= 70)
                        {
                            //Total Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCCSTotal.Text, times))).BackgroundColor = BaseColor.GREEN;
                        }
                        else if (totalHospitalCensus <= 80)
                        {
                            //Total Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCCSTotal.Text, times))).BackgroundColor = BaseColor.YELLOW;
                        }

                        else if (totalHospitalCensus <= 90)
                        {
                            //Total Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCCSTotal.Text, times))).BackgroundColor = BaseColor.ORANGE;
                        }

                        else if (totalHospitalCensus >= 100 && totalHospitalCensus <= 129)
                        {

                            //Total Row Added
                            table.AddCell(new PdfPCell(new Phrase(txtCCSTotal.Text, times))).BackgroundColor = BaseColor.RED;
                        }

                        #endregion

                        //Add the table to our document
                        doc.Add(table);
                    /*************************************************/
                   

                    //Adds the inputted data to the PDF Table
                    

                    //Close document
                    doc.Close();
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
