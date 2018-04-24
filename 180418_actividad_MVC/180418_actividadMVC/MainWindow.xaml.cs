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

namespace _180418_actividadMVC
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Controlador control = new Controlador();


        private void Resta_Click(object sender, RoutedEventArgs e)
        {
         
            Respuesta.Text=  control.resta(Primero.Text, Segundo.Text);
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
           
            Respuesta.Text = control.div(Primero.Text, Segundo.Text);
        }

        private void Multiplicacion_Click(object sender, RoutedEventArgs e)
        {
           
            Respuesta.Text = control.multi(Primero.Text, Segundo.Text);
        }

        private void ANS_Click(object sender, RoutedEventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(Primero.Text))
            {
                Primero.Text = control.Ans();
            }
            else if (string.IsNullOrWhiteSpace(Segundo.Text))
            {
                Segundo.Text = control.Ans();
            }
            else { MessageBox.Show("Borre el numero de una de las casillas por favor"); }
        }

        private void suma_click(object sender, RoutedEventArgs e)
        {
            

            Respuesta.Text = control.suma(Primero.Text, Segundo.Text);
        }
    }
}