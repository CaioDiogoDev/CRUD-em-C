using System;
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
    public partial class PacientesCriar : Form
    {
        public PacientesCriar()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PacienteController paciente = new PacienteController();
            paciente.listar();
            this.Close();
        }

        private void PacientesCriar_Load(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente.Nome = this.nomeValor.Text;
            paciente.Idade = int.Parse(this.idadeValor.Text);
            paciente.Cidade = this.cidadeValor.Text;
            paciente.Cpf = this.cpfValor.Text;
            paciente.Especialidade = this.doencaValor.Text;

            PacienteController controller = new PacienteController();
            controller.criar(paciente);
               
            this.Close();
        }
    }
}
