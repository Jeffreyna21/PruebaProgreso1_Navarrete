using Microsoft.AspNetCore.Components.Web;
using System.ComponentModel.DataAnnotations;

namespace PruebaProgreso1_Navarrete.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Apellido es obligatorio.")]
        public string Apellido { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [DataType(DataType.Currency)]
        public decimal Saldo { get; set; }
        public bool EsVIP { get; set; }

        //relacion
        public PlanRecompensa planRecompensa { get; set; }
    }
}
