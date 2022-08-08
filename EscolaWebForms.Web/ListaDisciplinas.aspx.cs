﻿using EscolaWebForms.svc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EscolaWebForms.Web
{
    public partial class ListaDisciplinas : System.Web.UI.Page
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
                gridAlunos();
            }

        }

        protected void gridAlunos()
        {
            svcDisciplina insSvcDisciplina = new svcDisciplina();

            var listDisciplinas = insSvcDisciplina.listarDisciplinas();

            gvDisciplinas.DataSource = listDisciplinas;
            gvDisciplinas.AllowPaging = true;
            gvDisciplinas.PageSize = 10;
            gvDisciplinas.AutoGenerateEditButton = true;
            gvDisciplinas.AutoGenerateDeleteButton = true;
            gvDisciplinas.AlternatingRowStyle.BorderWidth = 1;

            gvDisciplinas.DataBind();
        }

        protected void gvDisciplinas_OnPageIndexChanged(object sender, GridViewPageEventArgs e)
        {
            gvDisciplinas.PageIndex = e.NewPageIndex;
            gvDisciplinas.DataBind();
        }

        protected void edit_RowEditing(object sender, GridViewEditEventArgs e)
        {
            var gridEdit = gvDisciplinas.Rows[e.NewEditIndex].Cells[1];

           
            Context.Items.Add("id", gridEdit.Text);
            Server.Transfer("~/EditarDisciplina.aspx");
        }

        protected void delete_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            var gridEdit = gvDisciplinas.Rows[e.RowIndex].Cells[1];
            Context.Items.Add("id", gridEdit.Text);
            Server.Transfer("~/ExcluirDisciplina.aspx");
        }      

        protected void btnNovaDisciplina_onclick(object sender, EventArgs e)
        {
            Server.Transfer("~/CriarDisciplina.aspx");
        }
    }
}