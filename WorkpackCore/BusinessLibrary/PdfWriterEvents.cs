using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace BusinessLogic
{
   public static class PdfWriterEvents 
    {
       public static byte[] WriteToPdf(string sourceFile, string stringToWriteToPdf)
       {
           PdfReader reader = new PdfReader(sourceFile);
           using (MemoryStream memoryStream = new MemoryStream())
           {
                PdfStamper pdfStamper = new PdfStamper(reader, memoryStream);
               for (int i = 1; i <= reader.NumberOfPages; i++)
               {
                   Rectangle pageSize = reader.GetPageSizeWithRotation(i);
                   float textAngle = (float)FooTheoryMath.GetHypotenuseAngleInDegreesFrom(pageSize.Height, pageSize.Width);
                   int rotation = pageSize.Rotation;
                   if (rotation > 0 && rotation!=90)
                       textAngle = -textAngle;
                   PdfContentByte pdfPageContents = pdfStamper.GetOverContent(i);
                   //pageSize.Rotation = 0;
                    //PdfDictionary pageDict = reader.GetPageN(i);
                    //int desiredRot = 0; // 90 degrees clockwise from what it is now
                    //PdfNumber rotation = pageDict.GetAsNumber(PdfName.ROTATE);
                    //if (rotation != null) {
                    //    desiredRot += rotation.IntValue;
                    //    desiredRot %= 360; // must be 0, 90, 180, or 270
                    //}
                    //pageDict.Put(PdfName.ROTATE, new PdfNumber(0));


                   PdfGState gstate = new PdfGState();
                   gstate.FillOpacity = 0.3f;
                   gstate.StrokeOpacity=0.5f; 
                   pdfPageContents.SaveState();
                   pdfPageContents.SetGState(gstate);
                   //pdfPageContents.SetColorFill(BaseColor.GRAY);
                   pdfPageContents.BeginText();
                  
                  // BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                   float size=60;
                   if(pageSize.Width>1600)
                       size=150;
                   pdfPageContents.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), size);
                  // pdfPageContents.SetRGBColorFill(0, 0, 0);
                 
                   pdfPageContents.ShowTextAligned(PdfContentByte.ALIGN_CENTER, stringToWriteToPdf, pageSize.Width / 2, pageSize.Height / 2, textAngle);
                   pdfPageContents.EndText();

               }
               pdfStamper.RotateContents = false;
               pdfStamper.FormFlattening = true;
               pdfStamper.Close();
               //memoryStream.Close();
               reader.Close();
               return memoryStream.ToArray();
           }
       }
    }
   public static class FooTheoryMath
   {
       public static double GetHypotenuseAngleInDegreesFrom(double opposite, double adjacent)
       {
           double radians = Math.Atan2(opposite, adjacent); // Get Radians for Atan2
           double angle = radians * (180 / Math.PI); // Change back to degrees
           return angle;
       }
   }
}

    