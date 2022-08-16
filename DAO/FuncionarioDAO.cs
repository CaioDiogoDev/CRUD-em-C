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
    internal class FuncionarioDAO : IDAO
    {
        public ArrayList all()
        {
            ArrayList lista = new ArrayList();
            Funcionarios funcionarios;
            BancoDeDados bd = new BancoDeDados();
            string sql = "SELECT * FROM funcionarios order by codf asc";
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    funcionarios  = new Funcionarios();

                    funcionarios.CodF = int.Parse(rdr[0].ToString());
                    funcionarios.Nome = rdr[1].ToString();
                    funcionarios.Idade = int.Parse(rdr[2].ToString());
                    funcionarios.Cpf = rdr[3].ToString();
                    funcionarios.Cidade = rdr[4].ToString();
                    funcionarios.Salario = decimal.Parse(rdr[5].ToString());
                    funcionarios.Cargo = rdr[6].ToString();

                    lista.Add(funcionarios);

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
            Funcionarios funcionarios = (Funcionarios)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO funcionarios" +
                    "(nome,idade,cpf,salario,cidade,cargo) " +
                    "VALUES(@nome,@idade,@cpf,@salario,@cidade,@cargo)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", funcionarios.Nome);
                cmd.Parameters.AddWithValue("@idade", funcionarios.Idade);
                cmd.Parameters.AddWithValue("@cpf", funcionarios.Cpf);
                cmd.Parameters.AddWithValue("@salario", funcionarios.Salario);
                cmd.Parameters.AddWithValue("@cidade", funcionarios.Cidade);
                cmd.Parameters.AddWithValue("@cargo", funcionarios.Cargo);


                Console.WriteLine(cmd.Parameters[0].Value.ToString());
                cmd.ExecuteNonQuery();
                int id = int.Parse(cmd.LastInsertedId.ToString());
                funcionarios.CodF = id;

                MessageBox.Show("Inserido com Sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return funcionarios;
        }

        public object delete(object chave)
        {
            Funcionarios funcionarios = (Funcionarios)chave;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "delete from medicos " +
                    "where codm=@codm";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codf", funcionarios.CodF);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Excluido com sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return funcionarios;
        }

        public object read(object chave)
        {
            throw new NotImplementedException();
        }

        public object update(object objeto)
        {
            Funcionarios funcionarios = (Funcionarios)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "update funcionarios " +
                    "set nome=@nome," +
                    "idade=@idade," +
                    "salario=@salario ," +
                    "cidade=@cidade," +
                     "cpf=@cpf," +
                     "cargo=@cargo " +
                    "where codm=@CodM";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codf", funcionarios.CodF);
                cmd.Parameters.AddWithValue("@nome", funcionarios.Nome);
                cmd.Parameters.AddWithValue("@idade", funcionarios.Idade);
                cmd.Parameters.AddWithValue("@cidade", funcionarios.Cidade);
                cmd.Parameters.AddWithValue("@cpf",funcionarios.Cpf);
                cmd.Parameters.AddWithValue("@salario", funcionarios.Salario);
                cmd.Parameters.AddWithValue("@cargo", funcionarios.Cargo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Criado com Sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return funcionarios;
        }
    }
}
