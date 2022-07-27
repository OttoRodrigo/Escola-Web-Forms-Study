using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace EscolaWebForms.Web.MSG
{
    public class comumClass
    {
        public void chamaMensagem(Page page, Type pageType, string msg)
        {
            ScriptManager.RegisterStartupScript(
                                        page,
                                        pageType,
                                        "mensagem",
                                        $"Mensagem('{msg}')",
                                        true);
        }
    }
}