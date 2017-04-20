using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;

namespace AppGestionCegep
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Cours> cours = new List<Cours>();
        static int compteur;
        static XDocument XDSource = new XDocument();
        static XElement XESource = new XElement("Cours","ok");

        public MainWindow()
        {
            //Initialisation
            InitializeComponent();
            //Proportions de tous les éléments à définir
            Disposition();
            compteur = cours.Capacity;
            Console.WriteLine(compteur);
           
            
          
            Type_Box.Items.Add("Programmes préuniversitaires");
            Type_Box.Items.Add("Programmes techniques");
            
            /////////////TESTS///////////////
            //Cours ok = new Cours("ok","ok","ok",15);
            // Console.WriteLine(ok.ToString());
            //CreerXML();


        }

        private void CreerCours(string type,string num,string nom,float heure)
        {
            cours.Add(new Cours(type, num, nom, heure));
            AjoutXDoc(type, num, nom, heure);
            List_Box.Items.Add(cours[compteur].ToString);
            Console.WriteLine(cours[compteur].ToString);
            compteur++;
        }

        private void Disposition()
        {

        }

        private void AjoutXDoc(string type, string num, string nom, float heure)
        {
            //xsource.Add(new XElement("Cours"+compteur, new XAttribute("type", type), new XAttribute("num", num), new XAttribute("nom", nom), new XAttribute("heure", heure)));
            XElement source = new XElement("Cours",compteur);
            XAttribute xtype = new XAttribute("type", type);
            XAttribute xnum = new XAttribute("num", num);
            XAttribute xnom = new XAttribute("nom", nom);
            XAttribute xheure = new XAttribute("heure", heure);
            XComment xcom = new XComment("c'est ok");
            source.Add(xtype, xnum, xnom, xheure,xcom);
            XESource.Add(source);

            /*
            xsource.Add(source);
            Console.WriteLine(xsource);
            */
        }


        private void SaveXML()
        {
            XDSource.Add(XESource);
            Console.WriteLine(XDSource);
            XDSource.Save(AppDomain.CurrentDomain.BaseDirectory + @"\test.cegep");
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Title = "Clicked";
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".text"; // Default file extension
            dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension
            
                        // Show save file dialog box
            Nullable < bool > result = dlg.ShowDialog();
            
                        // Process save file dialog box results
                        if (result == true)
                        {
                            // Save document
                            string filename = dlg.FileName;
                        }
            // Compose a string that consists of three lines.
            string lines = "First line.\r\nSecond line.\r\nThird line.";

            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter(".\test.txt");
            file.WriteLine(lines);

            file.Close();

        }

        private void TabItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(Width);
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
           
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            
            float er = (float)Convert.ToDouble(H_Cours.Text);
            bool valid = float.TryParse(H_Cours.Text.ToString(), out er);
            CreerCours(Type_Box.SelectionBoxItem.ToString(), Id_Champ.Text, Nom_Champ.Text, er);
            Console.WriteLine(er);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveXML();
        }
    }
}
