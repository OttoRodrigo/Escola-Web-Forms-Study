using EscolaWebForms.mdl;
using EscolaWebForms.svc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EscolaWebForms.Web
{
    public partial class ExcluirAluno : System.Web.UI.Page
    {
        private svcAluno _insAluno = new svcAluno();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var id = Context.Items["id"].ToString();
                buscaAluno(Convert.ToInt64(id));
            }
        }

        protected void buscaAluno(long cpf)
        {
            var editAluno = _insAluno.buscaAluno(cpf);
            tbCpf.Text = editAluno.cpf.ToString();
            tbNome.Text = editAluno.nome;
            tbCep.Text = editAluno.cep.ToString();
            tbNum.Text = editAluno.numero.ToString();
            tbComp.Text = editAluno.complemento;
        }

        protected void btnExcluir_OnClick(Object sender, EventArgs e)
        {
            aluno addAluno = new aluno();
            svcAluno insAluno = new svcAluno();

            insAluno.excluirAluno(Convert.ToInt64(tbCpf.Text));
            Server.Transfer("~/ListaAlunos.aspx");
        }

        protected void btnVoltar_OnClick(Object sender, EventArgs e)
        {
            Server.Transfer("~/ListaAlunos.aspx");
        }
    }
}