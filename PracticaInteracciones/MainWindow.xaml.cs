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

namespace PracticaSlider
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtCuenta.Text = "Texto Modificado";
        }

        private void sldPorcentaje_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbPorcntaje.Text = ((int)sldPorcentaje.Value).ToString() + "%";
            float cuenta = float.Parse(txtCuenta.Text);

            float motoPropina = (int)(sldPorcentaje.Value) / 100.0f * cuenta;

            float totalPagar = cuenta + motoPropina;

            Totalconpropina.Text = "$" + totalPagar.ToString();
        }
    }
}