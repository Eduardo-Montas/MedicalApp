using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApp.Aplication.DTOs.Request.Empleado
{
    public class CreateMedicoDTO
    {
        [Required(ErrorMessage = "El número de colegiado es obligatorio")]
        public string? NumeroColegiado { get; set; }

        [Required(ErrorMessage = "El tipo de médico es requerido")]
        public string? Tipo { get; set; }  // Asumo que debería ser "TipoMedico" si usas un enum

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Los apellidos son obligatorios")]
        public string? Apellidos { get; set; }

    }
}
