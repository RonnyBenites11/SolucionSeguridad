using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCookies.Models
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string CorreoUsuario { get; set; }
        public string ClaveUsuario { get; set; }
        public string[] Roles { get; set; }
    }
}
