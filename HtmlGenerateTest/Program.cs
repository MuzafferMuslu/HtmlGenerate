using SelectPdf;
using System;

namespace HtmlGenerateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string htmlContent = System.IO.File.ReadAllText("HTMLPage1.html");

            HtmlToPdf converter = new HtmlToPdf();

            PdfDocument doc = converter.ConvertHtmlString(htmlContent);

            doc.Save("C:/Users/yasin/source/test.pdf");
            doc.Close();
        }
    }
}
