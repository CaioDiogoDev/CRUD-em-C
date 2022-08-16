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
    public partial class criarConsulta : Form
    {
        public criarConsulta(ArrayList medicos, ArrayList paciente)
        {
            InitializeComponent();
        }
        public criarConsulta()
        {
            InitializeComponent();
        }

        private void titulo_label_Click(object sender, EventArgs e)
        {

        }

        private void codigo_label_Click(object sender, EventArgs e)
        {

        }

        private void cidade_label_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            ConsultaController consultaController = new ConsultaController();
            consultaController.listar();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaController controller = new ConsultaController();
            string medico = this.medicos_combo.SelectedItem.ToString();

            this.Close();
        }

        private void codigoValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
