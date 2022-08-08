using EscolaWebForms.mdl;
using EscolaWebForms.svc;
using EscolaWebForms.Web.MSG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EscolaWebForms.Web
{
    public partial class EditarAluno : System.Web.UI.Page
    {
        private svcAluno _insAluno = new svcAluno();
        comumClass _comum = new comumClass();
        svcUsuario _insUser = new svcUsuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var valido = _insUser.confirmaUsuario((string)Session["user"], (string)Session["senha"]);

                if (!valido)
                {
                    Server.Transfer("~/Login.aspx");
                }
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

        protected void btnEditar_OnClick(Object sender, EventArgs e)
        {

            if (validaCampos())
            {
                aluno editAluno = new aluno();

                editAluno.cpf = Convert.ToInt64(tbCpf.Text);
                editAluno.nome = tbNome.Text;
                editAluno.cep = Convert.ToInt32(tbCep.Text);
                editAluno.numero = Convert.ToInt32(tbNum.Text);
                editAluno.complemento = tbComp.Text;

                _insAluno.atualizaAluno(editAluno);
                Server.Transfer("~/ListaAlunos.aspx");
            }
        }

        internal bool validaCampos()
        {
            if (tbNome.Text == "")
            {
                _comum.chamaMensagem(Page, Page.GetType(), "Nome é obrigatório!");
                return false;
            }
            if (tbCep.Text != "" && tbCep.Text.Length != 8)
            {
                _comum.chamaMensagem(Page, Page.GetType(), "CEP Inválido!");
                return false;
            }
            return true;
        }

        protected void btnVoltar_OnClick(Object sender, EventArgs e)
        {
            Server.Transfer("~/ListaAlunos.aspx");
        }
    }
}