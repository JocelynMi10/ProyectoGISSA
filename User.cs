using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class User : BaseDTO
    { 
        public string TipoUsuario { get; set; }
        public string TipoIdentificacion { get; set; } 
        public string NumeroIdentificacion { get; set; } 
        public string Nombre { get; set; } 
        public string Apellido1 { get; set; } 
        public string Apellido2 { get; set; } 
        public string NombreUsuario { get; set; } 
        public string PasswordHash { get; set; } 
        public string CorreoElectronico { get; set; }
        public byte[] Salt { get; set; }

    }

}
