using EscolaWebForms.Data;
using EscolaWebForms.mdl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaWebForms.svc
{
    public class svcDisciplina
    {
        internal acessoDisciplina _insDisc = new acessoDisciplina();

        public List<disciplina> listarDisciplinas()
        {
            return _insDisc.ListarDisciplinas();
        }

        public void addDisciplina(disciplina addDisc)
        {
            _insDisc.inserirDisciplina(addDisc);
        }

        public disciplina buscarDisciplina(int id)
        {
            return _insDisc.buscarDisciplina(id);
        }

        public void editarDisciplina(disciplina atDisc)
        {
            _insDisc.atualizaDisciplina(atDisc);
        }

        public void deletarDisciplina(int delId)
        {
            _insDisc.excluirDisciplina(delId);
        }
    }
}
