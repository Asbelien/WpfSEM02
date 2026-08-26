using System.Windows;
using WpfSEM02.Data;
using WpfSEM02.Models;

namespace WpfSEM02.Views
{
    public partial class ProductoWindow : Window
    {
        public ProductoWindow()
        {
            InitializeComponent();
            dgProductos.ItemsSource = DataStore.Productos;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) || string.IsNullOrWhiteSpace(txtUnidad.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            DataStore.Productos.Add(new Producto
            {
                NombreProducto = txtNombreProducto.Text,
                Unidad = txtUnidad.Text
            });

            txtNombreProducto.Clear();
            txtUnidad.Clear();

            dgProductos.Items.Refresh();
        }
    }
}