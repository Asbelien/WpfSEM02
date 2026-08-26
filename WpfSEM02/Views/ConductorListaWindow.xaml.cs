using System.Windows;
using WpfSEM02.Data;

namespace WpfSEM02.Views
{
    public partial class ConductorListaWindow : Window
    {
        public ConductorListaWindow()
        {
            InitializeComponent();
            CargarConductores();
        }

        private void CargarConductores()
        {
            dgConductores.ItemsSource = DataStore.Conductores;
        }
    }
}