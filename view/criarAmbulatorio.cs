using Clinica.controller;
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
    public partial class criarAmbulatorio : Form
    {
        public criarAmbulatorio()
        {
            InitializeComponent();
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
            controller.criar(ambulatorio);

            this.Close();
        }
    }
}
