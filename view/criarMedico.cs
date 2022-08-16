using Clinica.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.view
{
    public partial class criarMedico : Form
    {
        public criarMedico()
        {
            InitializeComponent();
        }

        private void Criaçao_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            FmrMedicos med = new FmrMedicos();
            med.Show();
            this.Close();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            Medicos medico = new Medicos();
            medico.Nome = this.nomeValor.Text;
            medico.Idade = int.Parse(this.idadeValor.Text);
            medico.Cpf = this.cpfValor.Text;
            medico.Especialidade = this.especialidadeValor.Text;
            medico.Cidade = this.cidadeValor.Text;
            medico.NroA = int.Parse(this.AmbulatorioValor.Text);

            MedicoController controller = new MedicoController();
            controller.criar(medico);

            this.Close();
            
        }

        private void nomeValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void doencaValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
