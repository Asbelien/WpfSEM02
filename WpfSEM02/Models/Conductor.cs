namespace WpfSEM02.Models
{
    public class Conductor
    {
        public string NombreConductor { get; set; } = string.Empty;
        public string Licencia { get; set; } = string.Empty;
        public string Transporte { get; set; } = string.Empty;

        public override string ToString()
        {
            return NombreConductor;
        }
    }
}