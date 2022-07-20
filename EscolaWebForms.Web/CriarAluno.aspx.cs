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
    public partial class CriarAluno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCriar_OnClick(Object sender, EventArgs e)
        {
            aluno addAluno = new aluno();
            svcAluno insAluno = new svcAluno();

            addAluno.cpf = Convert.ToInt32(tbCpf.Text);
            addAluno.nome = tbNome.Text;
            addAluno.cep = Convert.ToInt32(tbCep.Text);
            addAluno.numero = Convert.ToInt32(tbNum.Text);
            addAluno.complemento = tbComp.Text;

            insAluno.addAluno(addAluno);
        }

    }
}