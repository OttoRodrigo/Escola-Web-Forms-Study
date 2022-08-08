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
    public partial class EditarNotas : System.Web.UI.Page
    {
        private svcRegistroNotas _insNotas = new svcRegistroNotas();
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
                buscaNotas(Convert.ToInt32(id));
            }

        }

        protected void buscaNotas(int id)
        {
            var editNotas = _insNotas.gvListaNotas().Single(p => p.id == id);

            tbId.Text = editNotas.id.ToString();
            tbNome.Text = editNotas.nomeAluno;
            tbDisciplina.Text = editNotas.nomeDisciplina;
            tbN1.Text = editNotas.nota1.ToString();
            tbN2.Text = editNotas.nota2.ToString();
            tbN3.Text = editNotas.nota3.ToString();
            tbN4.Text = editNotas.nota4.ToString();
            tbMedia.Text = editNotas.media.ToString();
            
            if(editNotas.media >= 7)
            {
                lbMediaStatus.Text = "APROVADO";
                lbMediaStatus.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                lbMediaStatus.Text = "REPROVADO";
                lbMediaStatus.BackColor = System.Drawing.Color.Red;
            }

            
        }

        protected void btnEditar_OnClick(Object sender, EventArgs e)
        {

            if (validaCampos())
            {
                registroNotas editNota = new registroNotas();

                editNota.id = Convert.ToInt32(tbId.Text);
                editNota.nota1 = Convert.ToInt32(tbN1.Text);
                editNota.nota2 = Convert.ToInt32(tbN2.Text);
                editNota.nota3 = Convert.ToInt32(tbN3.Text);
                editNota.nota4 = Convert.ToInt32(tbN4.Text);
                editNota.media = (editNota.nota1 + editNota.nota2 + editNota.nota3 + editNota.nota4) / 4;

                _insNotas.atualizaNotas(editNota);
                _comum.chamaMensagem(Page, Page.GetType(), "Notas Atualizadas!");
                buscaNotas(Convert.ToInt32(tbId.Text));
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
            Server.Transfer("~/ListaNotas.aspx");
        }
    }
}