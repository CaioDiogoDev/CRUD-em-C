﻿using System;
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
    public partial class Pacientes : Form
    {
        public Pacientes()
        {
            InitializeComponent();
            
        }
        public Pacientes(ArrayList pacientes)
        {
            InitializeComponent();

            this.listagem.DataSource = pacientes;
            /*int x = 0;
            foreach (Paciente p in pacientes)
            {
                this.listagem.Rows.Add();
                this.listagem.Rows[x].Cells[0].Value = p.codp;
                this.listagem.Rows[x].Cells[1].Value = p.nome;
                this.listagem.Rows[x].Cells[2].Value = p.idade;
                this.listagem.Rows[x].Cells[3].Value = p.cpf;
                this.listagem.Rows[x].Cells[4].Value = p.cidade;
                this.listagem.Rows[x].Cells[5].Value = p.doenca;
                x++;
            }*/

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filtroValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PacientesCriar pacienteCriar = new PacientesCriar();
            pacienteCriar.Show();
            this.Close();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;

            String codp = this.listagem.Rows[rowindex].Cells[0].Value.ToString();
            String nome = this.listagem.Rows[rowindex].Cells[1].Value.ToString();
            String idade = this.listagem.Rows[rowindex].Cells[2].Value.ToString();
            String cidade = this.listagem.Rows[rowindex].Cells[3].Value.ToString();
            String cpf = this.listagem.Rows[rowindex].Cells[4].Value.ToString();
            String doenca = this.listagem.Rows[rowindex].Cells[5].Value.ToString();
            Paciente paciente = new Paciente();
            paciente.CodP = int.Parse(codp);
            paciente.Nome = nome;
            paciente.Idade = int.Parse(idade);
            paciente.Cpf = cpf;
            paciente.Cidade = cidade;
            paciente.Especialidade = doenca;

            PacienteController controller = new PacienteController();
            controller.alterar(paciente);
            this.Close();
    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;

            String codp = this.listagem.Rows[rowindex].Cells[0].Value.ToString();
            String nome = this.listagem.Rows[rowindex].Cells[1].Value.ToString();
            String idade = this.listagem.Rows[rowindex].Cells[2].Value.ToString();
            String cidade = this.listagem.Rows[rowindex].Cells[3].Value.ToString();
            String cpf = this.listagem.Rows[rowindex].Cells[4].Value.ToString();
            String doenca = this.listagem.Rows[rowindex].Cells[5].Value.ToString();
            Paciente paciente = new Paciente();
            paciente.CodP = int.Parse(codp);
            paciente.Nome = nome;
            paciente.Idade = int.Parse(idade);
            paciente.Cpf = cpf;
            paciente.Cidade = cidade;
            paciente.Especialidade = doenca;

            PacienteController controller = new PacienteController();
            controller.deletar(paciente);
            this.Close();

        }
    }
}
