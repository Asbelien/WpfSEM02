using System;

namespace WpfSEM02.Models
{
    public class Ingreso
    {
        public string TipoDocumento { get; set; } = string.Empty;
        public string NumeroDocumento { get; set; } = string.Empty;
        public string Placa { get; set; } = string.Empty;
        public string Turno { get; set; } = string.Empty;
        public string NombreConductor { get; set; } = string.Empty;
        public string NombreCliente { get; set; } = string.Empty;
        public DateTime FechaHora { get; set; } = DateTime.Now;
        public double PesoIngreso { get; set; }

        // Usados en el reporte de ingresos
        public string NombreProducto { get; set; } = string.Empty;
        public string Transporte { get; set; } = string.Empty;
    }
}