using EscolaWebForms.Data;
using EscolaWebForms.mdl;
using EscolaWebForms.mdl.gv;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaWebForms.svc
{
    public class svcRegistroNotas
    {
        internal acessoRegistroNotas _insNotas = new acessoRegistroNotas();

        public List<registroNotas> listaNotas()
        {
            return _insNotas.ListarNotas();
        }

        public List<gvRegistroNotas> gvListaNotas()
        {
            return _insNotas.gvListarNotas();
        }

        public void addAlunoDisciplina(long aluno, int disciplina)
        {
            _insNotas.inserirAlunoDisciplina(aluno, disciplina);
        }

        public registroNotas buscaNotas(int id)
        {
            return _insNotas.buscarNotas(id);
        }

        public void atualizaNotas(registroNotas atNotas)
        {
            _insNotas.atualizaNotas(atNotas);
        }

    }


}
