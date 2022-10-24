using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using AppSeguridad.Models;
using Microsoft.AspNetCore.Http;

namespace AppSeguridad.Controllers
{
    public class LoginController : Controller
    {
        const string SesionUsuario = "_User";
        private readonly IConfiguration _IConfig;
        public LoginController(IConfiguration IConfig)
        {
            _IConfig = IConfig;
        }
        public IActionResult Inicio()
        {
            return View(new UsuarioModel());
        }
        [HttpPost]
        public IActionResult Inicio(UsuarioModel reg)
        {
            string cnn = _IConfig["ConnectionStrings:cn"];
            SqlConnection cn = new SqlConnection(cnn);
            if (string.IsNullOrEmpty(reg.usuario)|| string.IsNullOrEmpty(reg.clave))
            {
                ModelState.AddModelError("", "Los datos son requeridos...");

            }
            else
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("usp_seg_usuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", reg.usuario);
                cmd.Parameters.AddWithValue("@clave", reg.clave);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    HttpContext.Session.SetString(SesionUsuario, reg.usuario);
                    return RedirectToAction("Index", "Home");
                }
                else {
                    ModelState.AddModelError("", "Los datos ingresados no son validos....");}
                
            }
            return View(reg);

        }
    }
}
