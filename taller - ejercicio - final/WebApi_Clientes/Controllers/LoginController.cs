using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Taller.BussinesLogic;
using Taller.Domain;

namespace WebAPIClientes
{
    public class LoginController : ApiController
    {
        // POST api/<controller>
        public string Post([FromBody]Usuario usuario)
        {
            string result = "Usuario o clave incorrecta";
            List<Usuario> lista = UsuariosManager.Get();
            
            foreach(Usuario miUsuario in lista)
            {
                if (miUsuario.User == usuario.User)
                {
                    if(miUsuario.NLogins > 2)
                    {
                        result = "Usuario Bloqueado";
                    }
                    else if (miUsuario.Clave == usuario.Clave)
                    {
                        result = "Usuario autenticado";
                        UsuariosManager.Actualizar(usuario);
                    }
                    else if (miUsuario.Clave != usuario.Clave)
                    {
                        usuario.NLogins = miUsuario.NLogins + 1;
                        UsuariosManager.Actualizar(usuario);
                    }
                }
            } 
            return result;
        }

 

    }
}