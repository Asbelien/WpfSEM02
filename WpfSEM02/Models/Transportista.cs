namespace WpfSEM02.Models
{
    public class Transportista
    {
        public string NombreTransportista { get; set; } = string.Empty;
        public string RUC { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;

        public override string ToString()
        {
            return NombreTransportista;
        }
    }
}