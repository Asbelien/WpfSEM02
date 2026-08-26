namespace WpfSEM02.Models
{
    public class Producto
    {
        public string NombreProducto { get; set; } = string.Empty;
        public string Unidad { get; set; } = string.Empty;

        public override string ToString()
        {
            return NombreProducto;
        }
    }
}