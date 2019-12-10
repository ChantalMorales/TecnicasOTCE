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
using System.Windows.Shapes;

namespace OrdenesTrabajo
{
    /// <summary>
    /// Lógica de interacción para VentanaOrdenes.xaml
    /// </summary>
    public partial class VentanaOrdenes : Window
    {
        public VentanaOrdenes()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource ordenViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("ordenViewSource")));
            // Cargar datos estableciendo la propiedad CollectionViewSource.Source:
            // ordenViewSource.Source = [origen de datos genérico]
            System.Windows.Data.CollectionViewSource equipoViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("equipoViewSource")));
            // Cargar datos estableciendo la propiedad CollectionViewSource.Source:
            // equipoViewSource.Source = [origen de datos genérico]
        }
    }
}
