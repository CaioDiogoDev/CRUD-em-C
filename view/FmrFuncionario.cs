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

namespace Clinica.view
{
    public partial class FmrFuncionarios : Form
    {
        public FmrFuncionarios()
        {
            InitializeComponent();
        }

        public FmrFuncionarios(ArrayList funcionarios)
        {
            
            InitializeComponent();
            

            int x = 0;
            foreach (Funcionarios i in funcionarios)
            {
                this.Listagem.Rows.Add();
                this.Listagem.Rows[x].Cells[0].Value = i.CodF;
                this.Listagem.Rows[x].Cells[1].Value = i.Nome;
                this.Listagem.Rows[x].Cells[2].Value = i.Idade;
                this.Listagem.Rows[x].Cells[3].Value = i.Cpf;
                this.Listagem.Rows[x].Cells[0].Value = i.Cidade;
                this.Listagem.Rows[x].Cells[5].Value = i.Salario;
                this.Listagem.Rows[x].Cells[6].Value = i.Cargo;

                x++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            novoFun nfun = new novoFun();
            nfun.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inicio ini = new Inicio();
            ini.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            edtFuncionarios fun = new edtFuncionarios();
            fun.Show();
            this.Close();
        }
    }
}
