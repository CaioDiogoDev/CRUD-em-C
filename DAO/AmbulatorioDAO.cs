using Clinica.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.DAO
{
    internal class AmbulatorioDAO : IDAO

    {
        public ArrayList all()
        {
            ArrayList lista = new ArrayList();
            Ambulatorio ambulatorio;
            BancoDeDados bd = new BancoDeDados();
            string sql = "SELECT * FROM ambulatorios order by Nroa asc";
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ambulatorio = new Ambulatorio();

                    ambulatorio.Nroa = int.Parse(rdr[0].ToString());
                    ambulatorio.Andar = int.Parse(rdr[1].ToString());
                    ambulatorio.Capacidade = int.Parse(rdr[2].ToString());
                  

                    lista.Add(ambulatorio);

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
            Ambulatorio ambulatorio =(Ambulatorio)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO ambulatorios" +
                    "(nroa,andar,capacidade) " +
                    "VALUES(@nroa,@andar,@capacidade)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nroa", ambulatorio.Nroa);
                cmd.Parameters.AddWithValue("@idade", ambulatorio.Andar);
                cmd.Parameters.AddWithValue("@cpf", ambulatorio.Capacidade);
         


                Console.WriteLine(cmd.Parameters[0].Value.ToString());
                cmd.ExecuteNonQuery();
                int id = int.Parse(cmd.LastInsertedId.ToString());
                ambulatorio.Nroa = id;

                MessageBox.Show("Inserido com Sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return ambulatorio;
        }

        public object delete(object chave)
        {
            Ambulatorio ambulatorio = (Ambulatorio)chave; 
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "delete from ambulatorio " +
                    "where nroa=@nroa";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codm", ambulatorio.Nroa);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Excluido com sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return ambulatorio;
        }

        public object read(object chave)
        {
            string sql = "select * from ambulatorios where nroa = @nroa";
            BancoDeDados bd = new BancoDeDados();
            Ambulatorio ambulatorio = (Ambulatorio)chave;

            Ambulatorio doBanco = new Ambulatorio();
            //int nroa;
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@codm", ambulatorio.Nroa);
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    doBanco.Nroa = int.Parse(rdr[0].ToString());
                    doBanco.Andar = int.Parse(rdr[1].ToString());
                    doBanco.Capacidade = int.Parse(rdr[2].ToString());
               

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
            Ambulatorio ambulatorio = (Ambulatorio)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "update ambulatorio " +
                    "set nroa=@nroa," +
                    "andar=@andar," +
                    "capacidade=@capacidade ," +
                    "where nroa=@nroa";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nroa", ambulatorio.Nroa);
                cmd.Parameters.AddWithValue("@andar", ambulatorio.Andar);
                cmd.Parameters.AddWithValue("@capacidade", ambulatorio.Capacidade);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Criado com Sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return ambulatorio;
        }
    }
}

