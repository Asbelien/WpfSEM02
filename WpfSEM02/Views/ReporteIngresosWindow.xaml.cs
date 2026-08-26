using System;
using System.Linq;
using System.Windows;
using WpfSEM02.Data;

namespace WpfSEM02.Views
{
    public partial class ReporteIngresosWindow : Window
    {
        public ReporteIngresosWindow()
        {
            InitializeComponent();
            dgIngresos.ItemsSource = DataStore.Ingresos;
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            var resultado = DataStore.Ingresos.AsEnumerable();

            if (dpFechaInicio.SelectedDate.HasValue)
                resultado = resultado.Where(i => i.FechaHora.Date >= dpFechaInicio.SelectedDate.Value.Date);

            if (dpFechaFin.SelectedDate.HasValue)
                resultado = resultado.Where(i => i.FechaHora.Date <= dpFechaFin.SelectedDate.Value.Date);

            if (!string.IsNullOrWhiteSpace(txtFiltroPlaca.Text))
                resultado = resultado.Where(i => i.Placa.Contains(txtFiltroPlaca.Text, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrWhiteSpace(txtFiltroConductor.Text))
                resultado = resultado.Where(i => i.NombreConductor.Contains(txtFiltroConductor.Text, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrWhiteSpace(txtFiltroProducto.Text))
                resultado = resultado.Where(i => i.NombreProducto.Contains(txtFiltroProducto.Text, StringComparison.OrdinalIgnoreCase));

            dgIngresos.ItemsSource = resultado.ToList();
        }
    }
}