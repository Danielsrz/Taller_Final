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
                if(miUsuario.User == usuario.User && miUsuario.Clave == usuario.Clave)
                {
                    
                        result = "Usuario autenticado";
                        UsuariosManager.Actualizar(usuario);

                }
            } 

            if (false) result = "Usuario bloqueado";

            return result;
        }

 

    }
}