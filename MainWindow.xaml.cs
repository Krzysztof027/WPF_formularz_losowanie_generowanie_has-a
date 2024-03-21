using System;
using System.Collections.Generic;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        public string Haslo { get; set; }
        public MainWindow()
        {

            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String literyMale = "qwertyuiopasdfghjklzxcvbnm";
            String literyDuze = "QWERTYUIOPLKJHGFDSAZXCVBNM";
            String cyfry = "123456789";
            String znaki = "!@#$%^&*()_+?";
            Random random = new Random();
            int liczba;
            Haslo = "";

            if(Litery_chcb.IsChecked == true)
            {
                liczba = random.Next(0, literyDuze.Length);
                Haslo = Haslo + literyDuze[liczba];
            }

            if(Znaki_chkb.IsChecked == true)
            {
                liczba = random.Next(0, znaki.Length);
                Haslo = Haslo + znaki[liczba];

            }
            if(Cyfry_chcb.IsChecked == true)
            {
                liczba = random.Next(0, cyfry.Length);
                Haslo = Haslo + cyfry[liczba];
            }

            int dlugoschasla = Int32.Parse(ile_znakow.Text);
            for(int i=Haslo.Length; i < dlugoschasla; i++)
            {
                //losujemy liczbę i dopisujemy liczbę z indeksu
               liczba = random.Next(0, literyMale.Length);
                Haslo = Haslo + literyMale[liczba];


            }
            MessageBox.Show(Haslo);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dane pracownika: " + imie_TextBox.Text
                + " " + nazwisko_TextBox.Text + " " + stanowisko_Combobox.Text +  " Haslo  " +  Haslo  + " ");

        }
    }
}
