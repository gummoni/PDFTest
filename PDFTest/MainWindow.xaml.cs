using System;
using System.IO;
using System.Windows;

namespace PDFTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var filename = Path.Combine(currentDirectory, "cobas2.png");
            var uri = new Uri(filename);
            var html = string.Format(File.ReadAllText("template.html"), uri.AbsoluteUri);
            File.WriteAllText("temp.html", html);
            PDF.HtmlToPdf("temp.html", "test.pdf");
            PDF.OpenPdf("test.pdf");
        }
    }
}
