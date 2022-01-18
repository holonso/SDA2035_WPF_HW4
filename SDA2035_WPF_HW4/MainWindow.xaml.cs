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

namespace SDA2035_WPF_HW4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_DollarConvert(object sender, RoutedEventArgs e)
        {
            double dollarRate = Convert.ToDouble(tb_dollarRate.Text);
            double rub4Dollar = Convert.ToDouble(tb_rub4Dollar.Text);
            double resDollar = rub4Dollar * dollarRate;
            tb_resDollar.Text = resDollar.ToString();
        }

        private void Button_Click_EuroConvert(object sender, RoutedEventArgs e)
        {
            double euroRate = Convert.ToDouble(tb_euroRate.Text);
            double rub4Euro = Convert.ToDouble(tb_rub4Euro.Text);
            double resEuro = rub4Euro * euroRate;
            tb_resEuro.Text = resEuro.ToString();
        }

        private void Button_Click_GrivnaConvert(object sender, RoutedEventArgs e)
        {
            double grivnaRate = Convert.ToDouble(tb_grivnaRate.Text);
            double rub4Grivna = Convert.ToDouble(tb_rub4Grivna.Text);
            double resGrivna = grivnaRate * rub4Grivna;
            tb_resGrivna.Text = resGrivna.ToString();
        }

        private void Button_Click_DramaConvert(object sender, RoutedEventArgs e)
        {
            double dramaRate = Convert.ToDouble(tb_dramaRate.Text);
            double rub4Drama = Convert.ToDouble(tb_rub4Drama.Text);
            double resDrama = dramaRate * rub4Drama;
            tb_resDrama.Text = resDrama.ToString();
        }

        private void Button_Click_InchesConvert(object sender, RoutedEventArgs e)
        {
            double inches = Convert.ToDouble(tb_inches.Text);
            double resInches = inches * 0.0254;
            tb_resInches.Text = resInches.ToString();
        }

        private void Button_Click_FeetConvert(object sender, RoutedEventArgs e)
        {
            double feet = Convert.ToDouble(tb_feet.Text);
            double resFeet = feet * 0.3048;
            tb_resFeet.Text = resFeet.ToString();
        }

        private void Button_Click_MilesConvert(object sender, RoutedEventArgs e)
        {
            double miles = Convert.ToDouble(tb_miles.Text);
            double resMiles = miles * 1609.34;
            tb_resMiles.Text = resMiles.ToString();
        }

        private void Button_Click_VerstsConvert(object sender, RoutedEventArgs e)
        {
            double versts = Convert.ToDouble(tb_versts.Text);
            double resVersts = versts * 1066.8;
            tb_resVersts.Text = resVersts.ToString();
        }
    }
}
