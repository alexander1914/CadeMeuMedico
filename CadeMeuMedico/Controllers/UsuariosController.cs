using CadeMeuMedico.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class UsuariosController : Controller
    {
        [HttpGet]
        public JsonResult AutenticacaoDeUsuario(string Login, string Senha)
        {
            if (RepositorioUsuarios.AutenticarUsuario(Login, Senha))
            {
                return Json(new
                {
                    OK = true,
                    Mensagem = "Usuário autenticado. Redirecionando... Aguarde"},                
                    JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    OK = false,
                    Mensagem = "Usuário não encontrado. Tente Novamente." },
                    JsonRequestBehavior.AllowGet);
            }
        }
    }
}