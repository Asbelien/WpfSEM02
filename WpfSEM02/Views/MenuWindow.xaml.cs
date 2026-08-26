using System.Windows;

namespace WpfSEM02.Views
{
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void MenuIngresos_Click(object sender, RoutedEventArgs e)
        {
            new IngresoWindow().Show();
        }

        private void MenuSalidas_Click(object sender, RoutedEventArgs e)
        {
            new SalidaWindow().Show();
        }

        private void MenuConductorRegistro_Click(object sender, RoutedEventArgs e)
        {
            new ConductorRegistroWindow().Show();
        }

        private void MenuConductorLista_Click(object sender, RoutedEventArgs e)
        {
            new ConductorListaWindow().Show();
        }

        private void MenuTransportistas_Click(object sender, RoutedEventArgs e)
        {
            new TransportistaWindow().Show();
        }

        private void MenuCamiones_Click(object sender, RoutedEventArgs e)
        {
            new CamionWindow().Show();
        }

        private void MenuProductos_Click(object sender, RoutedEventArgs e)
        {
            new ProductoWindow().Show();
        }

        private void MenuReporteCargas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ventana de Reporte de Cargas pendiente de implementar.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuReporteIngresos_Click(object sender, RoutedEventArgs e)
        {
            new ReporteIngresosWindow().Show();
        }

        private void MenuReporteSalidas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ventana de Reporte de Salidas pendiente de implementar.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}