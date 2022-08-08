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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            svcUsuario insUser = new svcUsuario();

            var valido = insUser.confirmaUsuario(tbUsuario.Text, tbSenha.Text);

            if (valido)
            {
                Session["user"] = tbUsuario.Text;
                Session["senha"] = tbSenha.Text;
                Server.Transfer("~/Index.aspx");
            }
            else
            {
                comumClass comum = new comumClass();
                comum.chamaMensagem(Page, Page.GetType(), "Usuário ou Senha Invalidos!");
            }
        }
    }
}