using Clinica.model;
using Clinica.view;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class FmrMedicos : Form
    {
        public FmrMedicos()
        {
            InitializeComponent();
           
        }

        public FmrMedicos(ArrayList medicos)
        {
            //MessageBox.Show("Esta aqui");
            InitializeComponent();
           // this.listagem.DataSource = medicos;

            int x = 0;
            foreach (Medicos i in medicos)
            {
                this.listagem.Rows.Add();
                this.listagem.Rows[x].Cells[0].Value = i.CodM;
                this.listagem.Rows[x].Cells[1].Value = i.Nome;
                this.listagem.Rows[x].Cells[2].Value = i.Idade;
                this.listagem.Rows[x].Cells[3].Value = i.Cpf;
                this.listagem.Rows[x].Cells[4].Value = i.Especialidade;
                this.listagem.Rows[x].Cells[5].Value = i.NroA;

                x++;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inicio ini = new Inicio();
            ini.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            criarMedico criaMed = new criarMedico(); 
            criaMed.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;

            String CodM = this.listagem.Rows[rowindex].Cells[0].Value.ToString();
            String Nome = this.listagem.Rows[rowindex].Cells[1].Value.ToString();
            String Idade = this.listagem.Rows[rowindex].Cells[2].Value.ToString();
            String Cidade = this.listagem.Rows[rowindex].Cells[3].Value.ToString();
            String Cpf = this.listagem.Rows[rowindex].Cells[4].Value.ToString();
            String Especialidade = this.listagem.Rows[rowindex].Cells[5].Value.ToString();
            String nroa = this.listagem.Rows[rowindex].Cells[5].Value.ToString();
            Medicos medicos = new Medicos();
            medicos.CodM = int.Parse(CodM);
            medicos.Nome = Nome;
            medicos.Idade = int.Parse(Idade);
            medicos.Cpf = Cpf;
            medicos.Cidade = Cidade;
            medicos.Especialidade = Especialidade;
            medicos.NroA =int.Parse(nroa);


            MedicoController controller = new MedicoController();
            controller.deletar(medicos);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;

            String CodM = this.listagem.Rows[rowindex].Cells[0].Value.ToString();
            String Nome = this.listagem.Rows[rowindex].Cells[1].Value.ToString();
            String Idade = this.listagem.Rows[rowindex].Cells[2].Value.ToString();
            String Cidade = this.listagem.Rows[rowindex].Cells[3].Value.ToString();
            String Cpf = this.listagem.Rows[rowindex].Cells[4].Value.ToString();
            String Especialidade = this.listagem.Rows[rowindex].Cells[5].Value.ToString();
            String nroa = this.listagem.Rows[rowindex].Cells[5].Value.ToString();
            Medicos medicos = new Medicos();
            medicos.CodM = int.Parse(CodM);
            medicos.Nome = Nome;
            medicos.Idade = int.Parse(Idade);
            medicos.Cpf = Cpf;
            medicos.Cidade = Cidade;
            medicos.Especialidade = Especialidade;
            medicos.NroA = int.Parse(nroa);

            MedicoController controller = new MedicoController();
            controller.alterar(medicos);
            this.Close();

        }
    }
}
