using EscolaWebForms.Data;
using EscolaWebForms.mdl;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaWebForms.svc
{
    public class svcAluno
    {
        internal acessoAluno _insaluno = new acessoAluno();

        public List<aluno> listaAlunos()
        {
            return _insaluno.ListarDenuncias();
        }

        public void addAluno(aluno addAluno)
        {
            _insaluno.inserirAluno(addAluno);
        }

        public aluno buscaAluno(long cpf)
        {
            return _insaluno.buscarAluno(cpf);
        }

        public void atualizaAluno(aluno atAluno)
        {
            _insaluno.atualizaAluno(atAluno);
        }

        public void excluirAluno(long excCpf)
        {
            _insaluno.excluirAluno(excCpf);
        }
    }


}
