using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaWebForms.Data
{
    internal class conectDataBase
    {
        internal string buscaConexao()
        {
            string connectionString = "Data Source=DESKTOP-BO7IDIK;Initial Catalog=dbEscola;Integrated Security=True";

            return connectionString;
        }
    }
}
