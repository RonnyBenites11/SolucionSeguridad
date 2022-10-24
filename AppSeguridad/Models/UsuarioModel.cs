using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSeguridad.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public int intentos { get; set; }
        public decimal nivelseg { get; set; }
        public DateTime fechareg { get; set; }
    }
}
