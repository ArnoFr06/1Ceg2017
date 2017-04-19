using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public MainWindow()
        {
            //Initialisation
            InitializeComponent();
            //Proportions de tous les éléments à définir
            Disposition();
            compteur = cours.Capacity;
            Console.WriteLine(compteur);
            /////////////TESTS///////////////
            //Cours ok = new Cours("ok","ok","ok",15);
            // Console.WriteLine(ok.ToString());
            //CreerXML();


        }

        private void CreerCours(string type,string num,string nom,float heure)
        {
            cours.Add(new Cours(type, num, nom, heure));
            List_Box.Items.Add(cours[compteur].ToString);
            Console.WriteLine(cours[compteur].ToString);
            compteur++;
        }

        private void Disposition()
        {

        }

        private void CreerXML()
        {
            XDocument srcTree = new XDocument();

            srcTree.Add(new XElement("ok", new XAttribute("ok", "ok")));











            XDocument xdoc = new XDocument(
                new XElement("graphml",
                    new XAttribute("xmlsn", "http://graphml.graphdrawing.org/xmlns"),
                    new XElement("graph",
                        new XAttribute("id", "test"),
                        new XElement("node",
                            new XAttribute("id", "1")), // switch 1
                        new XElement("node",
                            new XAttribute("id", "2")), // switch 2
                        new XElement("node",
                            new XAttribute("id", "3")),
                        new XElement("edge",
                            new XAttribute("id", "1to2"),
                            new XAttribute("source", "1"),
                            new XAttribute("target", "2")),
                        new XElement("edge",
                            new XAttribute("id", "1to3"),
                            new XAttribute("source", "1"),
                            new XAttribute("target", "3")),
                        new XElement("edge",
                            new XAttribute("id", "2to3"),
                            new XAttribute("source", "2"),
                            new XAttribute("target", "3")))));

            Console.WriteLine(srcTree);
            //xdoc.Save(AppDomain.CurrentDomain.BaseDirectory + @"\gmlFile\test.gml");






            /*new XComment("This is a comment"),
         new XElement("Root",
         new XElement("Child1", "data1"),
         new XElement("Child2", "data2"),
         new XElement("Child3", "data3"),
         new XElement("Child2", "data4"),
         new XElement("Info5", "info5"),
         new XElement("Info6", "info6"),
         new XElement("Info7", "info7"),
         new XElement("Info8", "info8")
        )
        );

        XDocument doc = new XDocument(
            new XComment("This is a comment"),
            new XElement("Root",
                from el in srcTree.Element("Root").Elements()
                where ((string)el).StartsWith("data")
                select el
            )
        );
        Console.WriteLine(doc);*/
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
            
            
            if (Id_Champ.Text != "" && Nom_Champ.Text != "" && H_Cours.Text != "")
            {
                if (Regex.IsMatch(H_Cours.Text, "^[0-9]+,{0,1}[0-9]*$"))
                {
                    float er = (float)Convert.ToDouble(H_Cours.Text);
                    bool valid = float.TryParse(H_Cours.Text.ToString(), out er);
                    CreerCours(Type_Box.SelectionBoxItem.ToString(), Id_Champ.Text, Nom_Champ.Text, er);
                }
                else
                    MessageBox.Show("Heure cours doit être uniquement composé de chifres");
            } else
            {
                MessageBox.Show("Vous devez remplir tout les champs", "Erreur");
            }
        }


        private void suppr_button(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Type_Box_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
