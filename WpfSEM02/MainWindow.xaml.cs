using System.Windows;
using WpfSEM02.Data;

namespace WpfSEM02
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Password;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Debes ingresar usuario y contraseña.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (usuario == DataStore.UsuarioValido && password == DataStore.PasswordValido)
            {
                Views.MenuWindow menu = new Views.MenuWindow();
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Validación", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}