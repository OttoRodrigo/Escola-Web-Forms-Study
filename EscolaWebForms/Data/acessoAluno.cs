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
    internal class acessoAluno
    {
        conectDataBase _conection = new conectDataBase();       

        internal List<aluno> ListarAlunos()
        {            
            List<aluno> retAlunos = new List<aluno>();
            string connectionString = _conection.buscaConexao();

            string queryString = RESAluno.listaAlunos;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {           
                SqlCommand command = new SqlCommand(queryString, connection);
                
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    retAlunos.Add(new aluno { 
                        cpf         = Convert.ToInt64(reader[0]),
                        nome        = reader[1].ToString(),
                        cep         = Convert.ToInt32(reader[2]),
                        numero      = Convert.ToInt32(reader[3]),
                        complemento = reader[4].ToString()
                    });
                }
                reader.Close();               

                return retAlunos;
            }
        }

        internal void inserirAluno(aluno insAluno)
        {
            string connectionString = _conection.buscaConexao(); ;

            string queryString = RESAluno.inserirAlunos;          

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@cpf", insAluno.cpf);
                command.Parameters.AddWithValue("@nome", insAluno.nome);
                command.Parameters.AddWithValue("@cep", insAluno.cep);
                command.Parameters.AddWithValue("@numero", insAluno.numero);
                command.Parameters.AddWithValue("@complemento", insAluno.complemento);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                reader.Close();
            }
        }

        internal aluno buscarAluno(long p_cpf)
        {
            aluno retAluno = new aluno();
            string connectionString = _conection.buscaConexao();

            string queryString = RESAluno.buscaAluno;            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@cpf", p_cpf);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    retAluno.cpf = Convert.ToInt64(reader[0]);
                    retAluno.nome = reader[1].ToString();
                    retAluno.cep = Convert.ToInt32(reader[2]);
                    retAluno.numero = Convert.ToInt32(reader[3]);
                    retAluno.complemento = reader[4].ToString();                   
                }
                reader.Close();

                return retAluno;
            }
        }

        internal void atualizaAluno(aluno atAluno)
        {
            string connectionString = _conection.buscaConexao();

            string queryString = RESAluno.atualizaAluno;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@cpf", atAluno.cpf);
                command.Parameters.AddWithValue("@nome", atAluno.nome);
                command.Parameters.AddWithValue("@cep", atAluno.cep);
                command.Parameters.AddWithValue("@numero", atAluno.numero);
                command.Parameters.AddWithValue("@complemento", atAluno.complemento);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Close();
            }
        }

        internal void excluirAluno(long excCpf)
        {
            string connectionString = _conection.buscaConexao();

            string queryString = RESAluno.deleteAluno;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@cpf", excCpf);                

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Close();
            }
        }

    }
}
