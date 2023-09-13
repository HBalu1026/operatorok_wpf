using Microsoft.Win32;
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
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    class Beolvasas
    {
        public int op1, op2;
        public string operato;

        public Beolvasas(int op1, string operato, int op2)
        {
            this.op1 = op1;
            this.operato = operato;
            this.op2 = op2;
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void fajlBeolvasas(object sender, RoutedEventArgs e)
        {
            var tombHossz = 0;
            var fajl = new OpenFileDialog();
            if (fajl.ShowDialog() == true)
            {
                lbEleres.Content = fajl.FileName;

            }
            string eleresiUt = fajl.FileName;
            string[] beolvasott = File.ReadAllLines(eleresiUt, Encoding.UTF8);
            List<Beolvasas> beolvasottTomb = new List<Beolvasas>();
            for (int i = 0; i < beolvasott.Length; i++)
            {
                string[] splitelt = beolvasott[i].Split(' ');
                beolvasottTomb.Add(new Beolvasas(Convert.ToInt32(splitelt[0]), (splitelt[1]), Convert.ToInt32(splitelt[2])));
                tombHossz++;
            }

            //2
            lbMasodikFeladat.Content = tombHossz.ToString();

            //3


        }
        
        
    }
}
  