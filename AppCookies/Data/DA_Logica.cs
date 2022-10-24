using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCookies.Models;

namespace AppCookies.Data
{
    public class DA_Logica
    {
        public List<Usuario> ListarUsuarios()
        {
            return new List<Usuario>
            {


            new Usuario { NombreUsuario = "Rafael Andrade",
                CorreoUsuario = "administrador@gmail.com",
                ClaveUsuario = "123", Roles = new string[] { "Administrador" } },
            new Usuario
            {
                NombreUsuario = "Carolina Fernandez",
                CorreoUsuario = "supervisor@gmail.com",
                ClaveUsuario = "123",
                Roles = new string[] { "Supervisor" }
            },
            new Usuario
            {
                NombreUsuario = "Juan Castro",
                CorreoUsuario = "empleado@gmail.com",
                ClaveUsuario = "123",
                Roles = new string[] { "Empleado" }
            },
            new Usuario
            {
                NombreUsuario = "Oscar Perez",
                CorreoUsuario = "superempleado@gmail.com",
                ClaveUsuario = "123",
                Roles = new string[] { "Supervisor", "Empleado" }
            }


    };
        }
        public Usuario ValidarUsuario(string _correo, string _clave)
        {
            return ListarUsuarios()
                .Where(item => item.CorreoUsuario == _correo && item.ClaveUsuario == _clave).FirstOrDefault();
        }
    }
}
    
