using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApp.Aplication.DTOs.Request.Empleado
{
    internal class CreatePacienteDTO
    {
        [Required(ErrorMessage = "El ID del médico asignado es obligatorio")]
        public int MedicoAsignadoId { get; set; }

        // Campos heredados de Persona
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Los apellidos son obligatorios")]
        public string? Apellidos { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public string? Telefono { get; set; }
    }
}
