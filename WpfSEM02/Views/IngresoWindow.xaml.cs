using System;
using System.Windows;
using System.Windows.Controls;
using WpfSEM02.Data;
using WpfSEM02.Models;

namespace WpfSEM02.Views
{
    public partial class IngresoWindow : Window
    {
        public IngresoWindow()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (cmbTipoDocumento.SelectedItem == null || string.IsNullOrWhiteSpace(txtNumeroDocumento.Text) ||
                string.IsNullOrWhiteSpace(txtPlaca.Text) || cmbTurno.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtNombreConductor.Text) || string.IsNullOrWhiteSpace(txtNombreCliente.Text) ||
                dpFechaHora.SelectedDate == null || string.IsNullOrWhiteSpace(txtPesoIngreso.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!double.TryParse(txtPesoIngreso.Text, out double peso))
            {
                MessageBox.Show("El peso de ingreso debe ser un número válido.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Ingreso nuevoIngreso = new Ingreso
            {
                TipoDocumento = ((ComboBoxItem)cmbTipoDocumento.SelectedItem).Content.ToString() ?? string.Empty,
                NumeroDocumento = txtNumeroDocumento.Text,
                Placa = txtPlaca.Text,
                Turno = ((ComboBoxItem)cmbTurno.SelectedItem).Content.ToString() ?? string.Empty,
                NombreConductor = txtNombreConductor.Text,
                NombreCliente = txtNombreCliente.Text,
                FechaHora = dpFechaHora.SelectedDate ?? DateTime.Now,
                PesoIngreso = peso
            };

            DataStore.Ingresos.Add(nuevoIngreso);

            MessageBox.Show("Ingreso registrado correctamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }
    }
}