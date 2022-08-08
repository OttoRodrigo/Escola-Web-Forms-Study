using EscolaWebForms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaWebForms.svc
{
     public class svcUsuario
    {
        internal acessoUsuario _insUsuario = new acessoUsuario();

        public bool confirmaUsuario(string usuario, string senha)
        {
            return _insUsuario.buscarAluno(usuario, senha);
        }
    }
}
