using Clinica.controller;
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

namespace Clinica
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            this.SetVisibleCore(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pacienteBtn_Click(object sender, EventArgs e)
        {
            
            PacienteController pacienteController= new PacienteController();
            pacienteController.listar();
            
            this.Hide();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void medicoBtn_Click(object sender, EventArgs e)
        {
            MedicoController MecCon = new MedicoController();
            MecCon.listar();
            this.Hide();
            
        }

        private void funcionarioBtn_Click(object sender, EventArgs e)
        {
            FuncionarioController fun = new FuncionarioController();
            fun.listar();
            this.Hide();
        }

        private void consultaBtn_Click(object sender, EventArgs e)
        {
            ConsultaController controller = new ConsultaController();
            controller.listar();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AmbulatorioController controller = new AmbulatorioController();
            controller.listar();
            this.Hide();
        }
    }
}
