namespace WpfSEM02.Models
{
    public class Camion
    {
        public string Placa { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public string Transporte { get; set; } = string.Empty;

        public override string ToString()
        {
            return Placa;
        }
    }
}