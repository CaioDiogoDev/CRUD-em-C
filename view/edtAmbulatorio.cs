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
    public partial class edtAmbulatorio : Form
    {
        public edtAmbulatorio(object ambulatorio)
        {
            InitializeComponent();
            Ambulatorio a = (Ambulatorio)ambulatorio;
            
            this.andarValor.Text = a.Andar.ToString();
            this.capacidadeValor.Text = a.Capacidade.ToString();
         
        }

        private void codigoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void capacidadeValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            AmbulatorioController controller = new AmbulatorioController();
            controller.listar();
            this.Hide();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            Ambulatorio ambulatorio = new Ambulatorio();
            ambulatorio.Andar = int.Parse(this.andarValor.Text);
            ambulatorio.Capacidade = int.Parse(this.capacidadeValor.Text);

            AmbulatorioController controller = new AmbulatorioController();
            controller.salvar(ambulatorio);

            this.Close();
        }
    }
}
