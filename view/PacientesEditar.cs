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
    public partial class PacientesEditar : Form
    {
        

        
        
        public PacientesEditar(object paciente)
        {
            InitializeComponent();
            Paciente p = (Paciente) paciente;
            this.codigoValor.Text = p.CodP.ToString();
            this.nomeValor.Text = p.Nome;
            this.idadeValor.Text = p.Idade.ToString();
            this.cpfValor.Text = p.Cpf;
            this.doencaValor.Text = p.Especialidade;
            this.cidadeValor.Text = p.Cidade;
        }

        private void PacientesEditar_Load(object sender, EventArgs e)
        {

        }

        private void titulo_label_Click(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente.CodP = int.Parse(this.codigoValor.Text);
            paciente.Nome = this.nomeValor.Text;
            paciente.Idade = int.Parse(this.idadeValor.Text);
            paciente.Cidade = this.cidadeValor.Text;
            paciente.Cpf = this.cpfValor.Text;
            paciente.Especialidade = this.doencaValor.Text;

            PacienteController controller = new PacienteController();
            controller.salvar(paciente);
            this.Close();
            
        }
    }
}
