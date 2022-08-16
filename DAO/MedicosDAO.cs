using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinica.model;
using MySql.Data.MySqlClient;


namespace Clinica.DAO
{
    internal class MedicosDAO : IDAO
    {
        public ArrayList all()
        {
            ArrayList lista = new ArrayList();
            Medicos medicos;
            int nroa;
            BancoDeDados bd = new BancoDeDados();
            string sql = "SELECT * FROM medicos order by codm desc";
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    medicos = new Medicos();
                    medicos.CodM = int.Parse(rdr[0].ToString());
                    medicos.Nome  = rdr[1].ToString();
                    medicos.Idade = int.Parse(rdr[2].ToString());
                    medicos.Especialidade = rdr[3].ToString();
                    medicos.Cpf = rdr[4].ToString();
                    medicos.Cidade = rdr[5].ToString();
                    int.TryParse(rdr[6].ToString(), out  nroa);
                    medicos.NroA = nroa;
                    

                    lista.Add(medicos);

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
            Medicos medicos = (Medicos)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO medicos" +
                    "(nome,idade,cpf,especialidade,cidade,nroa) " +
                    "VALUES(@nome,@idade,@cpf,@especialidade,@cidade,@nroa)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", medicos.Nome);
                cmd.Parameters.AddWithValue("@idade", medicos.Idade);
                cmd.Parameters.AddWithValue("@cpf", medicos.Cpf);
                cmd.Parameters.AddWithValue("@especialidade", medicos.Especialidade);
                cmd.Parameters.AddWithValue("@cidade", medicos.Cidade);
                cmd.Parameters.AddWithValue("@nroa", medicos.NroA);


                Console.WriteLine(cmd.Parameters[0].Value.ToString());
                cmd.ExecuteNonQuery();
                int id = int.Parse(cmd.LastInsertedId.ToString());
                medicos.CodM = id;

                MessageBox.Show("Inserido com Sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return medicos;
        }

        public object delete(object chave)
        {
            Medicos medicos = (Medicos)chave;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "delete from medicos " +
                    "where codm=@codm";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codm", medicos.CodM);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Excluido com sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return medicos;
        }

        public object read(object chave)
        {
            string sql = "select * from medicos where codm = @codm";
            BancoDeDados bd = new BancoDeDados();
            Medicos medico = (Medicos)chave;

            Medicos doBanco = new Medicos();
            int nroa;
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@codm", medico.CodM);
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    doBanco.CodM = int.Parse(rdr[0].ToString());
                    doBanco.Nome = rdr[1].ToString();
                    doBanco.Idade = int.Parse(rdr[2].ToString());
                    doBanco.Especialidade = rdr[3].ToString();
                    doBanco.Cpf = rdr[4].ToString();
                    doBanco.Cidade = rdr[5].ToString();
                    int.TryParse(rdr[6].ToString(), out nroa);
                    doBanco.NroA = nroa;

                }
                rdr.Close();
            }
            catch
            {
                throw;
            }



            return doBanco;
        }

        public object update(object objeto)
        {
            Medicos medicos = (Medicos)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "update Medicos " +
                    "set nome=@nome," +
                    "idade=@idade," +
                    "especialidade=@especialidade ," +
                    "cidade=@cidade," +
                     "cpf=@cpf," +
                     "nroa=@nroa " +
                    "where codm=@CodM";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codm", medicos.CodM);
                cmd.Parameters.AddWithValue("@nome", medicos.Nome);
                cmd.Parameters.AddWithValue("@idade", medicos.Idade);
                cmd.Parameters.AddWithValue("@cidade", medicos.Cidade);
                cmd.Parameters.AddWithValue("@cpf", medicos.Cpf);
                cmd.Parameters.AddWithValue("@Especialidade", medicos.Especialidade);
                cmd.Parameters.AddWithValue("@nroa", medicos.NroA);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Criado com Sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return medicos;
        }
    }
}
