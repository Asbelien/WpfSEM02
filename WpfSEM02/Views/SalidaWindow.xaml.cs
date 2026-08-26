using System;
using System.Windows;
using System.Windows.Controls;
using WpfSEM02.Data;
using WpfSEM02.Models;

namespace WpfSEM02.Views
{
    public partial class SalidaWindow : Window
    {
        public SalidaWindow()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (cmbTipoDocumento.SelectedItem == null || string.IsNullOrWhiteSpace(txtNumeroDocumento.Text) ||
                string.IsNullOrWhiteSpace(txtPlaca.Text) || cmbTurno.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtNombreConductor.Text) || string.IsNullOrWhiteSpace(txtNombreCliente.Text) ||
                dpFechaHora.SelectedDate == null || string.IsNullOrWhiteSpace(txtPesoSalida.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!double.TryParse(txtPesoSalida.Text, out double peso))
            {
                MessageBox.Show("El peso de salida debe ser un número válido.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Salida nuevaSalida = new Salida
            {
                TipoDocumento = ((ComboBoxItem)cmbTipoDocumento.SelectedItem).Content.ToString() ?? string.Empty,
                NumeroDocumento = txtNumeroDocumento.Text,
                Placa = txtPlaca.Text,
                Turno = ((ComboBoxItem)cmbTurno.SelectedItem).Content.ToString() ?? string.Empty,
                NombreConductor = txtNombreConductor.Text,
                NombreCliente = txtNombreCliente.Text,
                FechaHora = dpFechaHora.SelectedDate ?? DateTime.Now,
                PesoSalida = peso
            };

            DataStore.Salidas.Add(nuevaSalida);

            MessageBox.Show("Salida registrada correctamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }
    }
}