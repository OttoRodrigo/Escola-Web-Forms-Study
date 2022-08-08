using EscolaWebForms.svc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EscolaWebForms.Web
{
    public partial class ListaNotas : System.Web.UI.Page
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
                gridNotas();
            }

        }

        protected void gridNotas()
        {
            svcRegistroNotas insSvcNotas = new svcRegistroNotas();

            var listNotas = insSvcNotas.gvListaNotas();

            gvNotas.DataSource = listNotas;
            gvNotas.AllowPaging = true;
            gvNotas.PageSize = 10;
            gvNotas.AutoGenerateEditButton = true;
            gvNotas.AlternatingRowStyle.BorderWidth = 1;
            gvNotas.DataBind();
        }

        protected void gvAlunos_OnPageIndexChanged(object sender, GridViewPageEventArgs e)
        {
            gvNotas.PageIndex = e.NewPageIndex;
            gvNotas.DataBind();
        }

        protected void edit_RowEditing(object sender, GridViewEditEventArgs e)
        {
            var gridEdit = gvNotas.Rows[e.NewEditIndex].Cells[1];

           
            Context.Items.Add("id", gridEdit.Text);
            Server.Transfer("~/EditarNotas.aspx");
        }  

        protected void btnNovaNota_onclick(object sender, EventArgs e)
        {
            Server.Transfer("~/CriarNotas.aspx");
        }
    }
}