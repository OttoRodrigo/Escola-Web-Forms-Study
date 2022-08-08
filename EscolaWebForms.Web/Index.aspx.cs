using EscolaWebForms.svc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EscolaWebForms.Web
{
    public partial class Index : System.Web.UI.Page
    {
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
    }
}