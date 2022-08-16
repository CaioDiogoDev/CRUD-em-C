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
    public partial class edtFuncionarios : Form
    {
        public edtFuncionarios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FmrFuncionarios funcionarios = new FmrFuncionarios();
            funcionarios.Show();
            this.Close();
        }

        public edtFuncionarios(object funcionario)
        {
            InitializeComponent();

            Funcionarios func = (Funcionarios)funcionario;
            this.SalarioValor.Text = func.CodF.ToString();
            this.nomeValor.Text = func.Nome;
            this.cpfValor.Text = func.Cpf;
            this.idadeValor.Text = func.Idade.ToString();
            this.cidadeValor.Text = func.Cidade;
            this.SalarioValor.Text = func.Salario.ToString();
            this.CargoValor.Text = func.Cargo;

        }

        private void codigoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {

        }
    }
}
