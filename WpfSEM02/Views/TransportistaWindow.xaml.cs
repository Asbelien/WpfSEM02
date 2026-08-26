using System.Windows;
using WpfSEM02.Data;
using WpfSEM02.Models;

namespace WpfSEM02.Views
{
    public partial class TransportistaWindow : Window
    {
        public TransportistaWindow()
        {
            InitializeComponent();
            dgTransportistas.ItemsSource = DataStore.Transportistas;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtRUC.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            DataStore.Transportistas.Add(new Transportista
            {
                NombreTransportista = txtNombre.Text,
                RUC = txtRUC.Text,
                Telefono = txtTelefono.Text
            });

            txtNombre.Clear();
            txtRUC.Clear();
            txtTelefono.Clear();

            dgTransportistas.Items.Refresh();
        }
    }
}