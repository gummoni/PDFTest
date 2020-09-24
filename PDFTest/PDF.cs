using System.Diagnostics;

namespace PDFTest
{
    public class PDF
    {
        /// <summary>
        /// HTML→PDF変換
        /// </summary>
        /// <param name="inputFilename"></param>
        /// <param name="outputFilename"></param>
        public static void HtmlToPdf(string inputFilename, string outputFilename)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = "wkhtmltopdf.exe",
                Arguments = $"-O Landscape -n --enable-local-file-access {inputFilename} {outputFilename}",
                UseShellExecute = true,
                CreateNoWindow = false,
            });
        }

        /// <summary>
        /// PDFを開く
        /// </summary>
        /// <param name="pdfFilename"></param>
        public static void OpenPdf(string pdfFilename)
        {
            Process.Start("cmd.exe", $"/c {pdfFilename}");
        }
    }
}
