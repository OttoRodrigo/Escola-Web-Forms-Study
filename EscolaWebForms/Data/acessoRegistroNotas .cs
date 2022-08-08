using EscolaWebForms.mdl;
using EscolaWebForms.mdl.gv;
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
    internal class acessoRegistroNotas
    {
        conectDataBase _conection = new conectDataBase();       

        internal List<registroNotas> ListarNotas()
        {            
            List<registroNotas> retNotas = new List<registroNotas>();
            string connectionString = _conection.buscaConexao();

            string queryString = RESRegistroNotas.listaNotas;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {           
                SqlCommand command = new SqlCommand(queryString, connection);
                
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    retNotas.Add(new registroNotas
                    { 
                        id         = Convert.ToInt32(reader[0]),
                        aluno      = Convert.ToInt64(reader[1]),
                        disciplina = Convert.ToInt32(reader[2]),
                        nota1      = Convert.ToInt32(reader[3]) > 0 ? Convert.ToInt32(reader[3]) : 0,
                        nota2      = Convert.ToInt32(reader[4]) > 0 ? Convert.ToInt32(reader[4]) : 0,
                        nota3      = Convert.ToInt32(reader[5]) > 0 ? Convert.ToInt32(reader[5]) : 0,
                        nota4      = Convert.ToInt32(reader[6]) > 0 ? Convert.ToInt32(reader[6]) : 0,
                        media      = Convert.ToInt32(reader[7]) > 0 ? Convert.ToInt32(reader[7]) : 0
                    });
                }
                reader.Close();               

                return retNotas;
            }
        }

        public List<gvRegistroNotas> gvListarNotas()
        {
            List<gvRegistroNotas> retNotas = new List<gvRegistroNotas>();
            string connectionString = _conection.buscaConexao();

            string queryString = RESRegistroNotas.gvListaNotas;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    retNotas.Add(new gvRegistroNotas
                    {
                        id = Convert.ToInt32(reader[0]),
                        aluno = Convert.ToInt64(reader[1]),
                        nomeAluno = reader[2].ToString(),
                        nomeDisciplina = reader[3].ToString(),
                        nota1 = Convert.ToInt32(reader[4]),
                        nota2 = Convert.ToInt32(reader[5]),
                        nota3 = Convert.ToInt32(reader[6]),
                        nota4 = Convert.ToInt32(reader[7]),
                        media = Convert.ToInt32(reader[8])
                    });
                }
                reader.Close();

                return retNotas;
            }
        }

        //Insere somente o registro do Aluno/Disciplina, as notas são por update
        internal void inserirAlunoDisciplina(long aluno, int disciplina)
        {
            string connectionString = _conection.buscaConexao(); ;

            string queryString = RESRegistroNotas.insereNotasAlunoDisciplina;          

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@aluno", aluno);
                command.Parameters.AddWithValue("@disciplina", disciplina);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                reader.Close();
            }
        }

        internal registroNotas buscarNotas(int pid)
        {
            registroNotas retNotas = new registroNotas();
            string connectionString = _conection.buscaConexao();

            string queryString = RESRegistroNotas.buscaNotas;            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@id", pid);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    retNotas.id = Convert.ToInt32(reader[0]);
                    retNotas.aluno = Convert.ToInt64(reader[1]);
                    retNotas.disciplina = Convert.ToInt32(reader[2]);
                    retNotas.nota1 = Convert.ToInt32(reader[3]);
                    retNotas.nota2 = Convert.ToInt32(reader[4]);
                    retNotas.nota3 = Convert.ToInt32(reader[5]);
                    retNotas.nota4 = Convert.ToInt32(reader[6]);
                    retNotas.media = Convert.ToInt32(reader[7]);
                }
                reader.Close();

                return retNotas;
            }
        }

        internal void atualizaNotas(registroNotas atNotas)
        {
            string connectionString = _conection.buscaConexao();

            string queryString = RESRegistroNotas.AtualizaNotas;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@nota1", atNotas.nota1);
                command.Parameters.AddWithValue("@nota2", atNotas.nota2);
                command.Parameters.AddWithValue("@nota3", atNotas.nota3);
                command.Parameters.AddWithValue("@nota4", atNotas.nota4);
                command.Parameters.AddWithValue("@media", atNotas.media);
                command.Parameters.AddWithValue("@id", atNotas.id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Close();
            }
        }      

    }
}
