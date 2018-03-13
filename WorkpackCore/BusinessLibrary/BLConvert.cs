using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using DomainModelLibrary;

namespace BusinessLibrary
{
    //using tessnet2;
    using System;
    class BLConvert
    {
        //public static void convrtfile(string sourcePdfFilePath)
        //{
        //   // System.Web.HttpContext.Current.Server.MapPath(path);
        //    //sourcePdfFilePath = "D:\\test\\offer.pdf";
           
        //    string FilescanndPath = System.Web.HttpContext.Current.Server.MapPath("~/images/test/scanned image/");
        //    string FiletextPath = System.Web.HttpContext.Current.Server.MapPath("~/images/test/textfiles/");
          
        //        if (!System.IO.Directory.Exists(FilescanndPath))
        //        {
        //            System.IO.Directory.CreateDirectory(FilescanndPath);
        //        }
        //        if (!System.IO.Directory.Exists(FiletextPath))
        //        {
        //            System.IO.Directory.CreateDirectory(FiletextPath);
        //        }
           
        //    string destDir = System.Web.HttpContext.Current.Server.MapPath("~/images/test/scanned image/Ex612%d.jpeg");
        //    //var destinationPngFilePath = "E:\\EntityFrameWork\\WorkPackFremiumApplication\\WorkPackFremiumApplication\\images\\test\\scanned image\\Ex612%d.jpeg";
        //    var destinationPngFilePath = destDir;
        //    // Generate PDF Thumbnail
        //    GetPdfThumbnail(sourcePdfFilePath, destinationPngFilePath);
        //    string path = System.Web.HttpContext.Current.Server.MapPath("~/images/test/textfiles/p.txt");
        //    //string path = "E:\\WorkPackFremiumApplicationTest\\WorkPackFremiumApplication\\images\\test\\textfiles\\p.txt";
        //    //File.Delete("D:\\test\\scanned image\\Ex612.jpeg");

        //    int i;
        //    string imagedir = System.Web.HttpContext.Current.Server.MapPath("~/images/test/scanned image/");
        //    string[] ImagePaths = Directory.GetFiles(imagedir);
        //    int j = ImagePaths.Count();
        //    try
        //    {
        //        for (i = 1; i <= j; i++)
        //        {
        //           // int ss =Convert.ToInt32("");

        //            Bitmap image = new Bitmap(imagedir + '/' + "Ex612" + i + ".jpeg");
        //            var ocr = new Tesseract();
        //            string tessdatadir = System.Web.HttpContext.Current.Server.MapPath("~/images/test/tessdata/");
        //            ocr.Init(tessdatadir, "eng", false);
        //            var result = ocr.DoOCR(image, Rectangle.Empty);
        //            //  ocr.GetThresholdedImage(image, Rectangle.Empty).Save("c:\\temp\\" + Guid.NewGuid().ToString() + ".bmp");
        //            foreach (Word word in result)
        //            {
        //                string wr = word.Text;
        //                //Console.WriteLine("{0} ", word.Text);
        //                if (!File.Exists(path))
        //                {
        //                    File.WriteAllText(path, " " + wr);
        //                }
        //                else
        //                {
        //                    File.AppendAllText(path, " " + wr);
        //                }
        //            }
        //            image.Dispose();

        //            File.Delete(imagedir + '/' + "Ex612" + i + ".jpeg");
        //            // File.Delete(path);

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        bool false = UserInterfaceExceptionHandler.HandleException(ref ex);
        //    }

        //}


        //private static void GetPdfThumbnail(string sourcePdfFilePath, string destinationPngFilePath)
        //{
        //    // Use GhostscriptSharp to convert the pdf to a png
        //    GhostscriptWrapper.GenerateOutput(sourcePdfFilePath, destinationPngFilePath,
        //        new GhostscriptSettings
        //        {
        //            Device = GhostscriptDevices.pngalpha,
        //            Page = new GhostscriptPages
        //            {
        //                // Only make a thumbnail of the first page
        //                Start = 1,
        //                End = 8,
        //                AllPages = true
        //            },
        //            Resolution = new Size
        //            {
        //                // Render at 72x72 dpi

        //                Height = 400,
        //                Width = 400
        //            },
        //            Size = new GhostscriptPageSize
        //            {
        //                // The dimentions of the incoming PDF must be
        //                // specified. The example PDF is US Letter sized.
        //                Native = GhostscriptPageSizes.a4
        //            }
        //        }
        //    );

        //}







    }
}
