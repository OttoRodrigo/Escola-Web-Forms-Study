using EscolaWebForms.mdl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace EscolaWebForms.Data
{
    internal class acessoUsuario
    {
        conectDataBase _conection = new conectDataBase();    

        internal bool buscarAluno(string nome, string senha)
        {
            
            string connectionString = _conection.buscaConexao();
            bool retUser = false;

            string queryString = RESUsuario.ConfirmaUsuario;            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@nome", nome != null ? nome : "0");
                command.Parameters.AddWithValue("@senha", senha != null ? senha : "0");

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if(Convert.ToInt32(reader[0]) > 0)
                    {
                        retUser = true;
                    }                                       
                }
                reader.Close();

                return retUser;
            }
        }

        

    }
}
