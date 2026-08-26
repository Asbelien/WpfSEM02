using System.Windows;
using WpfSEM02.Data;
using WpfSEM02.Models;

namespace WpfSEM02.Views
{
    public partial class CamionWindow : Window
    {
        public CamionWindow()
        {
            InitializeComponent();
            dgCamiones.ItemsSource = DataStore.Camiones;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlaca.Text) || string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) || string.IsNullOrWhiteSpace(txtTransporte.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            DataStore.Camiones.Add(new Camion
            {
                Placa = txtPlaca.Text,
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Transporte = txtTransporte.Text
            });

            txtPlaca.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtTransporte.Clear();

            dgCamiones.Items.Refresh();
        }
    }
}