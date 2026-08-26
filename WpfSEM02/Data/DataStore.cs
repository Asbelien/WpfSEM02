using System.Collections.Generic;
using WpfSEM02.Models;

namespace WpfSEM02.Data
{
    public static class DataStore
    {
        public static List<Conductor> Conductores { get; set; } = new List<Conductor>();
        public static List<Transportista> Transportistas { get; set; } = new List<Transportista>();
        public static List<Camion> Camiones { get; set; } = new List<Camion>();
        public static List<Producto> Productos { get; set; } = new List<Producto>();
        public static List<Ingreso> Ingresos { get; set; } = new List<Ingreso>();
        public static List<Salida> Salidas { get; set; } = new List<Salida>();

        public static string UsuarioValido { get; set; } = "admin";
        public static string PasswordValido { get; set; } = "admin";
    }
}