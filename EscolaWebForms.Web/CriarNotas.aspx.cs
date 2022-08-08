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
    public partial class CriarNotas : System.Web.UI.Page
    {
        comumClass _comum = new comumClass();
        svcAluno _insAluno = new svcAluno();
        svcDisciplina _insDisc = new svcDisciplina();
        svcRegistroNotas _insNotas = new svcRegistroNotas();
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
                dropAluno();
                dropDisciplina();
            }

        }     

        internal void dropAluno()
        {
            var listaAlunos = _insAluno.listaAlunos();
            dpAluno.DataSource = listaAlunos;
            dpAluno.DataTextField = "nome";
            dpAluno.DataValueField = "cpf";
            dpAluno.DataBind();
        }

        internal void dropDisciplina()
        {
            var listaDisc = _insDisc.listarDisciplinas();
            dpDisciplina.DataSource = listaDisc;
            dpDisciplina.DataTextField = "nome";
            dpDisciplina.DataValueField = "id";
            dpDisciplina.DataBind();
        }

        protected void btnCriar_OnClick(Object sender, EventArgs e)
        {
            if (validaCampos())
            {
                _insNotas.addAlunoDisciplina(Convert.ToInt64(dpAluno.SelectedValue), Convert.ToInt32(dpDisciplina.SelectedValue));                
                limpaCampos();
                _comum.chamaMensagem(Page, Page.GetType(), "Registro incluido com sucesso.");
            }

        }

        internal void limpaCampos()
        {
            dropAluno();
            dropDisciplina();
        }

        internal bool validaCampos()
        {
            var listaNotas = _insNotas.listaNotas().SingleOrDefault(p =>
                            p.aluno == Convert.ToInt64(dpAluno.SelectedValue) &&
                            p.disciplina == Convert.ToInt32(dpDisciplina.SelectedValue));

            if (listaNotas != null)
            {
                _comum.chamaMensagem(Page, Page.GetType(), "Já existe registro do aluno nas disciplina escolhida!");
                return false;
            }
            return true;
        }

        protected void btnVoltar_OnClick(Object sender, EventArgs e)
        {
            Server.Transfer("~/ListaNotas.aspx");
        }

    }
}