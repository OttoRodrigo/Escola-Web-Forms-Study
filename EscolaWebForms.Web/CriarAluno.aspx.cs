using EscolaWebForms.mdl;
using EscolaWebForms.svc;
using EscolaWebForms.Web.MSG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EscolaWebForms.Web
{
    public partial class CriarAluno : System.Web.UI.Page
    {
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
            }

        }       

        protected void btnCriar_OnClick(Object sender, EventArgs e)
        {
            if (validaCampos())
            {
                aluno addAluno = new aluno();
                svcAluno insAluno = new svcAluno();

                addAluno.cpf = Convert.ToInt64(tbCpf.Text);
                addAluno.nome = tbNome.Text;
                addAluno.cep = Convert.ToInt32(tbCep.Text);
                addAluno.numero = Convert.ToInt32(tbNum.Text);
                addAluno.complemento = tbComp.Text;

                insAluno.addAluno(addAluno);
                limpaCampos();
                _comum.chamaMensagem(Page, Page.GetType(), "Aluno incluido com sucesso.");
            }

        }

        internal void limpaCampos()
        {
            tbCpf.Text = "";
            tbNome.Text = "";
            tbCep.Text = "";
            tbNum.Text = "";
            tbComp.Text = "";
        }

        internal bool validaCampos()
        {
            if(tbCpf.Text == "" || tbNome.Text == "")
            {
                _comum.chamaMensagem(Page, Page.GetType(), "CPF e Nome são obrigatórios!");
                return false;
            }
            if(tbCpf.Text.Length != 12)
            {
                _comum.chamaMensagem(Page, Page.GetType(), "CPF Inválido!");
                return false;
            }
            if(tbCep.Text != "" && tbCep.Text.Length != 8)
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