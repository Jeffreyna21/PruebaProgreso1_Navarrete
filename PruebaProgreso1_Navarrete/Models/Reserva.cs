using System.ComponentModel.DataAnnotations;

namespace PruebaProgreso1_Navarrete.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaEntrada { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaSalida { get; set; }
        [DataType(DataType.Currency)]
        public decimal Precio { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
