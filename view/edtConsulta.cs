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
    public partial class edtConsulta : Form
    {
        public edtConsulta(ArrayList medicos, ArrayList pacientes, object objeto)
        {
            
            InitializeComponent();
            foreach (Medicos m in medicos)
                this.medicos_combo.Items.Add(m.CodM + " - " + m.Nome);
            foreach (Paciente p in pacientes)
                this.pacientes_combo.Items.Add(p.CodP + " - " + p.Nome);
            Consulta c = (Consulta)objeto;
            this.medicos_combo.Text = c.medicos.CodM + " - " + c.medicos.Nome;
            this.pacientes_combo.Text = c.paciente.CodP+ " - " + c.paciente.Nome;

            this.dataHoraConsulta.Text = c.dataHora.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultaController controller = new ConsultaController();
            controller.listar();
            this.Close();
        }

        private void Medicos_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            ConsultaController controller = new ConsultaController();
            string medico = this.medicos_combo.SelectedItem.ToString();
            string pacinete = this.pacientes_combo.SelectedItem.ToString();
            DateTime dataHora = this.dataHoraConsulta.Value;
            Medicos m = new Medicos();
            Paciente p = new Paciente();
            m.CodM = int.Parse(medico.Split(' ')[0]);
            p.CodP = int.Parse(pacinete.Split(' ')[0]);
            Consulta consulta = new Consulta();
            consulta.medicos = m;
            consulta.paciente = p;
            consulta.dataHora = dataHora;
            controller.salvar(consulta);

            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
