using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApp.Aplication.DTOs.Response.Empleado
{
    internal class GetMedicoResponseDTO
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? Email { get; set; }

        // Campos específicos de Médico
        public string? NumeroColegiado { get; set; }
        public string? TipoMedico { get; set; } 
    }
}
