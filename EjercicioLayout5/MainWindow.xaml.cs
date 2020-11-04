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

namespace EjercicioLayout5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            int cont = 1;
            InitializeComponent();
            for (int x = 2; x < 5; x++) 
            {
                for (int i = 0; i < 3; i++)
                {
                    Button b = new Button();
                    TextBlock text = new TextBlock();
                    text.Text = cont.ToString();
                    b.Content = cont;
                    b.Tag = cont.ToString();
                    b.Style = (Style)this.Resources["estiloNum"];
                    b.Click += NumeroButton_Click;
                    Grid.SetColumn(b, i);
                    Grid.SetRow(b, x);
                    grid.Children.Add(b);
                    cont++;
                }
            }
        }

        private void NumeroButton_Click(object sender, RoutedEventArgs e)
        {

            Button boton = (Button)sender;

            
            OperacionTextBlock.Text += boton.Content.ToString();

        }
    }
}
