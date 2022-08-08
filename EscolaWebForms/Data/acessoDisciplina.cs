using EscolaWebForms.mdl;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaWebForms.Data
{
    internal class acessoDisciplina
    {
        conectDataBase _conection = new conectDataBase();

        internal List<disciplina> ListarDisciplinas()
        {
            List<disciplina> retDisc = new List<disciplina>();
            string connectionString = _conection.buscaConexao();

            string queryString = RESDisciplina.listaDisciplinas;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    retDisc.Add(new disciplina
                    {
                        id = Convert.ToInt32(reader[0]),
                        nome = reader[1].ToString()                        
                    });
                }
                reader.Close();

                return retDisc;
            }
        }

        internal void inserirDisciplina(disciplina insDisciplina)
        {
            string connectionString = _conection.buscaConexao();

            string queryString = RESDisciplina.inserirDisciplinas;
            //insDisciplina.id = buscaNovoId();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                //command.Parameters.AddWithValue("@id", insDisciplina.id);
                command.Parameters.AddWithValue("@nome", insDisciplina.nome);                

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Close();
            }
        }

        internal disciplina buscarDisciplina(int pId)
        {
            disciplina retDisc = new disciplina();
            string connectionString = _conection.buscaConexao();

            string queryString = RESDisciplina.buscaDisciplina;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@id", pId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    retDisc.id = Convert.ToInt32(reader[0]);
                    retDisc.nome = reader[1].ToString();
                }
                reader.Close();

                return retDisc;
            }
        }

        internal void atualizaDisciplina(disciplina atDisciplina)
        {
            string connectionString = _conection.buscaConexao();

            string queryString = RESDisciplina.atualizaDisciplina;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@id", atDisciplina.id);
                command.Parameters.AddWithValue("@nome", atDisciplina.nome);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Close();
            }
        }

        internal void excluirDisciplina(int excId)
        {
            string connectionString = _conection.buscaConexao();

            string queryString = RESDisciplina.deleteDisciplina;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@id", excId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Close();
            }
        }
    }
}
