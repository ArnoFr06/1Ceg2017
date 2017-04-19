using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Xml;


namespace AppGestionCegep
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // hello world
            Cours a = new Cours("oui", "oui", 15);
            Console.WriteLine(Width);

            // tab1.Width = Width; 

          
            combo1.Items.Add("Programmes préuniversitaires");
            combo1.Items.Add("Programmes techniques");
            tab1.Height = 300;
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Title = "Clicked";
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".txt"; // Default file extension
            dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension
            
            // Show save file dialog box
            Nullable <bool> result = dlg.ShowDialog();

            // Process save file dialog box results
            if (result != null)
            {
                string filename = dlg.FileName; // Save document
            }
            // Compose a string that consists of three lines.
            string lines = "First line.\r\nSecond line.\r\nThird line.";

            // Write the string to a file.

           // StreamWriter file = new StreamWriter();
           // file.WriteLine(lines);
           // file.Close();
            
        }

       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(Width);
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            tab1.Width = Width;
            tab1.Height = Height;
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
