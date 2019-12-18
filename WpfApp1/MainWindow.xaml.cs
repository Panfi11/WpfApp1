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

namespace WpfApp1
{

    public partial class MainWindow : Window
    {
        private const string file_name = "mokup.txt";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                string nome = txtnome.Text;
                string cognome = txtcognome.Text;
                DateTime data = txtcalendario.SelectedDate.Value;
                if (nome == "" || cognome == "")
                {
                    MessageBox.Show($"Error , insert name and surname");
                }
                else if (data > DateTime.Today)
                {
                    MessageBox.Show("error, insert value date");
                }
                else
                {
                    MessageBox.Show($"hello {nome} {cognome} {data.ToShortDateString()}");
                }


            }
        }

        private void btnprint_Click(object sender, RoutedEventArgs e)
        {

            string nome = txtnome.Text;
            string cognome = txtcognome.Text;
            DateTime data = txtcalendario.SelectedDate.Value;
            try
            {
                using (StreamWriter w = new StreamWriter(file_name, true))
                {
                    w.WriteLine($"{nome} {cognome} {data}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void checkagree_Checked(object sender, RoutedEventArgs e)
        {
            btnprint.IsEnabled = true;
        }

        private void checkagree_Unchecked(object sender, RoutedEventArgs e)
        {
            btnprint.IsEnabled = false;
        }





    }
}




        
