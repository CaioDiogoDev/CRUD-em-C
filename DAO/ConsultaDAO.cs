using Clinica.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    internal class ConsultaDAO : IDAO
    {
        public ArrayList all()
        {
            ArrayList lista = new ArrayList() ;
            string sql = "select m.*, p.*,c.data, c.hora  " +
                "from consultas c " +
                "join pacientes p on p.codp = c.codp " +
                "join medicos m on c.codm=m.codm " +
                "order by data desc ;";
            BancoDeDados bd = new BancoDeDados();


            Consulta consulta;
            
            
            Paciente paciente = new Paciente();
            Medicos medico = new Medicos();
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());
            string data = "", hora ="";
            int nroa=0;
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    consulta = new Consulta();
                    medico = new Medicos();
                    paciente = new Paciente();
                    medico.CodM = int.Parse(rdr[0].ToString());
                    medico.Nome = rdr[1].ToString();
                    medico.Idade = int.Parse(rdr[2].ToString());
                    medico.Especialidade = rdr[3].ToString();
                    medico.Cpf = rdr[4].ToString();
                    medico.Cidade = rdr[5].ToString();
                    int.TryParse(rdr[6].ToString(), out nroa);
                    medico.NroA = nroa;
                    paciente.CodP = int.Parse(rdr[7].ToString());
                    paciente.Nome = rdr[8].ToString();
                    paciente.Idade = int.Parse(rdr[9].ToString());
                    paciente.Cpf = rdr[10].ToString();
                    paciente.Cidade = rdr[11].ToString();
                    paciente.Doenca = rdr[12].ToString();
                    data = rdr[13].ToString();
                    hora = rdr[14].ToString();
                    DateTime dataHora = new DateTime();
                    
                    data = data.Split(' ')[0];
                    Console.WriteLine(data+" "+hora);
                    dataHora = DateTime.ParseExact(data+" "+hora, 
                        "dd/MM/yyyy HH:mm:ss", 
                        CultureInfo.InvariantCulture);
                    
                    consulta.dataHora = dataHora;
                    consulta.medicos = medico;
                    consulta.paciente = paciente;
                    lista.Add(consulta);

                }
                rdr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("datahora"+data + " " + hora);
                throw e;

            }

            return lista;
        }

        public object create(object objeto)
        {
            Consulta consulta = (Consulta)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "insert into consultas " +
                    "values(@codm,@codp,@data,@hora)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codm", consulta.medicos.CodM);
                cmd.Parameters.AddWithValue("@codp", consulta.paciente.CodP);
                cmd.Parameters.AddWithValue("@data", consulta.dataHora.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@hora", consulta.dataHora.ToString("HH:mm:ss"));
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return consulta;
        }

        public object delete(object chave)
        {
            Consulta consulta = (Consulta)chave;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = @"delete from consultas 
                                  where data=@data and hora=@hora";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@data", consulta.dataHora.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@hora", consulta.dataHora.ToString("HH:mm:ss"));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Excluido com sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return consulta;
        }

        public object read(object chave)
        {
            throw new NotImplementedException();
        }

        public object update(object objeto)
        {
            Consulta consulta = (Consulta)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = @"update consultas 
                    set data=@data , hora=@hora
                    where codm=@CodM and codp=@CodP";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codm", consulta.medicos.CodM);
                cmd.Parameters.AddWithValue("@codp", consulta.paciente.CodP);
                cmd.Parameters.AddWithValue("@data", consulta.dataHora.ToString("yyyy-mm-dd"));
                cmd.Parameters.AddWithValue("@hora", consulta.dataHora.ToString("hh:mm:ss"));


                cmd.ExecuteNonQuery();
                MessageBox.Show("Criado com Sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return consulta;
        }
    }
}
