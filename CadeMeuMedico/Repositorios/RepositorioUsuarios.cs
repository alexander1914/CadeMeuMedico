using CadeMeuMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace CadeMeuMedico.Repositorios
{
    public class RepositorioUsuarios
    {
        public static bool AutenticarUsuario(string Login, string Senha)
        {
            var SenhaCriptografada =
                FormsAuthentication.HashPasswordForStoringInConfigFile(Senha, "sha1");
            try
            {
                using (ModeloDeDados db =
                    new ModeloDeDados())
                {
                    var QueryAtenticaUsuarios =
                        db.Usuarios.
                        Where(x => x.Login == Login && x.Senha == Senha).
                        SingleOrDefault();

                    if (QueryAtenticaUsuarios == null)
                    {
                        return false;
                    }
                    else
                    {
                        RepositorioCookies.RegistraCookieAutenticacao(
                            QueryAtenticaUsuarios.IDUsuario);
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Usuarios RecuperaUsuarioPorID(long IDUsuario)
        {
            try
            {
                using (ModeloDeDados db = new ModeloDeDados())
                {
                    var Usuario =
                        db.Usuarios.
                        Where(u => u.IDUsuario == IDUsuario).
                        SingleOrDefault();
                    return Usuario;
                }
            }
            catch (Exception)
            {
                return null;
            }

            }

        public static Usuarios VerificaSeOUsuarioEstaLogado()
        {
            var Usuario = HttpContext.
                Current.
                Request.
                Cookies["UserCookieAuthentication"];

            if(Usuario == null)
            {
                return null;
            }
            else
            {
                long IDUsuario = Convert.
                    ToInt64(RepositorioCriptografia.
                    Descriptografar(Usuario.Values["IDUsuario"]));

                var UsuarioRetornado = RecuperaUsuarioPorID(IDUsuario);
                return UsuarioRetornado;
            }
        }

    }
}
