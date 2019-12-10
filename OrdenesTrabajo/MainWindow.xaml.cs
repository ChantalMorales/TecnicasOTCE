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
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace OrdenesTrabajo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OrdenesTrabajoEntities context = new OrdenesTrabajoEntities();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            context.Usuario.Load();
           
            
            System.Windows.Data.CollectionViewSource usuarioViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("usuarioViewSource")));
            // Cargar datos estableciendo la propiedad CollectionViewSource.Source:
            // usuarioViewSource.Source = [origen de datos genérico]
        }

        private void contrasenaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {

            grid1.Visibility = Visibility.Visible;
            grid2.Visibility = Visibility.Visible;

            // Clear all the text boxes before adding a new customer.  
            foreach (var child in grid1.Children)
            {
                var tb = child as TextBox;
                if (tb != null)
                {
                    tb.Text = "";
                }
            }
            foreach (var child in grid2.Children)
            {
                var tb = child as TextBox;
                if (tb != null)
                {
                    tb.Text = "";
                }
            }
        }
    }
}
