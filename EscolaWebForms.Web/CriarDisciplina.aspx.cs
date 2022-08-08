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
    public partial class CriarDisciplina : System.Web.UI.Page
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
                disciplina addDisc = new disciplina();
                svcDisciplina insDisc = new svcDisciplina();

                addDisc.nome = tbNome.Text;


                insDisc.addDisciplina(addDisc);
                limpaCampos();
                _comum.chamaMensagem(Page, Page.GetType(), "Disciplina incluida com sucesso.");
            }

        }

        internal void limpaCampos()
        {
            tbNome.Text = "";
        }

        internal bool validaCampos()
        {
            if(tbNome.Text == "")
            {
                _comum.chamaMensagem(Page, Page.GetType(), "Nome é obrigatório!");
                return false;
            }            
            return true;
        }

        protected void btnVoltar_OnClick(Object sender, EventArgs e)
        {
            Server.Transfer("~/ListaDisciplinas.aspx");
        }

    }
}