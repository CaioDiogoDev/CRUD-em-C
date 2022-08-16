using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clinica
{
    internal class PacienteDAO : IDAO
    {
        public ArrayList all()
        {
            ArrayList lista = new ArrayList();
            Paciente paciente;
            BancoDeDados bd = new BancoDeDados();
            string sql = "SELECT * FROM pacientes order by codp desc";
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    paciente = new Paciente();
                    paciente.CodP   =   int.Parse(rdr[0].ToString());
                    paciente.Nome   =   rdr[1].ToString();
                    paciente.Idade  =   int.Parse(rdr[2].ToString());
                    paciente.Cpf    =   rdr[3].ToString();
                    paciente.Cidade =   rdr[4].ToString();
                    paciente.Especialidade =   rdr[5].ToString();
                    lista.Add(paciente);

                }
                rdr.Close();
            }
            catch
            {
                throw;
            }
            return lista;
        }

        public object create(object objeto)
        {
            Paciente paciente = (Paciente) objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO pacientes" +
                    "(nome,idade,cidade,cpf,doenca) " +
                    "VALUES(@nome,@idade,@cidade,@cpf,@doenca)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", paciente.Nome);
                cmd.Parameters.AddWithValue("@idade", paciente.Idade);
                cmd.Parameters.AddWithValue("@cidade", paciente.Cidade);
                cmd.Parameters.AddWithValue("@cpf", paciente.Cpf);
                cmd.Parameters.AddWithValue("@doenca", paciente.Especialidade);
                Console.WriteLine(cmd.Parameters[0].Value.ToString());
                cmd.ExecuteNonQuery();
                int id = int.Parse(cmd.LastInsertedId.ToString());
                paciente.CodP = id;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return paciente;
        }

        public object delete(object chave)
        {
            Paciente paciente = (Paciente)chave;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "delete from pacientes " +
                    "where codp=@codp";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codp", paciente.CodP);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Excluido com Sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return paciente;
        }

        public object read(object chave)
        {
            Paciente paciente = (Paciente)chave;
            Paciente doBanco = new Paciente();

            BancoDeDados bd = new BancoDeDados();
            string sql = "SELECT * FROM pacientes where codp = @codp";
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@codp", paciente.CodP);

            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    doBanco.CodP = int.Parse(rdr[0].ToString());
                    doBanco.Nome = rdr[1].ToString();
                    doBanco.Idade = int.Parse(rdr[2].ToString());
                    doBanco.Cpf = rdr[3].ToString();
                    doBanco.Cidade = rdr[4].ToString();
                    doBanco.Doenca = rdr[5].ToString();
                }
            }
            catch
            {
                throw;
            }

            return doBanco;
        }

        public object update(object objeto)
        {
            Paciente paciente = (Paciente)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "update pacientes " +
                    "set nome=@nome," +
                    "idade=@idade," +
                    "cidade=@cidade," +
                    "cpf=@cpf," +
                    "doenca=@doenca " +
                    "where codp=@codp";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", paciente.Nome);
                cmd.Parameters.AddWithValue("@idade", paciente.Idade);
                cmd.Parameters.AddWithValue("@cidade", paciente.Cidade);
                cmd.Parameters.AddWithValue("@cpf", paciente.Cpf);
                cmd.Parameters.AddWithValue("@doenca", paciente.Especialidade);
                cmd.Parameters.AddWithValue("@codp", paciente.CodP);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Criado com Sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return paciente;
        }
    }
}
