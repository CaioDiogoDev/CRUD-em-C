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
            foreach (Medicos m in medicos)
                this.medicos_combo.Items.Add(m.CodM + " - " + m.Nome);
            foreach (Paciente p in paciente)
                this.pacientes_combo.Items.Add(p.CodP + " - " + p.Nome);
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
            string paciente = this.pacientes_combo.SelectedItem.ToString();
            DateTime dataHora = this.dataHoraConsulta.Value;
            Medicos m = new Medicos();
            Paciente p = new Paciente();
            m.CodM = int.Parse(medico.Split(' ')[0]);
            p.CodP = int.Parse(paciente.Split(' ')[0]);
            Consulta consulta = new Consulta();
            consulta.medicos = m;
            consulta.paciente = p;
            consulta.dataHora = dataHora;
            controller.salvar(consulta);
            this.Close();
        }

        private void codigoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            ConsultaController consulta = new ConsultaController();
            consulta.listar();
            this.Close();
        }

        private void medicos_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
