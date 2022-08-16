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
    public partial class edtMedico : Form
    {
        public edtMedico(object medicos)
        {
            InitializeComponent();
             Medicos m = (Medicos) medicos;
            this.codigoValor.Text = m.CodM.ToString();
            this.nomeValor.Text = m.Nome;
            this.idadeValor.Text = m.Idade.ToString();
            this.CidadeValor.Text = m.Cidade;
            this.CpfValor.Text = m.Cpf;
            this.EspecialidadeValor.Text = m.Especialidade;
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            FmrMedicos med = new FmrMedicos();
            med.Show();
            this.Close();
        }

        private void cidadeValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            Medicos medicos = new Medicos();
            medicos.CodM = int.Parse(this.codigoValor.Text);
            medicos.Nome = this.nomeValor.Text;
            medicos.Idade = int.Parse(this.idadeValor.Text);
            medicos.Cidade = this.CidadeValor.Text;
            medicos.Cpf = this.CpfValor.Text;
            medicos.Especialidade = this.EspecialidadeValor.Text;

            MedicoController controller = new MedicoController();
            controller.salvar(medicos);
            this.Close();
        }
    }
}
