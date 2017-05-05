using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UsuarioModel
    {
        
        public int Cod_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Pais { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public DateTime Fecha_Nac { get; set; }
        public string Password { get; set; }
    }
}