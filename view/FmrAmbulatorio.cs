using Clinica.controller;
using Clinica.model;
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
    public partial class FmrAmbulatorio : Form
    {
        public FmrAmbulatorio(ArrayList ambulatorio)
        {
            InitializeComponent();
            int x = 0;
            foreach (Ambulatorio i in ambulatorio)
            {
                this.listagem.Rows.Add();
                this.listagem.Rows[x].Cells[0].Value = i.Nroa;
                this.listagem.Rows[x].Cells[1].Value = i.Andar;
                this.listagem.Rows[x].Cells[2].Value = i.Capacidade;

                x++;

            }
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            Inicio ini = new Inicio();
            ini.Show();
            this.Hide();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;

            String Nroa = this.listagem.Rows[rowindex].Cells[0].Value.ToString();
            String Andar = this.listagem.Rows[rowindex].Cells[1].Value.ToString();
            String Capacidade = this.listagem.Rows[rowindex].Cells[2].Value.ToString();
            
            Ambulatorio ambulatorio = new Ambulatorio();
            ambulatorio.Nroa = int.Parse(Nroa);
            ambulatorio.Andar = int.Parse(Andar);
            ambulatorio.Capacidade = int.Parse(Capacidade);
           

            AmbulatorioController controller = new AmbulatorioController();
            controller.alterar(ambulatorio);
            this.Close();
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;

            String Nroa = this.listagem.Rows[rowindex].Cells[0].Value.ToString();
            String Andar = this.listagem.Rows[rowindex].Cells[1].Value.ToString();
            String Capacidade = this.listagem.Rows[rowindex].Cells[2].Value.ToString();

            Ambulatorio ambulatorio = new Ambulatorio();
            ambulatorio.Nroa = int.Parse(Nroa);
            ambulatorio.Andar = int.Parse(Andar);
            ambulatorio.Capacidade = int.Parse(Capacidade);


            AmbulatorioController controller = new AmbulatorioController();
            controller.deletar(ambulatorio);
            this.Close();
        }

        private void Criar_Click(object sender, EventArgs e)
        {
            criarAmbulatorio novo = new criarAmbulatorio();
            novo.Show();
            this.Close();

        }
    }
}
