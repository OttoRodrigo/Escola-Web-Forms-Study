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
    public partial class ExcluirDisciplina : System.Web.UI.Page
    {
        private svcDisciplina _insDisc = new svcDisciplina();
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
                buscaDisc(Convert.ToInt32(id));
            }

        }

        protected void buscaDisc(int id)
        {
            var editDisc = _insDisc.buscarDisciplina(id);
            tbId.Text = editDisc.id.ToString();
            tbNome.Text = editDisc.nome;           
        }

        protected void btnExcluir_OnClick(Object sender, EventArgs e)
        {
            _insDisc.deletarDisciplina(Convert.ToInt32(tbId.Text));
           
            Server.Transfer("~/ListaDisciplinas.aspx");
        }

        protected void btnVoltar_OnClick(Object sender, EventArgs e)
        {
            Server.Transfer("~/ListaDisciplinas.aspx");
        }
    }
}