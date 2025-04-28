using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace PruebaProgreso1_Navarrete.Models
{
    public class PlanRecompensa
    {
        public int Id { get; set; }
        [Required]
        public String Nombre { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }
        public int PuntosAcumulados { get; set; }
        public String TipoRecompensa { get; set; }

    }
}
