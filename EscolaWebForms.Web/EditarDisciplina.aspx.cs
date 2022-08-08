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
    public partial class EditarDisciplina : System.Web.UI.Page
    {
        private svcDisciplina _insDisc = new svcDisciplina();
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
                buscaDisc(Convert.ToInt32(id));
            }

        }

        protected void buscaDisc(int id)
        {
            var editDisc = _insDisc.buscarDisciplina(id);
            tbId.Text = editDisc.id.ToString();
            tbNome.Text = editDisc.nome;
            
        }

        protected void btnEditar_OnClick(Object sender, EventArgs e)
        {

            if (validaCampos())
            {
                disciplina editDisc = new disciplina();

                editDisc.id = Convert.ToInt32(tbId.Text);
                editDisc.nome = tbNome.Text;                

                _insDisc.editarDisciplina(editDisc);
                Server.Transfer("~/ListaDisciplinas.aspx");
            }
        }

        internal bool validaCampos()
        {
            if (tbNome.Text == "")
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