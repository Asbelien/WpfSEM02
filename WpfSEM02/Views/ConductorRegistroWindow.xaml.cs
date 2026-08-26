using System.Windows;
using WpfSEM02.Data;
using WpfSEM02.Models;

namespace WpfSEM02.Views
{
    public partial class ConductorRegistroWindow : Window
    {
        public ConductorRegistroWindow()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreConductor.Text) ||
                string.IsNullOrWhiteSpace(txtLicencia.Text) ||
                string.IsNullOrWhiteSpace(txtTransporte.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Conductor nuevoConductor = new Conductor
            {
                NombreConductor = txtNombreConductor.Text,
                Licencia = txtLicencia.Text,
                Transporte = txtTransporte.Text
            };

            DataStore.Conductores.Add(nuevoConductor);

            MessageBox.Show("Conductor registrado correctamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }
    }
}